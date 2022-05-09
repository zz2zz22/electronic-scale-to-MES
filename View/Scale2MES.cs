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
        double tempWeight;
        double totalWeight = 0;
        public Scale2MES()
        {
            InitializeComponent();
            //txb_searchData.Text = UUIDGenerator.getAscId();
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
            if (cxb_stackWeight.Checked)
            {
                lb_dataIn.Text = dataIn;
                tempWeight = totalWeight;
                totalWeight = totalWeight + double.Parse(dataIn);
                lb_totalWeight.Text = totalWeight.ToString();
            }
            else if (cxb_updateTotalWeight.Checked)
            {
                lb_dataIn.Text = dataIn;
                lb_totalWeight.Text = dataIn;
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

            cbComPort.Enabled = true;
        }

        private void btn_portRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }

        private void btn_searchDatatable_Click(object sender, EventArgs e)
        {
            DataRow[] results = GetBaseData.getWorkOrderDTtoDataGrid().Select("ERP_Code like '%" + txb_searchErpCode.Text.Trim() + "%' AND Product_Code like '%" + txb_searchProdCode.Text.Trim() + "%' ");
            if (results.Length > 0)
            {
                DataTable searchResultTable = results.CopyToDataTable();
                dtgv_mesData.DataSource = null;
                dtgv_mesData.DataSource = searchResultTable;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào!");
            }
        }

        private void dtgv_mesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv_mesData.Rows[e.RowIndex];
                lb_erpCodeInfo.Text = row.Cells[0].Value.ToString();
                lb_prodCodeInfo.Text = row.Cells[1].Value.ToString();
                lb_prodNameInfo.Text = row.Cells[2].Value.ToString();
            }
        }

        private void cxb_stackWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (cxb_stackWeight.Checked)
            {
                cxb_stackWeight.Checked = true;
                cxb_updateTotalWeight.Checked = false;
            }
            else
            {
                cxb_updateTotalWeight.Checked = true;
            }
        }

        private void cxb_updateTotalWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (cxb_updateTotalWeight.Checked)
            {
                cxb_updateTotalWeight.Checked = true;
                cxb_stackWeight.Checked = false;
            }
            else
            {
                cxb_stackWeight.Checked = true;
            }
        }
    }
}
