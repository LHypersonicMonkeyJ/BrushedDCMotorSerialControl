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
        String myStr;
        public SerialCommTest02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SerialCommTest02_Load(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnCon.BringToFront();

            btnDiscon.Enabled = false;
            btnDiscon.SendToBack();

            cmbBaud.SelectedItem = "9600";
            DoubleBuffered = true;
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
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            btnDiscon.Enabled = false;
            btnDiscon.SendToBack();

            mySerialPort.Close();
            btnCon.Enabled = true;
            btnCon.BringToFront();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine(txbContent.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTextRec.Text = myStr;
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            myStr = mySerialPort.ReadLine();
        }
    }
}
