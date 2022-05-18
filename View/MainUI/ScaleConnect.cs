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

namespace ElectronicScale2MES
{ 
    public partial class ScaleConnect : Form
    {
        string dataIn;
        public ScaleConnect()
        {
            InitializeComponent();
        }
        private void showData(object sender, EventArgs e)
        {
            if (dataIn != null)
            {
                rtb_testConnection.Text = "Connect successful to scale!\n\nData format: " + dataIn;
            }
            else
            {
                rtb_testConnection.Text = "Error when connect to Scale. Please reconnect and try again!";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting().Trim().Replace("kg", "");
            this.Invoke(new EventHandler(showData));
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (SaveVariables.portName != null)
            {
                rtb_testConnection.Text = "Program is connected to " + SaveVariables.portName;
            }
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                if (serialPort1.IsOpen)
                {
                    if (btOpen.Enabled)
                    {
                        if (progressBar1.Value == 100)
                        {
                            btOpen.Enabled = false;
                            btClose.Enabled = true;
                        }
                        else
                        {
                            btOpen.Enabled = true;
                            btClose.Enabled = false;
                        }
                    }
                    else
                    {
                        btClose.Enabled = false;
                    }
                    cbComPort.Enabled = false;
                    SaveVariables.portName = cbComPort.Text;
                    SaveVariables.baudRate = Convert.ToInt32(cbBaudRate.Text);
                    SaveVariables.dataBits = Convert.ToInt32(cbDataBits.Text);
                    SaveVariables.stopBits = cbStopBits.Text;
                    SaveVariables.parityBits = cbParityBits.Text;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (SaveVariables.portName  == null)
            {
                rtb_testConnection.Text = "Please connect to a COM port first!";
            }
            else
            {
                SaveVariables.ResetScaleCon();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    progressBar1.Value = 0;
                }
                if (btClose.Enabled)
                {
                    btOpen.Enabled = true;
                    btClose.Enabled = false;
                }
                else
                {
                    btOpen.Enabled = false;
                }
                cbComPort.Enabled = true;
            }
        }

        private void btn_portRefresh_Click(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }

        private void ScaleConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveVariables.portName == null)
            {
                DialogResult dialogResult = MessageBox.Show("No scale connected. Do you want to exit ?", "Confirmation", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
