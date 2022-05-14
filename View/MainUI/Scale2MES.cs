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
        double tempWeight = 0;
        double totalWeight = 0;
        string tempWorkOrderUUID = "";
        public Scale2MES()
        {
            InitializeComponent();
            //txb_searchData.Text = UUIDGenerator.getAscId();  
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
                if (dataIn != null)
                {
                    tempWeight = totalWeight;
                    totalWeight = totalWeight + double.Parse(dataIn);
                    lb_totalWeight.Text = totalWeight.ToString();
                    SaveVariables.scaleTotalQty = totalWeight;
                }
                else
                {
                    MessageBox.Show("Error when connect to Scale. Please reconnect and try again!");
                }
            }
            else if (cxb_updateTotalWeight.Checked)
            {
                if (dataIn != null)
                {
                    lb_dataIn.Text = dataIn;
                    lb_totalWeight.Text = dataIn;
                    totalWeight = double.Parse(dataIn);
                    SaveVariables.scaleTotalQty = double.Parse(dataIn);
                }
                else
                {
                    MessageBox.Show("Error when connect to Scale. Please reconnect and try again!");
                }
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

            dtgv_mesData.DataSource = GetBaseData.getWorkOrderDTtoDataGrid();
            dtgv_mesData.Columns["UUID"].Visible = false;
            DataTable dt = new DataTable();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            StringBuilder sqlSelectEmployee = new StringBuilder();
            sqlSelectEmployee.Append("SELECT UUID AS EmpUID, CONCAT(CODE,' - ' ,NAME) AS EmpCodeName ");
            sqlSelectEmployee.Append("FROM mes_base_data.employee_info WHERE employee_info.uuid ");
            sqlSelectEmployee.Append("IN(SELECT DISTINCT group_employee.employee_uuid FROM mes_base_data.group_employee ");
            sqlSelectEmployee.Append("WHERE group_employee.group_uuid = '44Z7XSMACV41' AND group_employee.delete_flag = '0') AND employee_info.delete_flag = '0'");
            sqlMesBaseData.sqlDataAdapterFillDatatable(sqlSelectEmployee.ToString(), ref dt);
            this.cbx_employeeInfo.DataSource = dt;
            this.cbx_employeeInfo.DisplayMember = "EmpCodeName";
            this.cbx_employeeInfo.ValueMember = "EmpUID";
        }

        private void btn_portRefresh_Click(object sender, EventArgs e)
        {
            cbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }

        private void btn_searchDatatable_Click(object sender, EventArgs e)
        {
            DataRow[] results = GetBaseData.getWorkOrderDTtoDataGrid().Select("ERP_Code like '%" + txb_searchErpCode.Text.Trim() + "%' AND Product_Code like '%" + txb_searchProdCode.Text.Trim() + "%' AND Material_Code like '%" + txb_searchMatCode.Text.Trim() + "%'");
            if (results.Length > 0)
            {
                DataTable searchResultTable = results.CopyToDataTable();
                dtgv_mesData.DataSource = null;
                dtgv_mesData.DataSource = searchResultTable;
                dtgv_mesData.Columns["UUID"].Visible = false;
            }
            else
            {
                MessageBox.Show("No result!");
            }
        }

        private void dtgv_mesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv_mesData.Rows[e.RowIndex];
                lb_erpCodeInfo.Text = row.Cells[0].Value.ToString();
                SaveVariables.erpCode = lb_erpCodeInfo.Text;
                lb_prodCodeInfo.Text = row.Cells[1].Value.ToString();
                SaveVariables.productCode = lb_prodCodeInfo.Text;
                lb_matCodeInfo.Text = row.Cells[2].Value.ToString();
                SaveVariables.materialCode = lb_matCodeInfo.Text;
                lb_planQtyInfo.Text = row.Cells[3].Value.ToString();
                lb_dispatchQtyInfo.Text = row.Cells[4].Value.ToString();
                if (lb_dispatchQtyInfo.Text != null)
                {
                    SaveVariables.dispatchQty = double.Parse(lb_dispatchQtyInfo.Text);
                }
                lb_finishQtyInfo.Text = row.Cells[5].Value.ToString();
                if (lb_finishQtyInfo.Text != null)
                {
                    SaveVariables.finishQty = double.Parse(lb_finishQtyInfo.Text);
                }
                tempWorkOrderUUID = row.Cells[7].Value.ToString();
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

        private void btn_resetTotalWeight_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reset total weight to 0?", "Reset confirmation", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                lb_totalWeight.Text = "00.00";
                totalWeight = 0;
                SaveVariables.scaleTotalQty = totalWeight;
                tempWeight = 0;
            }
        }

        private void btn_resetSearch_Click(object sender, EventArgs e)
        {
            dtgv_mesData.DataSource = null;
            dtgv_mesData.DataSource = GetBaseData.getWorkOrderDTtoDataGrid();
            dtgv_mesData.Columns["UUID"].Visible = false;
            txb_searchErpCode.Text = "";
            txb_searchMatCode.Text = "";
            txb_searchProdCode.Text = "";
        }

        private void btn_save2MES_Click(object sender, EventArgs e)
        {
            if (totalWeight + SaveVariables.finishQty > SaveVariables.dispatchQty)
            {
                MessageBox.Show("The total quantity is exceed over the dispatch quantity!", "Alert");
            }
            else
            {
                if (tempWorkOrderUUID != "")
                {
                    SaveVariables.workOrderUUID = tempWorkOrderUUID;
                }
                if (SaveVariables.workOrderUUID != null)
                {
                    string btnClicked = SaveMESMessageBox.ShowBox();
                    if (btnClicked == "1")
                    {
                        //Run Upload logic here
                    }
                }
                else
                {
                    if (SaveVariables.scaleTotalQty == 0)
                    {
                        MessageBox.Show("Invalid input value!", "Alert");
                    }
                    else
                    {
                        MessageBox.Show("Please choose an order to proceed!", "Alert");
                    }
                }
            }
        }

        private void Scale2MES_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveVariables.ResetVariables();
        }

        private void btn_addNGQty_Click(object sender, EventArgs e)
        {

        }
    }
}
