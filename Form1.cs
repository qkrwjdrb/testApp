using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
using NetExchange;

namespace testApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task.Run(() => RtuMessageService());
            Task.Run(() => ExtMessageService());
            Task.Run(() => CmdMessageService());
        }
        #region grpc


        private static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5044");
        internal static ExProto.ExProtoClient exchange = new ExProto.ExProtoClient(channel);

        internal static AsyncDuplexStreamingCall<RtuMessage, RtuMessage> rtuLink = exchange.MessageRtu();
        internal static AsyncDuplexStreamingCall<ExtMessage, ExtMessage> extLink = exchange.MessageExt();
        internal static AsyncDuplexStreamingCall<CmdMessage, CmdMessage> cmdLink = exchange.MessageCmd();

        internal UInt16 TxCnt;

        private async void RtuMessageService()
        {
            try
            {
                while (await rtuLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = rtuLink.ResponseStream.Current;
                    byte[] payload = new byte[response.DataUnit.Length];
                    response.DataUnit.CopyTo(payload, 0);
                    RxRtu((UInt16)response.SequenceNumber, response.GwId, response.DeviceId, payload);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                //Application.Exit();
            }
        }

        private async void ExtMessageService()
        {
            try
            {
                while (await extLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = extLink.ResponseStream.Current;
                    byte[] payload = new byte[response.DataUnit.Length];
                    response.DataUnit.CopyTo(payload, 0);
                    RxExt(response.Context, response.GwId, response.DeviceId, payload);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                //Application.Exit();
            }
        }

        private async void CmdMessageService()
        {
            try
            {
                while (await cmdLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = cmdLink.ResponseStream.Current;
                    byte[] payload = new byte[response.Payload.Length];
                    response.Payload.CopyTo(payload, 0);
                    RxCmd((UInt16)response.OpCode, response.Route, response.Argument, response.GwId, response.DeviceId, payload);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                //Application.Exit();
            }
        }
        private String GetProtocolChannelName(UInt16 channel)
        {
            switch (channel)
            {
                case 0:
                    return "Modbus";
            }

            return "Unknown probotol";
        }
        static private readonly ushort[] wCRCTable =
        {
            0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241, 0xC601, 0x06C0,
            0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440, 0xCC01, 0x0CC0, 0x0D80, 0xCD41,
            0x0F00, 0xCFC1, 0xCE81, 0x0E40, 0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0,
            0x0880, 0xC841, 0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40,
            0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41, 0x1400, 0xD4C1,
            0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641, 0xD201, 0x12C0, 0x1380, 0xD341,
            0x1100, 0xD1C1, 0xD081, 0x1040, 0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1,
            0xF281, 0x3240, 0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,
            0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41, 0xFA01, 0x3AC0,
            0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840, 0x2800, 0xE8C1, 0xE981, 0x2940,
            0xEB01, 0x2BC0, 0x2A80, 0xEA41, 0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1,
            0xEC81, 0x2C40, 0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640,
            0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041, 0xA001, 0x60C0,
            0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240, 0x6600, 0xA6C1, 0xA781, 0x6740,
            0xA501, 0x65C0, 0x6480, 0xA441, 0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0,
            0x6E80, 0xAE41, 0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,
            0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41, 0xBE01, 0x7EC0,
            0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40, 0xB401, 0x74C0, 0x7580, 0xB541,
            0x7700, 0xB7C1, 0xB681, 0x7640, 0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0,
            0x7080, 0xB041, 0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241,
            0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440, 0x9C01, 0x5CC0,
            0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40, 0x5A00, 0x9AC1, 0x9B81, 0x5B40,
            0x9901, 0x59C0, 0x5880, 0x9841, 0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1,
            0x8A81, 0x4A40, 0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,
            0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641, 0x8201, 0x42C0,
            0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040
        };
        public byte[] fn_makeCRC16_byte(byte[] bytes)
        {
            int ilen = bytes.Length;
            int icrc = 0xFFFF;
            for (int i = 0; i < ilen; i++)
            {
                icrc = (icrc >> 8) ^ wCRCTable[(icrc ^ bytes[i]) & 0xff];
            }
            byte[] ret = BitConverter.GetBytes((ushort)icrc);

            return ret;
        }
        public void TxRtu(UInt16 sequenceNumber, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {

            //addressSaveFile();
            //gatewaySaveFile();
            UInt16 channel = 0;
            var list = new List<byte>();
            list.AddRange(payload);
            list.AddRange(fn_makeCRC16_byte(payload));
            payload = list.ToArray();

            this.Invoke((MethodInvoker)delegate ()
            {
            });

            rtuLink.RequestStream.WriteAsync(new RtuMessage
            {
                Channel = channel,
                SequenceNumber = sequenceNumber,
                GwId = gatewayId,
                DeviceId = deviceId,
                DataUnit = ByteString.CopyFrom(payload[0..payload.Length])
            });
        }

        public byte deviceCount = 30;
        public void RxRtu(UInt16 acknowledgeNumber, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {

            UInt16 channel = 0;

            this.Invoke((MethodInvoker)delegate ()
            {

            });

            switch (channel)
            {
                case 0:
                    /* Modbus protocol */
                    break;
                default:
                    /* Unknown protocol */
                    break;
            }
        }

        public void TxExt(UInt64 context, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            UInt16 channel = (UInt16)context;

            this.Invoke((MethodInvoker)delegate ()
            {

            });

            extLink.RequestStream.WriteAsync(new ExtMessage
            {
                Context = context,
                GwId = gatewayId,
                DeviceId = deviceId,
                DataUnit = ByteString.CopyFrom(payload[0..payload.Length])
            });

        }

        public void RxExt(UInt64 context, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            UInt16 channel = (UInt16)context;

            this.Invoke((MethodInvoker)delegate ()
            {

            });

            switch (channel)
            {
                case 0: /* Modbus Salve Processing */
                    TxExt(context, gatewayId, deviceId, new byte[] { /* Response Message */ });
                    break;
            }
        }
        public void TxCmd(UInt16 opCode, UInt32 route, UInt32 argument, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            this.Invoke((MethodInvoker)delegate ()
            {

            });

            cmdLink.RequestStream.WriteAsync(new CmdMessage
            {
                OpCode = opCode,
                Route = route,
                Argument = argument,
                GwId = gatewayId,
                DeviceId = deviceId,
                Payload = ByteString.CopyFrom(payload[0..payload.Length])
            });
        }

        public void RxCmd(UInt16 opCode, UInt32 route, UInt32 argument, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            this.Invoke((MethodInvoker)delegate ()
            {

            });

            switch (opCode)
            {
                case 0:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                    });
                    break;
            }
        }
        #endregion

        #region 제어 함수

        ushort opid = 0;
        void switch1ON(uint gatewayAddress, ulong deviceAddress)
        {
            //스위치1 켜기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x00, 0xC9, (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void timedSwitch1ON(uint gatewayAddress, ulong deviceAddress, int time)
        {
            //타이머 스위치1 켜기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x00, 0xCA, (byte)(opid>>8),(byte)opid,(byte)(time>>8), (byte)time, 0x00, 0x00
            });
            opid++;
        }
        void switch1OFF(uint gatewayAddress, ulong deviceAddress)
        {
            //스위치1 끄기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x00, 0x00, (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void switch2ON(uint gatewayAddress, ulong deviceAddress)
        {
            //스위치2 켜기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xFb, 0x00, 0x04, 0x08,
                0x00, 0xC9, (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void timedSwitch2ON(uint gatewayAddress, ulong deviceAddress, int time)
        {
            //타이머 스위치2 켜기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xFb, 0x00, 0x04, 0x08,
                0x00, 0xCA, (byte)(opid>>8),(byte)opid,(byte)(time>>8), (byte)time, 0x00, 0x00
            });
            opid++;
        }
        void switch2OFF(uint gatewayAddress, ulong deviceAddress)
        {
            //스위치2 끄기
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xFb, 0x00, 0x04, 0x08,
                0x00, 0x00, (byte)(opid>>8), (byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }



        void leftTurn(uint gatewayAddress, ulong deviceAddress)
        {
            //모터 구동기 죄회전
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x01, 0x2D, (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void rightTurn(uint gatewayAddress, ulong deviceAddress)
        {
            //모터 구동기 우회전
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x01, 0x2E,  (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void timedLeftTurn(uint gatewayAddress, ulong deviceAddress, int time)
        {
            //모터 구동기 타이머 좌회전
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x01, 0x2F,  (byte)(opid>>8),(byte)opid,(byte)(time>>8), (byte)time, 0x00, 0x00
            });
            opid++;
        }
        void timedRightTurn(uint gatewayAddress, ulong deviceAddress, int time)
        {
            //모터 구동기 타이머 우회전
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x01, 0x30, (byte)(opid>>8),(byte)opid,(byte)(time>>8), (byte)time, 0x00, 0x00
            });
            opid++;
        }
        void stopTurn(uint gatewayAddress, ulong deviceAddress)
        {
            //모터 구동기 정지
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                0x00, 0x00,  (byte)(opid>>8),(byte)opid,0x00, 0x00, 0x00, 0x00
            });
            opid++;
        }
        void Reset(uint gatewayAddress, ulong deviceAddress)
        {
            //리셋
            TxRtu(++TxCnt, gatewayAddress, deviceAddress,
            new byte[] {
                0x01, 0x10, 0x01, 0xF5, 0x00, 0x02, 0x04,
                0x00, 0x01,  (byte)(opid>>8),(byte)opid
            });
            opid++;
        }

        #endregion

        #region device1

        private void left1_Click(object sender, EventArgs e)
        {
            leftTurn(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        private void right1_Click(object sender, EventArgs e)
        {
            rightTurn(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void timedLeft1_Click(object sender, EventArgs e)
        {
          int time = 0;
            if (!string.IsNullOrWhiteSpace(timebox1.Text) & int.TryParse(timebox1.Text, out time))
            {
                timedLeftTurn(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timedRight1_Click(object sender, EventArgs e)
        {
            int time = 0;
            if (!string.IsNullOrWhiteSpace(timebox2.Text) & int.TryParse(timebox2.Text, out time))
            {
                timedRightTurn(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void reset1_Click(object sender, EventArgs e)
        {
            Reset(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void stop1_Click(object sender, EventArgs e)
        {
            stopTurn(0, ulong.Parse(device1Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        #endregion

        #region device2

        private void switch1ON2_Click(object sender, EventArgs e)
        {
            switch1ON(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        private void switch2ON2_Click(object sender, EventArgs e)
        {
            switch2ON(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void timedSwitch1ON2_Click(object sender, EventArgs e)
        {
            int time = 0;
            if (!string.IsNullOrWhiteSpace(timebox3.Text) & int.TryParse(timebox3.Text, out time))
            {
                timedSwitch1ON(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
        }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void timedSwitch2ON2_Click(object sender, EventArgs e)
        {
            int time = 0;
            if (!string.IsNullOrWhiteSpace(timebox4.Text) & int.TryParse(timebox4.Text, out time))
            {
                timedSwitch2ON(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
        }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void switch1OFF2_Click(object sender, EventArgs e)
        {
            switch1OFF(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2OFF2_Click(object sender, EventArgs e)
        {
            switch2OFF(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            Reset(0, ulong.Parse(device2Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        #endregion

        #region device3

        private void switch1ON3_Click(object sender, EventArgs e)
        {
            switch1ON(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        private void switch2ON3_Click(object sender, EventArgs e)
        {
            switch2ON(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }


        private void timedSwitch2ON3_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox5.Text) &&int.TryParse(timebox5.Text,out time))
            {

                timedSwitch1ON(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber), time);

            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void timedSwitch1ON3_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox6.Text)&&int.TryParse(timebox6.Text,out time))
            {

            timedSwitch2ON(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switch1OFF3_Click(object sender, EventArgs e)
        {
            switch1OFF(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2OFF3_Click(object sender, EventArgs e)
        {
            switch2OFF(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        private void reset3_Click(object sender, EventArgs e)
        {
            Reset(0, ulong.Parse(device3Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        #endregion

        #region device4

        private void switch1ON4_Click(object sender, EventArgs e)
        {
            switch1ON(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2ON4_Click(object sender, EventArgs e)
        {
            switch2ON(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }


        private void timedSwitch1ON4_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox7.Text)&&int.TryParse(timebox7.Text,out time))
            {

            timedSwitch1ON(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timedSwitch2ON4_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox8.Text) && int.TryParse(timebox8.Text, out time))
            {

            timedSwitch2ON(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void switch1OFF4_Click(object sender, EventArgs e)
        {
            switch1OFF(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2OFF4_Click(object sender, EventArgs e)
        {
            switch2OFF(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void reset4_Click(object sender, EventArgs e)
        {
            Reset(0, ulong.Parse(device4Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        #endregion

        #region device5

        private void switch1ON5_Click(object sender, EventArgs e)
        {
            switch1ON(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2ON5_Click(object sender, EventArgs e)
        {
            switch2ON(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }


        private void switch1OFF5_Click(object sender, EventArgs e)
        {
            switch1OFF(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void switch2OFF5_Click(object sender, EventArgs e)
        {
            switch2OFF(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }

        private void timedSwitch1ON5_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox9.Text) && int.TryParse(timebox9.Text, out time))
            {

            timedSwitch1ON(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber),time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timedSwitch2ON5_Click(object sender, EventArgs e)
        {
            int time;
            if (!string.IsNullOrWhiteSpace(timebox10.Text) && int.TryParse(timebox10.Text, out time))
            {
                timedSwitch2ON(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber), time);
            }
            else
            {
                MessageBox.Show("시간을 확인해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void reset5_Click(object sender, EventArgs e)
        {
            Reset(0, ulong.Parse(device5Box.Text.ToString(), System.Globalization.NumberStyles.HexNumber));
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void device2Box_Enter(object sender, EventArgs e)
        {

        }
    }
}