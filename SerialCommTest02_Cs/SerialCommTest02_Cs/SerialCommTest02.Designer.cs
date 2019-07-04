namespace SerialCommTest02_Cs
{
    partial class SerialCommTest02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialCommTest02));
            this.btnScanPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.cmbScanPort = new System.Windows.Forms.ComboBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labTextRec = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDiscon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScanPort
            // 
            this.btnScanPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanPort.Location = new System.Drawing.Point(39, 39);
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
            this.label1.Location = new System.Drawing.Point(326, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(123, 134);
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(100, 20);
            this.txbContent.TabIndex = 1;
            // 
            // cmbScanPort
            // 
            this.cmbScanPort.FormattingEnabled = true;
            this.cmbScanPort.Location = new System.Drawing.Point(123, 40);
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
            this.cmbBaud.Location = new System.Drawing.Point(393, 40);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 21);
            this.cmbBaud.TabIndex = 4;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(39, 68);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(39, 132);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labTextRec
            // 
            this.labTextRec.AutoSize = true;
            this.labTextRec.Location = new System.Drawing.Point(326, 137);
            this.labTextRec.Name = "labTextRec";
            this.labTextRec.Size = new System.Drawing.Size(77, 13);
            this.labTextRec.TabIndex = 7;
            this.labTextRec.Text = "Text Received";
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
            this.btnDiscon.Location = new System.Drawing.Point(39, 68);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(75, 23);
            this.btnDiscon.TabIndex = 8;
            this.btnDiscon.Text = "Disconnect";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // SerialCommTest02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 184);
            this.Controls.Add(this.labTextRec);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.cmbScanPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.btnScanPort);
            this.Controls.Add(this.btnDiscon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialCommTest02";
            this.Text = "Serial Communication Send and Receive";
            this.Load += new System.EventHandler(this.SerialCommTest02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.ComboBox cmbScanPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labTextRec;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDiscon;
    }
}

