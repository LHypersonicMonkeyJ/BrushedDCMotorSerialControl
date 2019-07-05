namespace BDCMotorControlViaSerial
{
    partial class BDCMotorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDCMotorControl));
            this.btnScanPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSpeed = new System.Windows.Forms.TextBox();
            this.cmbScanPort = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDiscon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMstop = new System.Windows.Forms.Button();
            this.btnMstart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbKp = new System.Windows.Forms.TextBox();
            this.txbKi = new System.Windows.Forms.TextBox();
            this.txbKd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labCurrentV = new System.Windows.Forms.Label();
            this.labMyComd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScanPort
            // 
            this.btnScanPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanPort.Location = new System.Drawing.Point(27, 38);
            this.btnScanPort.Name = "btnScanPort";
            this.btnScanPort.Size = new System.Drawing.Size(75, 23);
            this.btnScanPort.TabIndex = 0;
            this.btnScanPort.Text = "Scan Port";
            this.btnScanPort.UseVisualStyleBackColor = true;
            this.btnScanPort.Click += new System.EventHandler(this.btnScanPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate:";
            // 
            // txbSpeed
            // 
            this.txbSpeed.Location = new System.Drawing.Point(119, 111);
            this.txbSpeed.Name = "txbSpeed";
            this.txbSpeed.Size = new System.Drawing.Size(99, 20);
            this.txbSpeed.TabIndex = 1;
            // 
            // cmbScanPort
            // 
            this.cmbScanPort.FormattingEnabled = true;
            this.cmbScanPort.Location = new System.Drawing.Point(119, 38);
            this.cmbScanPort.Name = "cmbScanPort";
            this.cmbScanPort.Size = new System.Drawing.Size(121, 21);
            this.cmbScanPort.TabIndex = 3;
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(357, 38);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 21);
            this.cmbBaud.TabIndex = 4;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(536, 37);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 149);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // mySerialPort
            // 
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(536, 38);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(75, 23);
            this.btnDiscon.TabIndex = 8;
            this.btnDiscon.Text = "Disconnect";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serial Connection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // btnMstop
            // 
            this.btnMstop.Location = new System.Drawing.Point(28, 149);
            this.btnMstop.Name = "btnMstop";
            this.btnMstop.Size = new System.Drawing.Size(75, 23);
            this.btnMstop.TabIndex = 14;
            this.btnMstop.Text = "Stop";
            this.btnMstop.UseVisualStyleBackColor = true;
            this.btnMstop.Click += new System.EventHandler(this.btnMstop_Click);
            // 
            // btnMstart
            // 
            this.btnMstart.Location = new System.Drawing.Point(28, 109);
            this.btnMstart.Name = "btnMstart";
            this.btnMstart.Size = new System.Drawing.Size(75, 23);
            this.btnMstart.TabIndex = 15;
            this.btnMstart.Text = "Start";
            this.btnMstart.UseVisualStyleBackColor = true;
            this.btnMstart.Click += new System.EventHandler(this.btnMstart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Set Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "RPM";
            // 
            // txbKp
            // 
            this.txbKp.Location = new System.Drawing.Point(284, 111);
            this.txbKp.Name = "txbKp";
            this.txbKp.Size = new System.Drawing.Size(50, 20);
            this.txbKp.TabIndex = 18;
            // 
            // txbKi
            // 
            this.txbKi.Location = new System.Drawing.Point(340, 111);
            this.txbKi.Name = "txbKi";
            this.txbKi.Size = new System.Drawing.Size(50, 20);
            this.txbKi.TabIndex = 19;
            // 
            // txbKd
            // 
            this.txbKd.Location = new System.Drawing.Point(396, 111);
            this.txbKd.Name = "txbKd";
            this.txbKd.Size = new System.Drawing.Size(50, 20);
            this.txbKd.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Kp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ki";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "DC Motor PID Control";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Motor Speed Plot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(640, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // chartSpeed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(12, 218);
            this.chartSpeed.Name = "chartSpeed";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Speed";
            this.chartSpeed.Series.Add(series1);
            this.chartSpeed.Size = new System.Drawing.Size(637, 294);
            this.chartSpeed.TabIndex = 26;
            this.chartSpeed.Text = "Motor Speed";
            // 
            // labCurrentV
            // 
            this.labCurrentV.AutoSize = true;
            this.labCurrentV.Location = new System.Drawing.Point(270, 202);
            this.labCurrentV.Name = "labCurrentV";
            this.labCurrentV.Size = new System.Drawing.Size(105, 13);
            this.labCurrentV.TabIndex = 27;
            this.labCurrentV.Text = "Current Speed: 0000";
            // 
            // labMyComd
            // 
            this.labMyComd.AutoSize = true;
            this.labMyComd.Location = new System.Drawing.Point(284, 157);
            this.labMyComd.Name = "labMyComd";
            this.labMyComd.Size = new System.Drawing.Size(67, 13);
            this.labMyComd.TabIndex = 28;
            this.labMyComd.Text = "Sending: xxx";
            // 
            // SerialCommTest02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 519);
            this.Controls.Add(this.labMyComd);
            this.Controls.Add(this.labCurrentV);
            this.Controls.Add(this.chartSpeed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbKd);
            this.Controls.Add(this.txbKi);
            this.Controls.Add(this.txbKp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMstart);
            this.Controls.Add(this.btnMstop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.cmbScanPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSpeed);
            this.Controls.Add(this.btnScanPort);
            this.Controls.Add(this.btnDiscon);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialCommTest02";
            this.Text = "Serial Communication Send and Receive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialCommTest02_FormClosing);
            this.Load += new System.EventHandler(this.SerialCommTest02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSpeed;
        private System.Windows.Forms.ComboBox cmbScanPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMstop;
        private System.Windows.Forms.Button btnMstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbKp;
        private System.Windows.Forms.TextBox txbKi;
        private System.Windows.Forms.TextBox txbKd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.Label labCurrentV;
        private System.Windows.Forms.Label labMyComd;
    }
}

