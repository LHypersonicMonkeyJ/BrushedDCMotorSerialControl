using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Threading;

namespace SerialCommTest02_Cs
{
    public partial class SerialCommTest02 : Form
    {
        private string myStr;
        private string output;
        private string speed;
        int i;

        public SerialCommTest02()
        {
            InitializeComponent();
        }

        private void SerialCommTest02_Load(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnCon.BringToFront();

            btnDiscon.Enabled = false;
            btnDiscon.SendToBack();

            btnMstart.Enabled = false;
            btnMstop.Enabled = false;
            btnSend.Enabled = false;

            cmbBaud.SelectedItem = "9600";
            DoubleBuffered = true;
            myStr = "0";
            i = 300;
        }

        private void btnScanPort_Click(object sender, EventArgs e)
        {
            cmbScanPort.Items.Clear();
            string[] myPort = SerialPort.GetPortNames();
            cmbScanPort.Items.AddRange(myPort);
            int i = cmbScanPort.Items.Count;
            i -= 1;
            try
            {
                cmbScanPort.SelectedIndex = i;
            }
            catch (Exception)
            {
                MessageBox.Show("Com port not detected!", "Serial Communication", MessageBoxButtons.OK);
            }
            btnCon.Enabled = true;
            btnCon.BringToFront();
            cmbScanPort.DroppedDown = true;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnCon.SendToBack();

            mySerialPort.BaudRate = Convert.ToInt32(cmbBaud.SelectedItem);
            mySerialPort.PortName = (string)cmbScanPort.SelectedItem;
            mySerialPort.Open();
            timer1.Start();

            btnDiscon.Enabled = true;
            btnDiscon.BringToFront();

            btnSend.Enabled = true;
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            btnDiscon.Enabled = false;
            btnDiscon.SendToBack();

            mySerialPort.Close();
            timer1.Stop();
            btnCon.Enabled = true;
            btnCon.BringToFront();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("vs_set_speed" + txbSpeed.Text);
            mySerialPort.WriteLine("vs_kp" + txbKp.Text);
            mySerialPort.WriteLine("vs_ki" + txbKi.Text);
            mySerialPort.WriteLine("vs_kd" + txbKd.Text);

            btnMstart.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string length;
            length = myStr.Length.ToString();
            if (myStr.Length > 5)
            {
                if (myStr.Substring(0, 5) == "speed")
                {
                    speed = myStr.Substring(5, Int32.Parse(length) - 6);
                    labCurrentV.Text = "Current Speed: " + speed;
                    //print motor speed into chart
                    this.chartSpeed.Series["Speed"].Points.AddXY(i, double.Parse(speed));
                    i++;
                    this.chartSpeed.ChartAreas["ChartArea1"].AxisX.Minimum = i - 300;
                }
            }
            
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            myStr = mySerialPort.ReadLine();
        }

        private void btnMstart_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("vs_start");         //start motor
            output = mySerialPort.ToString();

            btnMstop.Enabled = true;
            btnMstart.Enabled = false;
        }

        private void btnMstop_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("vs_stop");          //stop motor

            btnMstart.Enabled = true;
        }
    }
}
