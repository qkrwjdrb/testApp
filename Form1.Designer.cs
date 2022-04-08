using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.device1Box = new System.Windows.Forms.GroupBox();
            this.전류 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.전압 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.남은시간9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.상태코드9 = new System.Windows.Forms.Label();
            this.상태9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timedRight1 = new System.Windows.Forms.Button();
            this.timedLeft1 = new System.Windows.Forms.Button();
            this.reset1 = new System.Windows.Forms.Button();
            this.right1 = new System.Windows.Forms.Button();
            this.left1 = new System.Windows.Forms.Button();
            this.timebox2 = new System.Windows.Forms.TextBox();
            this.stop1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.timebox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.device3Box = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.남은시간4 = new System.Windows.Forms.Label();
            this.남은시간3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.상태코드4 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.상태코드3 = new System.Windows.Forms.Label();
            this.상태4 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.상태3 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.timedSwitch1OFF3 = new System.Windows.Forms.Button();
            this.timedSwitch1ON3 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.switch2ON3 = new System.Windows.Forms.Button();
            this.switch2OFF3 = new System.Windows.Forms.Button();
            this.switch1ON3 = new System.Windows.Forms.Button();
            this.timebox6 = new System.Windows.Forms.TextBox();
            this.switch1OFF3 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.timebox5 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.device2Box = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.남은시간2 = new System.Windows.Forms.Label();
            this.남은시간1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.상태코드2 = new System.Windows.Forms.Label();
            this.상태코드1 = new System.Windows.Forms.Label();
            this.상태2 = new System.Windows.Forms.Label();
            this.상태1 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.timedSwitch1OFF2 = new System.Windows.Forms.Button();
            this.timedSwitch1ON2 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.switch2ON2 = new System.Windows.Forms.Button();
            this.switch2OFF2 = new System.Windows.Forms.Button();
            this.switch1ON2 = new System.Windows.Forms.Button();
            this.timebox4 = new System.Windows.Forms.TextBox();
            this.switch1OFF2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timebox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.남은시간6 = new System.Windows.Forms.Label();
            this.남은시간5 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.상태코드6 = new System.Windows.Forms.Label();
            this.상태코드5 = new System.Windows.Forms.Label();
            this.상태6 = new System.Windows.Forms.Label();
            this.상태5 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.timedSwitch1OFF4 = new System.Windows.Forms.Button();
            this.timedSwitch1ON4 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.switch2ON4 = new System.Windows.Forms.Button();
            this.switch2OFF4 = new System.Windows.Forms.Button();
            this.switch1ON4 = new System.Windows.Forms.Button();
            this.timebox8 = new System.Windows.Forms.TextBox();
            this.switch1OFF4 = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.timebox7 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.device5Box = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.남은시간8 = new System.Windows.Forms.Label();
            this.남은시간7 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.상태코드8 = new System.Windows.Forms.Label();
            this.상태코드7 = new System.Windows.Forms.Label();
            this.상태8 = new System.Windows.Forms.Label();
            this.상태7 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.timedSwitch1OFF5 = new System.Windows.Forms.Button();
            this.timedSwitch1ON5 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.switch2ON5 = new System.Windows.Forms.Button();
            this.switch2OFF5 = new System.Windows.Forms.Button();
            this.switch1ON5 = new System.Windows.Forms.Button();
            this.timebox10 = new System.Windows.Forms.TextBox();
            this.switch1OFF5 = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.timebox9 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.센서 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.device1Box.SuspendLayout();
            this.device3Box.SuspendLayout();
            this.device2Box.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.device5Box.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // device1Box
            // 
            this.device1Box.Controls.Add(this.전류);
            this.device1Box.Controls.Add(this.label43);
            this.device1Box.Controls.Add(this.전압);
            this.device1Box.Controls.Add(this.label44);
            this.device1Box.Controls.Add(this.남은시간9);
            this.device1Box.Controls.Add(this.label8);
            this.device1Box.Controls.Add(this.상태코드9);
            this.device1Box.Controls.Add(this.상태9);
            this.device1Box.Controls.Add(this.label13);
            this.device1Box.Controls.Add(this.label14);
            this.device1Box.Controls.Add(this.timedRight1);
            this.device1Box.Controls.Add(this.timedLeft1);
            this.device1Box.Controls.Add(this.reset1);
            this.device1Box.Controls.Add(this.right1);
            this.device1Box.Controls.Add(this.left1);
            this.device1Box.Controls.Add(this.timebox2);
            this.device1Box.Controls.Add(this.stop1);
            this.device1Box.Controls.Add(this.label15);
            this.device1Box.Controls.Add(this.timebox1);
            this.device1Box.Controls.Add(this.label16);
            this.device1Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.device1Box.Location = new System.Drawing.Point(1139, 3);
            this.device1Box.Name = "device1Box";
            this.device1Box.Size = new System.Drawing.Size(273, 569);
            this.device1Box.TabIndex = 0;
            this.device1Box.TabStop = false;
            this.device1Box.Text = "500291AEBEF1";
            // 
            // 전류
            // 
            this.전류.AutoSize = true;
            this.전류.Location = new System.Drawing.Point(99, 256);
            this.전류.Name = "전류";
            this.전류.Size = new System.Drawing.Size(11, 15);
            this.전류.TabIndex = 60;
            this.전류.Text = " ";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(34, 257);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(31, 15);
            this.label43.TabIndex = 61;
            this.label43.Text = "전류";
            // 
            // 전압
            // 
            this.전압.AutoSize = true;
            this.전압.Location = new System.Drawing.Point(99, 239);
            this.전압.Name = "전압";
            this.전압.Size = new System.Drawing.Size(11, 15);
            this.전압.TabIndex = 58;
            this.전압.Text = " ";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(34, 239);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(31, 15);
            this.label44.TabIndex = 59;
            this.label44.Text = "전압";
            // 
            // 남은시간9
            // 
            this.남은시간9.AutoSize = true;
            this.남은시간9.Location = new System.Drawing.Point(99, 216);
            this.남은시간9.Name = "남은시간9";
            this.남은시간9.Size = new System.Drawing.Size(11, 15);
            this.남은시간9.TabIndex = 50;
            this.남은시간9.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "남은시간";
            // 
            // 상태코드9
            // 
            this.상태코드9.AutoSize = true;
            this.상태코드9.Location = new System.Drawing.Point(99, 199);
            this.상태코드9.Name = "상태코드9";
            this.상태코드9.Size = new System.Drawing.Size(11, 15);
            this.상태코드9.TabIndex = 54;
            this.상태코드9.Text = " ";
            // 
            // 상태9
            // 
            this.상태9.AutoSize = true;
            this.상태9.Location = new System.Drawing.Point(99, 180);
            this.상태9.Name = "상태9";
            this.상태9.Size = new System.Drawing.Size(11, 15);
            this.상태9.TabIndex = 55;
            this.상태9.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "상태";
            // 
            // timedRight1
            // 
            this.timedRight1.Location = new System.Drawing.Point(150, 347);
            this.timedRight1.Name = "timedRight1";
            this.timedRight1.Size = new System.Drawing.Size(100, 23);
            this.timedRight1.TabIndex = 20;
            this.timedRight1.Text = "타이머우회전";
            this.timedRight1.UseVisualStyleBackColor = true;
            this.timedRight1.Click += new System.EventHandler(this.timedRight1_Click);
            // 
            // timedLeft1
            // 
            this.timedLeft1.Location = new System.Drawing.Point(33, 347);
            this.timedLeft1.Name = "timedLeft1";
            this.timedLeft1.Size = new System.Drawing.Size(100, 23);
            this.timedLeft1.TabIndex = 20;
            this.timedLeft1.Text = "타이머좌회전";
            this.timedLeft1.UseVisualStyleBackColor = true;
            this.timedLeft1.Click += new System.EventHandler(this.timedLeft1_Click);
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(150, 470);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(100, 23);
            this.reset1.TabIndex = 16;
            this.reset1.Text = "리셋";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // right1
            // 
            this.right1.Location = new System.Drawing.Point(150, 286);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(100, 23);
            this.right1.TabIndex = 18;
            this.right1.Text = "우회전";
            this.right1.UseVisualStyleBackColor = true;
            this.right1.Click += new System.EventHandler(this.right1_Click);
            // 
            // left1
            // 
            this.left1.Location = new System.Drawing.Point(33, 286);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(100, 23);
            this.left1.TabIndex = 18;
            this.left1.Text = "좌회전";
            this.left1.UseVisualStyleBackColor = true;
            this.left1.Click += new System.EventHandler(this.left1_Click);
            // 
            // timebox2
            // 
            this.timebox2.Location = new System.Drawing.Point(151, 315);
            this.timebox2.Name = "timebox2";
            this.timebox2.Size = new System.Drawing.Size(66, 23);
            this.timebox2.TabIndex = 22;
            this.timebox2.Text = "5";
            // 
            // stop1
            // 
            this.stop1.Location = new System.Drawing.Point(34, 378);
            this.stop1.Name = "stop1";
            this.stop1.Size = new System.Drawing.Size(216, 23);
            this.stop1.TabIndex = 25;
            this.stop1.Text = "정지";
            this.stop1.UseVisualStyleBackColor = true;
            this.stop1.Click += new System.EventHandler(this.stop1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "(초)";
            // 
            // timebox1
            // 
            this.timebox1.Location = new System.Drawing.Point(34, 315);
            this.timebox1.Name = "timebox1";
            this.timebox1.Size = new System.Drawing.Size(66, 23);
            this.timebox1.TabIndex = 22;
            this.timebox1.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "(초)";
            // 
            // device3Box
            // 
            this.device3Box.Controls.Add(this.label7);
            this.device3Box.Controls.Add(this.label6);
            this.device3Box.Controls.Add(this.남은시간4);
            this.device3Box.Controls.Add(this.남은시간3);
            this.device3Box.Controls.Add(this.label34);
            this.device3Box.Controls.Add(this.label11);
            this.device3Box.Controls.Add(this.상태코드4);
            this.device3Box.Controls.Add(this.label82);
            this.device3Box.Controls.Add(this.상태코드3);
            this.device3Box.Controls.Add(this.상태4);
            this.device3Box.Controls.Add(this.label81);
            this.device3Box.Controls.Add(this.상태3);
            this.device3Box.Controls.Add(this.label88);
            this.device3Box.Controls.Add(this.label80);
            this.device3Box.Controls.Add(this.label87);
            this.device3Box.Controls.Add(this.label39);
            this.device3Box.Controls.Add(this.label79);
            this.device3Box.Controls.Add(this.label40);
            this.device3Box.Controls.Add(this.timedSwitch1OFF3);
            this.device3Box.Controls.Add(this.timedSwitch1ON3);
            this.device3Box.Controls.Add(this.button13);
            this.device3Box.Controls.Add(this.switch2ON3);
            this.device3Box.Controls.Add(this.switch2OFF3);
            this.device3Box.Controls.Add(this.switch1ON3);
            this.device3Box.Controls.Add(this.timebox6);
            this.device3Box.Controls.Add(this.switch1OFF3);
            this.device3Box.Controls.Add(this.label41);
            this.device3Box.Controls.Add(this.timebox5);
            this.device3Box.Controls.Add(this.label42);
            this.device3Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.device3Box.Location = new System.Drawing.Point(287, 3);
            this.device3Box.Name = "device3Box";
            this.device3Box.Size = new System.Drawing.Size(278, 569);
            this.device3Box.TabIndex = 0;
            this.device3Box.TabStop = false;
            this.device3Box.Text = "500291A40A61";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "펌프2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "펌프1";
            // 
            // 남은시간4
            // 
            this.남은시간4.AutoSize = true;
            this.남은시간4.Location = new System.Drawing.Point(216, 216);
            this.남은시간4.Name = "남은시간4";
            this.남은시간4.Size = new System.Drawing.Size(11, 15);
            this.남은시간4.TabIndex = 50;
            this.남은시간4.Text = " ";
            // 
            // 남은시간3
            // 
            this.남은시간3.AutoSize = true;
            this.남은시간3.Location = new System.Drawing.Point(98, 217);
            this.남은시간3.Name = "남은시간3";
            this.남은시간3.Size = new System.Drawing.Size(11, 15);
            this.남은시간3.TabIndex = 50;
            this.남은시간3.Text = " ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(33, 216);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 15);
            this.label34.TabIndex = 51;
            this.label34.Text = "남은시간";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "남은시간";
            // 
            // 상태코드4
            // 
            this.상태코드4.AutoSize = true;
            this.상태코드4.Location = new System.Drawing.Point(216, 199);
            this.상태코드4.Name = "상태코드4";
            this.상태코드4.Size = new System.Drawing.Size(11, 15);
            this.상태코드4.TabIndex = 54;
            this.상태코드4.Text = " ";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(217, 199);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(11, 15);
            this.label82.TabIndex = 54;
            this.label82.Text = " ";
            // 
            // 상태코드3
            // 
            this.상태코드3.AutoSize = true;
            this.상태코드3.Location = new System.Drawing.Point(99, 200);
            this.상태코드3.Name = "상태코드3";
            this.상태코드3.Size = new System.Drawing.Size(11, 15);
            this.상태코드3.TabIndex = 54;
            this.상태코드3.Text = " ";
            // 
            // 상태4
            // 
            this.상태4.AutoSize = true;
            this.상태4.Location = new System.Drawing.Point(216, 180);
            this.상태4.Name = "상태4";
            this.상태4.Size = new System.Drawing.Size(11, 15);
            this.상태4.TabIndex = 55;
            this.상태4.Text = " ";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(217, 180);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(11, 15);
            this.label81.TabIndex = 55;
            this.label81.Text = " ";
            // 
            // 상태3
            // 
            this.상태3.AutoSize = true;
            this.상태3.Location = new System.Drawing.Point(99, 181);
            this.상태3.Name = "상태3";
            this.상태3.Size = new System.Drawing.Size(11, 15);
            this.상태3.TabIndex = 55;
            this.상태3.Text = " ";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(171, 46);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(11, 15);
            this.label88.TabIndex = 56;
            this.label88.Text = " ";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(152, 198);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(11, 15);
            this.label80.TabIndex = 56;
            this.label80.Text = " ";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(151, 180);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(31, 15);
            this.label87.TabIndex = 57;
            this.label87.Text = "상태";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(34, 199);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(11, 15);
            this.label39.TabIndex = 56;
            this.label39.Text = " ";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(152, 180);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(31, 15);
            this.label79.TabIndex = 57;
            this.label79.Text = "상태";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(34, 181);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 15);
            this.label40.TabIndex = 57;
            this.label40.Text = "상태";
            // 
            // timedSwitch1OFF3
            // 
            this.timedSwitch1OFF3.Location = new System.Drawing.Point(150, 347);
            this.timedSwitch1OFF3.Name = "timedSwitch1OFF3";
            this.timedSwitch1OFF3.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1OFF3.TabIndex = 20;
            this.timedSwitch1OFF3.Text = "타이머2ON";
            this.timedSwitch1OFF3.UseVisualStyleBackColor = true;
            this.timedSwitch1OFF3.Click += new System.EventHandler(this.timedSwitch2ON3_Click);
            // 
            // timedSwitch1ON3
            // 
            this.timedSwitch1ON3.Location = new System.Drawing.Point(33, 347);
            this.timedSwitch1ON3.Name = "timedSwitch1ON3";
            this.timedSwitch1ON3.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1ON3.TabIndex = 20;
            this.timedSwitch1ON3.Text = "타이머1ON";
            this.timedSwitch1ON3.UseVisualStyleBackColor = true;
            this.timedSwitch1ON3.Click += new System.EventHandler(this.timedSwitch1ON3_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(150, 470);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "리셋";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.reset3_Click);
            // 
            // switch2ON3
            // 
            this.switch2ON3.Location = new System.Drawing.Point(150, 286);
            this.switch2ON3.Name = "switch2ON3";
            this.switch2ON3.Size = new System.Drawing.Size(100, 23);
            this.switch2ON3.TabIndex = 18;
            this.switch2ON3.Text = "스위치2ON";
            this.switch2ON3.UseVisualStyleBackColor = true;
            this.switch2ON3.Click += new System.EventHandler(this.switch2ON3_Click);
            // 
            // switch2OFF3
            // 
            this.switch2OFF3.Location = new System.Drawing.Point(150, 378);
            this.switch2OFF3.Name = "switch2OFF3";
            this.switch2OFF3.Size = new System.Drawing.Size(100, 23);
            this.switch2OFF3.TabIndex = 25;
            this.switch2OFF3.Text = "스위치2OFF";
            this.switch2OFF3.UseVisualStyleBackColor = true;
            this.switch2OFF3.Click += new System.EventHandler(this.switch2OFF3_Click);
            // 
            // switch1ON3
            // 
            this.switch1ON3.Location = new System.Drawing.Point(33, 286);
            this.switch1ON3.Name = "switch1ON3";
            this.switch1ON3.Size = new System.Drawing.Size(100, 23);
            this.switch1ON3.TabIndex = 18;
            this.switch1ON3.Text = "스위치1ON";
            this.switch1ON3.UseVisualStyleBackColor = true;
            this.switch1ON3.Click += new System.EventHandler(this.switch1ON3_Click);
            // 
            // timebox6
            // 
            this.timebox6.Location = new System.Drawing.Point(151, 315);
            this.timebox6.Name = "timebox6";
            this.timebox6.Size = new System.Drawing.Size(66, 23);
            this.timebox6.TabIndex = 22;
            this.timebox6.Text = "5";
            // 
            // switch1OFF3
            // 
            this.switch1OFF3.Location = new System.Drawing.Point(34, 378);
            this.switch1OFF3.Name = "switch1OFF3";
            this.switch1OFF3.Size = new System.Drawing.Size(100, 23);
            this.switch1OFF3.TabIndex = 25;
            this.switch1OFF3.Text = "스위치1OFF";
            this.switch1OFF3.UseVisualStyleBackColor = true;
            this.switch1OFF3.Click += new System.EventHandler(this.switch1OFF3_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(223, 319);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(27, 15);
            this.label41.TabIndex = 24;
            this.label41.Text = "(초)";
            // 
            // timebox5
            // 
            this.timebox5.Location = new System.Drawing.Point(34, 315);
            this.timebox5.Name = "timebox5";
            this.timebox5.Size = new System.Drawing.Size(66, 23);
            this.timebox5.TabIndex = 22;
            this.timebox5.Text = "5";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(106, 319);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 15);
            this.label42.TabIndex = 24;
            this.label42.Text = "(초)";
            // 
            // device2Box
            // 
            this.device2Box.Controls.Add(this.label3);
            this.device2Box.Controls.Add(this.label1);
            this.device2Box.Controls.Add(this.남은시간2);
            this.device2Box.Controls.Add(this.남은시간1);
            this.device2Box.Controls.Add(this.label5);
            this.device2Box.Controls.Add(this.label22);
            this.device2Box.Controls.Add(this.상태코드2);
            this.device2Box.Controls.Add(this.상태코드1);
            this.device2Box.Controls.Add(this.상태2);
            this.device2Box.Controls.Add(this.상태1);
            this.device2Box.Controls.Add(this.label84);
            this.device2Box.Controls.Add(this.label83);
            this.device2Box.Controls.Add(this.label27);
            this.device2Box.Controls.Add(this.label28);
            this.device2Box.Controls.Add(this.timedSwitch1OFF2);
            this.device2Box.Controls.Add(this.timedSwitch1ON2);
            this.device2Box.Controls.Add(this.reset2);
            this.device2Box.Controls.Add(this.switch2ON2);
            this.device2Box.Controls.Add(this.switch2OFF2);
            this.device2Box.Controls.Add(this.switch1ON2);
            this.device2Box.Controls.Add(this.timebox4);
            this.device2Box.Controls.Add(this.switch1OFF2);
            this.device2Box.Controls.Add(this.label4);
            this.device2Box.Controls.Add(this.timebox3);
            this.device2Box.Controls.Add(this.label2);
            this.device2Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.device2Box.Location = new System.Drawing.Point(3, 3);
            this.device2Box.Name = "device2Box";
            this.device2Box.Size = new System.Drawing.Size(278, 569);
            this.device2Box.TabIndex = 0;
            this.device2Box.TabStop = false;
            this.device2Box.Text = "24A16057C915";
            this.device2Box.Enter += new System.EventHandler(this.device2Box_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "환풍기2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "환풍기1";
            // 
            // 남은시간2
            // 
            this.남은시간2.AutoSize = true;
            this.남은시간2.Location = new System.Drawing.Point(215, 216);
            this.남은시간2.Name = "남은시간2";
            this.남은시간2.Size = new System.Drawing.Size(11, 15);
            this.남은시간2.TabIndex = 50;
            this.남은시간2.Text = " ";
            // 
            // 남은시간1
            // 
            this.남은시간1.AutoSize = true;
            this.남은시간1.Location = new System.Drawing.Point(98, 216);
            this.남은시간1.Name = "남은시간1";
            this.남은시간1.Size = new System.Drawing.Size(11, 15);
            this.남은시간1.TabIndex = 50;
            this.남은시간1.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "남은시간";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 215);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "남은시간";
            // 
            // 상태코드2
            // 
            this.상태코드2.AutoSize = true;
            this.상태코드2.Location = new System.Drawing.Point(216, 199);
            this.상태코드2.Name = "상태코드2";
            this.상태코드2.Size = new System.Drawing.Size(11, 15);
            this.상태코드2.TabIndex = 54;
            this.상태코드2.Text = " ";
            // 
            // 상태코드1
            // 
            this.상태코드1.AutoSize = true;
            this.상태코드1.Location = new System.Drawing.Point(99, 199);
            this.상태코드1.Name = "상태코드1";
            this.상태코드1.Size = new System.Drawing.Size(11, 15);
            this.상태코드1.TabIndex = 54;
            this.상태코드1.Text = " ";
            // 
            // 상태2
            // 
            this.상태2.AutoSize = true;
            this.상태2.Location = new System.Drawing.Point(216, 180);
            this.상태2.Name = "상태2";
            this.상태2.Size = new System.Drawing.Size(11, 15);
            this.상태2.TabIndex = 55;
            this.상태2.Text = " ";
            // 
            // 상태1
            // 
            this.상태1.AutoSize = true;
            this.상태1.Location = new System.Drawing.Point(99, 180);
            this.상태1.Name = "상태1";
            this.상태1.Size = new System.Drawing.Size(11, 15);
            this.상태1.TabIndex = 55;
            this.상태1.Text = " ";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(151, 198);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(11, 15);
            this.label84.TabIndex = 56;
            this.label84.Text = " ";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(151, 180);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(31, 15);
            this.label83.TabIndex = 57;
            this.label83.Text = "상태";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 15);
            this.label27.TabIndex = 56;
            this.label27.Text = " ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 180);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 15);
            this.label28.TabIndex = 57;
            this.label28.Text = "상태";
            // 
            // timedSwitch1OFF2
            // 
            this.timedSwitch1OFF2.Location = new System.Drawing.Point(150, 347);
            this.timedSwitch1OFF2.Name = "timedSwitch1OFF2";
            this.timedSwitch1OFF2.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1OFF2.TabIndex = 20;
            this.timedSwitch1OFF2.Text = "타이머2ON";
            this.timedSwitch1OFF2.UseVisualStyleBackColor = true;
            this.timedSwitch1OFF2.Click += new System.EventHandler(this.timedSwitch2ON2_Click);
            // 
            // timedSwitch1ON2
            // 
            this.timedSwitch1ON2.Location = new System.Drawing.Point(33, 347);
            this.timedSwitch1ON2.Name = "timedSwitch1ON2";
            this.timedSwitch1ON2.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1ON2.TabIndex = 20;
            this.timedSwitch1ON2.Text = "타이머1ON";
            this.timedSwitch1ON2.UseVisualStyleBackColor = true;
            this.timedSwitch1ON2.Click += new System.EventHandler(this.timedSwitch1ON2_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(150, 470);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(100, 23);
            this.reset2.TabIndex = 16;
            this.reset2.Text = "리셋";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // switch2ON2
            // 
            this.switch2ON2.Location = new System.Drawing.Point(150, 286);
            this.switch2ON2.Name = "switch2ON2";
            this.switch2ON2.Size = new System.Drawing.Size(100, 23);
            this.switch2ON2.TabIndex = 18;
            this.switch2ON2.Text = "스위치2ON";
            this.switch2ON2.UseVisualStyleBackColor = true;
            this.switch2ON2.Click += new System.EventHandler(this.switch2ON2_Click);
            // 
            // switch2OFF2
            // 
            this.switch2OFF2.Location = new System.Drawing.Point(151, 378);
            this.switch2OFF2.Name = "switch2OFF2";
            this.switch2OFF2.Size = new System.Drawing.Size(100, 23);
            this.switch2OFF2.TabIndex = 25;
            this.switch2OFF2.Text = "스위치2OFF";
            this.switch2OFF2.UseVisualStyleBackColor = true;
            this.switch2OFF2.Click += new System.EventHandler(this.switch2OFF2_Click);
            // 
            // switch1ON2
            // 
            this.switch1ON2.Location = new System.Drawing.Point(33, 286);
            this.switch1ON2.Name = "switch1ON2";
            this.switch1ON2.Size = new System.Drawing.Size(100, 23);
            this.switch1ON2.TabIndex = 18;
            this.switch1ON2.Text = "스위치1ON";
            this.switch1ON2.UseVisualStyleBackColor = true;
            this.switch1ON2.Click += new System.EventHandler(this.switch1ON2_Click);
            // 
            // timebox4
            // 
            this.timebox4.Location = new System.Drawing.Point(151, 315);
            this.timebox4.Name = "timebox4";
            this.timebox4.Size = new System.Drawing.Size(66, 23);
            this.timebox4.TabIndex = 22;
            this.timebox4.Text = "5";
            // 
            // switch1OFF2
            // 
            this.switch1OFF2.Location = new System.Drawing.Point(34, 378);
            this.switch1OFF2.Name = "switch1OFF2";
            this.switch1OFF2.Size = new System.Drawing.Size(100, 23);
            this.switch1OFF2.TabIndex = 25;
            this.switch1OFF2.Text = "스위치1OFF";
            this.switch1OFF2.UseVisualStyleBackColor = true;
            this.switch1OFF2.Click += new System.EventHandler(this.switch1OFF2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "(초)";
            // 
            // timebox3
            // 
            this.timebox3.Location = new System.Drawing.Point(34, 315);
            this.timebox3.Name = "timebox3";
            this.timebox3.Size = new System.Drawing.Size(66, 23);
            this.timebox3.TabIndex = 22;
            this.timebox3.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "(초)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.남은시간6);
            this.groupBox5.Controls.Add(this.남은시간5);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.상태코드6);
            this.groupBox5.Controls.Add(this.상태코드5);
            this.groupBox5.Controls.Add(this.상태6);
            this.groupBox5.Controls.Add(this.상태5);
            this.groupBox5.Controls.Add(this.label76);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label75);
            this.groupBox5.Controls.Add(this.label54);
            this.groupBox5.Controls.Add(this.timedSwitch1OFF4);
            this.groupBox5.Controls.Add(this.timedSwitch1ON4);
            this.groupBox5.Controls.Add(this.button20);
            this.groupBox5.Controls.Add(this.switch2ON4);
            this.groupBox5.Controls.Add(this.switch2OFF4);
            this.groupBox5.Controls.Add(this.switch1ON4);
            this.groupBox5.Controls.Add(this.timebox8);
            this.groupBox5.Controls.Add(this.switch1OFF4);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.timebox7);
            this.groupBox5.Controls.Add(this.label56);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(571, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 569);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4C7525C1CF81";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "팬";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "램프";
            // 
            // 남은시간6
            // 
            this.남은시간6.AutoSize = true;
            this.남은시간6.Location = new System.Drawing.Point(215, 216);
            this.남은시간6.Name = "남은시간6";
            this.남은시간6.Size = new System.Drawing.Size(11, 15);
            this.남은시간6.TabIndex = 50;
            this.남은시간6.Text = " ";
            // 
            // 남은시간5
            // 
            this.남은시간5.AutoSize = true;
            this.남은시간5.Location = new System.Drawing.Point(98, 217);
            this.남은시간5.Name = "남은시간5";
            this.남은시간5.Size = new System.Drawing.Size(11, 15);
            this.남은시간5.TabIndex = 50;
            this.남은시간5.Text = " ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(33, 216);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(55, 15);
            this.label48.TabIndex = 51;
            this.label48.Text = "남은시간";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(150, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 51;
            this.label19.Text = "남은시간";
            // 
            // 상태코드6
            // 
            this.상태코드6.AutoSize = true;
            this.상태코드6.Location = new System.Drawing.Point(215, 199);
            this.상태코드6.Name = "상태코드6";
            this.상태코드6.Size = new System.Drawing.Size(11, 15);
            this.상태코드6.TabIndex = 54;
            this.상태코드6.Text = " ";
            // 
            // 상태코드5
            // 
            this.상태코드5.AutoSize = true;
            this.상태코드5.Location = new System.Drawing.Point(98, 200);
            this.상태코드5.Name = "상태코드5";
            this.상태코드5.Size = new System.Drawing.Size(11, 15);
            this.상태코드5.TabIndex = 54;
            this.상태코드5.Text = " ";
            // 
            // 상태6
            // 
            this.상태6.AutoSize = true;
            this.상태6.Location = new System.Drawing.Point(215, 180);
            this.상태6.Name = "상태6";
            this.상태6.Size = new System.Drawing.Size(11, 15);
            this.상태6.TabIndex = 55;
            this.상태6.Text = " ";
            // 
            // 상태5
            // 
            this.상태5.AutoSize = true;
            this.상태5.Location = new System.Drawing.Point(98, 181);
            this.상태5.Name = "상태5";
            this.상태5.Size = new System.Drawing.Size(11, 15);
            this.상태5.TabIndex = 55;
            this.상태5.Text = " ";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(150, 198);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(11, 15);
            this.label76.TabIndex = 56;
            this.label76.Text = " ";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(33, 199);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(11, 15);
            this.label53.TabIndex = 56;
            this.label53.Text = " ";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(150, 180);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(31, 15);
            this.label75.TabIndex = 57;
            this.label75.Text = "상태";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(33, 181);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(31, 15);
            this.label54.TabIndex = 57;
            this.label54.Text = "상태";
            // 
            // timedSwitch1OFF4
            // 
            this.timedSwitch1OFF4.Location = new System.Drawing.Point(150, 347);
            this.timedSwitch1OFF4.Name = "timedSwitch1OFF4";
            this.timedSwitch1OFF4.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1OFF4.TabIndex = 20;
            this.timedSwitch1OFF4.Text = "타이머2ON";
            this.timedSwitch1OFF4.UseVisualStyleBackColor = true;
            this.timedSwitch1OFF4.Click += new System.EventHandler(this.timedSwitch2ON4_Click);
            // 
            // timedSwitch1ON4
            // 
            this.timedSwitch1ON4.Location = new System.Drawing.Point(33, 347);
            this.timedSwitch1ON4.Name = "timedSwitch1ON4";
            this.timedSwitch1ON4.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1ON4.TabIndex = 20;
            this.timedSwitch1ON4.Text = "타이머1ON";
            this.timedSwitch1ON4.UseVisualStyleBackColor = true;
            this.timedSwitch1ON4.Click += new System.EventHandler(this.timedSwitch1ON4_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(150, 470);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(100, 23);
            this.button20.TabIndex = 16;
            this.button20.Text = "리셋";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.reset4_Click);
            // 
            // switch2ON4
            // 
            this.switch2ON4.Location = new System.Drawing.Point(150, 286);
            this.switch2ON4.Name = "switch2ON4";
            this.switch2ON4.Size = new System.Drawing.Size(100, 23);
            this.switch2ON4.TabIndex = 18;
            this.switch2ON4.Text = "스위치2ON";
            this.switch2ON4.UseVisualStyleBackColor = true;
            this.switch2ON4.Click += new System.EventHandler(this.switch2ON4_Click);
            // 
            // switch2OFF4
            // 
            this.switch2OFF4.Location = new System.Drawing.Point(150, 378);
            this.switch2OFF4.Name = "switch2OFF4";
            this.switch2OFF4.Size = new System.Drawing.Size(100, 23);
            this.switch2OFF4.TabIndex = 25;
            this.switch2OFF4.Text = "스위치2OFF";
            this.switch2OFF4.UseVisualStyleBackColor = true;
            this.switch2OFF4.Click += new System.EventHandler(this.switch2OFF4_Click);
            // 
            // switch1ON4
            // 
            this.switch1ON4.Location = new System.Drawing.Point(33, 286);
            this.switch1ON4.Name = "switch1ON4";
            this.switch1ON4.Size = new System.Drawing.Size(100, 23);
            this.switch1ON4.TabIndex = 18;
            this.switch1ON4.Text = "스위치1ON";
            this.switch1ON4.UseVisualStyleBackColor = true;
            this.switch1ON4.Click += new System.EventHandler(this.switch1ON4_Click);
            // 
            // timebox8
            // 
            this.timebox8.Location = new System.Drawing.Point(150, 316);
            this.timebox8.Name = "timebox8";
            this.timebox8.Size = new System.Drawing.Size(66, 23);
            this.timebox8.TabIndex = 22;
            this.timebox8.Text = "5";
            // 
            // switch1OFF4
            // 
            this.switch1OFF4.Location = new System.Drawing.Point(34, 378);
            this.switch1OFF4.Name = "switch1OFF4";
            this.switch1OFF4.Size = new System.Drawing.Size(100, 23);
            this.switch1OFF4.TabIndex = 25;
            this.switch1OFF4.Text = "스위치1OFF";
            this.switch1OFF4.UseVisualStyleBackColor = true;
            this.switch1OFF4.Click += new System.EventHandler(this.switch1OFF4_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(222, 320);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(27, 15);
            this.label55.TabIndex = 24;
            this.label55.Text = "(초)";
            // 
            // timebox7
            // 
            this.timebox7.Location = new System.Drawing.Point(33, 316);
            this.timebox7.Name = "timebox7";
            this.timebox7.Size = new System.Drawing.Size(66, 23);
            this.timebox7.TabIndex = 22;
            this.timebox7.Text = "5";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(105, 320);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(27, 15);
            this.label56.TabIndex = 24;
            this.label56.Text = "(초)";
            // 
            // device5Box
            // 
            this.device5Box.Controls.Add(this.richTextBox1);
            this.device5Box.Controls.Add(this.남은시간8);
            this.device5Box.Controls.Add(this.남은시간7);
            this.device5Box.Controls.Add(this.label62);
            this.device5Box.Controls.Add(this.label31);
            this.device5Box.Controls.Add(this.상태코드8);
            this.device5Box.Controls.Add(this.상태코드7);
            this.device5Box.Controls.Add(this.상태8);
            this.device5Box.Controls.Add(this.상태7);
            this.device5Box.Controls.Add(this.label72);
            this.device5Box.Controls.Add(this.label67);
            this.device5Box.Controls.Add(this.label71);
            this.device5Box.Controls.Add(this.label68);
            this.device5Box.Controls.Add(this.timedSwitch1OFF5);
            this.device5Box.Controls.Add(this.timedSwitch1ON5);
            this.device5Box.Controls.Add(this.button27);
            this.device5Box.Controls.Add(this.switch2ON5);
            this.device5Box.Controls.Add(this.switch2OFF5);
            this.device5Box.Controls.Add(this.switch1ON5);
            this.device5Box.Controls.Add(this.timebox10);
            this.device5Box.Controls.Add(this.switch1OFF5);
            this.device5Box.Controls.Add(this.label69);
            this.device5Box.Controls.Add(this.timebox9);
            this.device5Box.Controls.Add(this.label70);
            this.device5Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.device5Box.Location = new System.Drawing.Point(855, 3);
            this.device5Box.Name = "device5Box";
            this.device5Box.Size = new System.Drawing.Size(278, 569);
            this.device5Box.TabIndex = 0;
            this.device5Box.TabStop = false;
            this.device5Box.Text = "4C7525C1CF71";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1418, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            // 
            // 남은시간8
            // 
            this.남은시간8.AutoSize = true;
            this.남은시간8.Location = new System.Drawing.Point(215, 216);
            this.남은시간8.Name = "남은시간8";
            this.남은시간8.Size = new System.Drawing.Size(11, 15);
            this.남은시간8.TabIndex = 50;
            this.남은시간8.Text = " ";
            // 
            // 남은시간7
            // 
            this.남은시간7.AutoSize = true;
            this.남은시간7.Location = new System.Drawing.Point(99, 218);
            this.남은시간7.Name = "남은시간7";
            this.남은시간7.Size = new System.Drawing.Size(11, 15);
            this.남은시간7.TabIndex = 50;
            this.남은시간7.Text = " ";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(34, 217);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(55, 15);
            this.label62.TabIndex = 51;
            this.label62.Text = "남은시간";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(150, 215);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 15);
            this.label31.TabIndex = 51;
            this.label31.Text = "남은시간";
            // 
            // 상태코드8
            // 
            this.상태코드8.AutoSize = true;
            this.상태코드8.Location = new System.Drawing.Point(215, 199);
            this.상태코드8.Name = "상태코드8";
            this.상태코드8.Size = new System.Drawing.Size(11, 15);
            this.상태코드8.TabIndex = 54;
            this.상태코드8.Text = " ";
            // 
            // 상태코드7
            // 
            this.상태코드7.AutoSize = true;
            this.상태코드7.Location = new System.Drawing.Point(99, 201);
            this.상태코드7.Name = "상태코드7";
            this.상태코드7.Size = new System.Drawing.Size(11, 15);
            this.상태코드7.TabIndex = 54;
            this.상태코드7.Text = " ";
            // 
            // 상태8
            // 
            this.상태8.AutoSize = true;
            this.상태8.Location = new System.Drawing.Point(215, 180);
            this.상태8.Name = "상태8";
            this.상태8.Size = new System.Drawing.Size(11, 15);
            this.상태8.TabIndex = 55;
            this.상태8.Text = " ";
            // 
            // 상태7
            // 
            this.상태7.AutoSize = true;
            this.상태7.Location = new System.Drawing.Point(99, 182);
            this.상태7.Name = "상태7";
            this.상태7.Size = new System.Drawing.Size(11, 15);
            this.상태7.TabIndex = 55;
            this.상태7.Text = " ";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(150, 198);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(11, 15);
            this.label72.TabIndex = 56;
            this.label72.Text = " ";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(34, 200);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(11, 15);
            this.label67.TabIndex = 56;
            this.label67.Text = " ";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(150, 180);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(31, 15);
            this.label71.TabIndex = 57;
            this.label71.Text = "상태";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(34, 182);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(31, 15);
            this.label68.TabIndex = 57;
            this.label68.Text = "상태";
            // 
            // timedSwitch1OFF5
            // 
            this.timedSwitch1OFF5.Location = new System.Drawing.Point(150, 347);
            this.timedSwitch1OFF5.Name = "timedSwitch1OFF5";
            this.timedSwitch1OFF5.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1OFF5.TabIndex = 20;
            this.timedSwitch1OFF5.Text = "타이머2ON";
            this.timedSwitch1OFF5.UseVisualStyleBackColor = true;
            this.timedSwitch1OFF5.Click += new System.EventHandler(this.timedSwitch2ON5_Click);
            // 
            // timedSwitch1ON5
            // 
            this.timedSwitch1ON5.Location = new System.Drawing.Point(33, 347);
            this.timedSwitch1ON5.Name = "timedSwitch1ON5";
            this.timedSwitch1ON5.Size = new System.Drawing.Size(100, 23);
            this.timedSwitch1ON5.TabIndex = 20;
            this.timedSwitch1ON5.Text = "타이머1ON";
            this.timedSwitch1ON5.UseVisualStyleBackColor = true;
            this.timedSwitch1ON5.Click += new System.EventHandler(this.timedSwitch1ON5_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(150, 470);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(100, 23);
            this.button27.TabIndex = 16;
            this.button27.Text = "리셋";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.reset5_Click);
            // 
            // switch2ON5
            // 
            this.switch2ON5.Location = new System.Drawing.Point(150, 286);
            this.switch2ON5.Name = "switch2ON5";
            this.switch2ON5.Size = new System.Drawing.Size(100, 23);
            this.switch2ON5.TabIndex = 18;
            this.switch2ON5.Text = "스위치2ON";
            this.switch2ON5.UseVisualStyleBackColor = true;
            this.switch2ON5.Click += new System.EventHandler(this.switch2ON5_Click);
            // 
            // switch2OFF5
            // 
            this.switch2OFF5.Location = new System.Drawing.Point(150, 378);
            this.switch2OFF5.Name = "switch2OFF5";
            this.switch2OFF5.Size = new System.Drawing.Size(100, 23);
            this.switch2OFF5.TabIndex = 25;
            this.switch2OFF5.Text = "스위치2OFF";
            this.switch2OFF5.UseVisualStyleBackColor = true;
            this.switch2OFF5.Click += new System.EventHandler(this.switch2OFF5_Click);
            // 
            // switch1ON5
            // 
            this.switch1ON5.Location = new System.Drawing.Point(33, 286);
            this.switch1ON5.Name = "switch1ON5";
            this.switch1ON5.Size = new System.Drawing.Size(100, 23);
            this.switch1ON5.TabIndex = 18;
            this.switch1ON5.Text = "스위치1ON";
            this.switch1ON5.UseVisualStyleBackColor = true;
            this.switch1ON5.Click += new System.EventHandler(this.switch1ON5_Click);
            // 
            // timebox10
            // 
            this.timebox10.Location = new System.Drawing.Point(151, 315);
            this.timebox10.Name = "timebox10";
            this.timebox10.Size = new System.Drawing.Size(66, 23);
            this.timebox10.TabIndex = 22;
            this.timebox10.Text = "5";
            // 
            // switch1OFF5
            // 
            this.switch1OFF5.Location = new System.Drawing.Point(34, 378);
            this.switch1OFF5.Name = "switch1OFF5";
            this.switch1OFF5.Size = new System.Drawing.Size(100, 23);
            this.switch1OFF5.TabIndex = 25;
            this.switch1OFF5.Text = "스위치1OFF";
            this.switch1OFF5.UseVisualStyleBackColor = true;
            this.switch1OFF5.Click += new System.EventHandler(this.switch1OFF5_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(223, 321);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(27, 15);
            this.label69.TabIndex = 24;
            this.label69.Text = "(초)";
            // 
            // timebox9
            // 
            this.timebox9.Location = new System.Drawing.Point(34, 315);
            this.timebox9.Name = "timebox9";
            this.timebox9.Size = new System.Drawing.Size(66, 23);
            this.timebox9.TabIndex = 22;
            this.timebox9.Text = "5";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(106, 319);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(27, 15);
            this.label70.TabIndex = 24;
            this.label70.Text = "(초)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.42229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95015F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.device5Box, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.device2Box, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.device3Box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.device1Box, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1705, 575);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label45, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.센서, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1418, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 569);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(3, 23);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(278, 258);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 307);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(278, 259);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label45.Location = new System.Drawing.Point(3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 15);
            this.label45.TabIndex = 5;
            this.label45.Text = "내부 센서";
            // 
            // 센서
            // 
            this.센서.AutoSize = true;
            this.센서.Location = new System.Drawing.Point(3, 284);
            this.센서.Name = "센서";
            this.센서.Size = new System.Drawing.Size(59, 15);
            this.센서.TabIndex = 5;
            this.센서.Text = "외부 센서";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.device1Box.ResumeLayout(false);
            this.device1Box.PerformLayout();
            this.device3Box.ResumeLayout(false);
            this.device3Box.PerformLayout();
            this.device2Box.ResumeLayout(false);
            this.device2Box.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.device5Box.ResumeLayout(false);
            this.device5Box.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox device1Box;
        public Label 전류;
        private Label label43;
        public Label 전압;
        private Label label44;
        public Label 남은시간9;
        private Label label8;
        public Label 상태코드9;
        public Label 상태9;
        private Label label13;
        private Label label14;
        private Button timedRight1;
        private Button timedLeft1;
        private Button reset1;
        private Button right1;
        private Button left1;
        private TextBox timebox2;
        private Button stop1;
        private Label label15;
        private TextBox timebox1;
        private Label label16;
        private GroupBox device3Box;
        public Label 남은시간4;
        public Label 남은시간3;
        private Label label34;
        private Label label11;
        public Label 상태코드4;
        public Label label82;
        public Label 상태코드3;
        public Label 상태4;
        public Label label81;
        public Label 상태3;
        private Label label88;
        private Label label80;
        private Label label87;
        private Label label39;
        private Label label79;
        private Label label40;
        private Button timedSwitch1OFF3;
        private Button timedSwitch1ON3;
        private Button button13;
        private Button switch2ON3;
        private Button switch2OFF3;
        private Button switch1ON3;
        private TextBox timebox6;
        private Button switch1OFF3;
        private Label label41;
        private TextBox timebox5;
        private Label label42;
        private GroupBox device2Box;
        public Label 남은시간2;
        public Label 남은시간1;
        private Label label5;
        private Label label22;
        public Label 상태코드1;
        public Label 상태2;
        public Label 상태1;
        private Label label83;
        private Label label27;
        private Label label28;
        private Button timedSwitch1OFF2;
        private Button timedSwitch1ON2;
        private Button reset2;
        private Button switch2ON2;
        private Button switch2OFF2;
        private Button switch1ON2;
        private TextBox timebox4;
        private Button switch1OFF2;
        private Label label4;
        private TextBox timebox3;
        private Label label2;
        private GroupBox groupBox5;
        public Label 남은시간6;
        public Label 남은시간5;
        private Label label48;
        private Label label19;
        public Label 상태코드6;
        public Label 상태코드5;
        public Label 상태6;
        public Label 상태5;
        private Label label76;
        private Label label53;
        private Label label75;
        private Label label54;
        private Button timedSwitch1OFF4;
        private Button timedSwitch1ON4;
        private Button button20;
        private Button switch2ON4;
        private Button switch2OFF4;
        private Button switch1ON4;
        private TextBox timebox8;
        private Button switch1OFF4;
        private Label label55;
        private TextBox timebox7;
        private Label label56;
        private GroupBox device5Box;
        public Label 남은시간8;
        public Label 남은시간7;
        private Label label62;
        private Label label31;
        public Label 상태코드8;
        public Label 상태코드7;
        public Label 상태8;
        public Label 상태7;
        private Label label72;
        private Label label67;
        private Label label71;
        private Label label68;
        private Button timedSwitch1OFF5;
        private Button timedSwitch1ON5;
        private Button button27;
        private Button switch2ON5;
        private Button switch2OFF5;
        private Button switch1ON5;
        private TextBox timebox10;
        private Button switch1OFF5;
        private Label label69;
        private TextBox timebox9;
        private Label label70;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Label label45;
        private Label 센서;
        public Label 상태코드2;
        private Label label84;
        private System.Windows.Forms.Timer timer2;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label9;
    }
}