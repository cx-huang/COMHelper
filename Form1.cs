using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // for SerialPort class

namespace COMHelperV1
{
    public partial class Form1 : Form
    {
        int transmitCount = 0;
        int receiveCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // search port name
            SearchPort(cbPortName);
            // add baudrate items
            cbBaudrate.Items.Add(4800);
            cbBaudrate.Items.Add(9600);
            cbBaudrate.Items.Add(19200);
            cbBaudrate.Items.Add(38400);
            cbBaudrate.Items.Add(115200);
            // add parity items
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                cbParity.Items.Add(s);
            }
            // add data bits items
            cbDataBits.Items.Add(7);
            cbDataBits.Items.Add(8);
            // add stop bits items
            cbStopBits.Items.Add("NONE");
            cbStopBits.Items.Add(1);
            cbStopBits.Items.Add(1.5);
            cbStopBits.Items.Add(2);

            // default settings
            cbBaudrate.SelectedIndex = 1;   //9600
            cbParity.SelectedIndex = 0;     //NONE
            cbDataBits.SelectedIndex = 1;   //8
            cbStopBits.SelectedIndex = 1;   //1

        }

        private void SearchPort(ComboBox box)
        {
            cbPortName.Items.Clear();
            string buffer;
            for (int i = 1; i < 20; i++) //Q:why a loop?
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    SerialPort port = new SerialPort(buffer, 9600, Parity.None, 8, StopBits.One);
                    port.Open();
                    if (port.IsOpen)
                        box.Items.Add(buffer);
                    port.Close();
                }
                catch (Exception e)
                {

                }
            }
        }

        private void bCOMOnOff_Click(object sender, EventArgs e)
        {
            if (cbPortName.SelectedIndex == -1)
                lPortName.ForeColor = Color.Red;
            else
            {
                if (bCOMOnOff.Text == "Open")
                {
                    lPortName.ForeColor = Color.Black;
                    serialPort.PortName = cbPortName.Text.ToString();
                    serialPort.BaudRate = int.Parse(cbBaudrate.Text.ToString());
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.SelectedItem.ToString());
                    serialPort.DataBits = int.Parse(cbDataBits.SelectedItem.ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.SelectedItem.ToString());
                    try
                    {
                        serialPort.Open();
                        if (serialPort.IsOpen)
                        {
                            bCOMOnOff.ForeColor = Color.Red;
                            bCOMOnOff.Text = "Close";
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                    serialPort.Close();
                    if (!serialPort.IsOpen)
                    {
                        bCOMOnOff.ForeColor = Color.Black;
                        bCOMOnOff.Text = "Open";
                    }
                }
            }
        }

        private void bReceiveClear_Click(object sender, EventArgs e)
        {
            tbReceiveTextBox.Text = "";
        }

        private void bTransmitClear_Click(object sender, EventArgs e)
        {
            tbTransmitTextBox.Text = "";
        }

        private void bResetCount_Click(object sender, EventArgs e)
        {
            lTransmitCount.Text = "0";
            lReceiveCount.Text = "0";
            transmitCount = 0;
            receiveCount = 0;
        }

        private void bTransmit_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                TransmitData(tbTransmitTextBox.Text);
            else
                lPortName.ForeColor = Color.Red;
        }

        private void TransmitData(string data)
        {
            bool isCircular = false;
            if (chbCircularTransmit.CheckState == CheckState.Checked)
                isCircular = true;
            do
            {
                if (chbTransmitAsHEX.CheckState == CheckState.Checked)
                {

                }
                else
                {
                    char[] transmitBuffer = data.ToCharArray();
                    int dataLength = transmitBuffer.Length;
                    transmitCount += dataLength;
                    lTransmitCount.Text = transmitCount.ToString();
                    serialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                    serialPort.Write(transmitBuffer, 0, dataLength);
                }
                //TODO:delay tbInterval.Text ms
            } while (isCircular);   //Q: Does a loop here occupy the whole process? A: Yes.
        }

        private void ReceiveData()
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            //TODO
        }
    }
}
