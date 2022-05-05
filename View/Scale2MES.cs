using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicScale2MES
{
    public partial class Scale2MES : Form
    {
        string dataIn;
        public Scale2MES()
        {
            InitializeComponent();
            txb_searchData.Text = UUIDGenerator.getAscId();
            dtgv_mesData.DataSource = GetBaseData.getWorkOrderDTtoDataGrid();
        }

        public DataTable GetDataFromMatsCode(string matsCode)
        {
            DataTable loadInDT = new DataTable();

            return loadInDT;
        }
        private DataTable loadWOtoDT()
        {
            DataTable dt = new DataTable();

            return dt;
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort1.IsOpen)
            {

                Properties.Settings.Default.ScaleStatus = true;
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
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Properties.Settings.Default.ScaleStatus = false;
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting().Trim().Replace("kg","");
            this.Invoke(new EventHandler(showData));
        }
        private void showData(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                lb_dataIn.Text = dataIn;
                lb_dataIn.ForeColor = Color.White;
                
            }
            else if (chBoxAddToOldData.Checked)
            {
                lb_dataIn.Text += dataIn + "\n";

            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
            }
            else
            {
                chBoxAddToOldData.Checked = true;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked = true;
            }
        }

        private void Scale2MES_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);

            btOpen.Enabled = true;
            btClose.Enabled = false;
            serialPort1.DtrEnable = false;
            serialPort1.RtsEnable = false;

            chBoxAlwaysUpdate.Checked = false;
            chBoxAddToOldData.Checked = true;

            cbComPort.Enabled = true;
        }

        private void btn_portRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }
    }
}
