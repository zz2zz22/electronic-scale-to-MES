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
using MySqlConnector;
using System.Data.SqlClient;

namespace ElectronicScale2MES
{
    public partial class Scale2MES : Form
    {
        string dataIn;
        int tempWeight = 0;
        int totalWeight = 0;
        int tempNG = 0;
        int totalNG = 0;
        string tempWorkOrderUUID = "";
        public Scale2MES()
        {
            InitializeComponent();
        }

        //Sub component
        static void uploadWithTransactionSupport(string cmd1, string cmd2, string cmd3, string cmd4, string cmd5, string cmd6, string cmd7, string cmd8)
        {
            if (Properties.Settings.Default.conType == 1)
            {
                SqlConnection conn1 = DatabaseUtils.GetCustomMesPlanningExcutionCon();
                SqlConnection conn2 = DatabaseUtils.GetCustomMesBaseData();
                SqlConnection conn3 = DatabaseUtils.GetCustomMesQualityControlCon();
                SqlTransaction trans1 = null;
                SqlTransaction trans2 = null;
                SqlTransaction trans3 = null;
                SqlCommand cmdMS1 = new SqlCommand();
                SqlCommand cmdMS2 = new SqlCommand();
                SqlCommand cmdMS3 = new SqlCommand();
                try
                {
                    conn1.Open();
                    conn2.Open();
                    conn3.Open();
                    trans1 = conn1.BeginTransaction();
                    trans2 = conn2.BeginTransaction();
                    trans3 = conn3.BeginTransaction();
                    cmdMS1.Transaction = trans1;
                    cmdMS2.Transaction = trans2;
                    cmdMS3.Transaction = trans3;
                    cmdMS1.Connection = conn1;
                    cmdMS2.Connection = conn2;
                    cmdMS3.Connection = conn3;
                    //Insert and update Mes_planning_excution commands execute
                    cmdMS1.CommandText = cmd1;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd2;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd3;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd4;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd5;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd6;
                    cmdMS1.ExecuteNonQuery();
                    //Insert and update mes_base_data commands execute
                    cmdMS2.CommandText = cmd7;
                    cmdMS2.ExecuteNonQuery();
                    //Insert and update mes_quality_control commands execute
                    cmdMS3.CommandText = cmd8;
                    cmdMS3.ExecuteNonQuery();

                    trans1.Commit();
                    trans2.Commit();
                    trans3.Commit();
                    MessageBox.Show("Successfully add and update data to MES!", "Complete!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nFail to add and update data to MES!", "Error");
                    trans1.Rollback();
                    trans2.Rollback();
                    trans3.Rollback();
                }
            }
            else if (Properties.Settings.Default.conType == 0)
            {
                MySqlConnection conn1 = DatabaseUtils.GetCustom2MesPlanningExcutionCon();
                MySqlConnection conn2 = DatabaseUtils.GetCustom2MesBaseDataCon();
                MySqlConnection conn3 = DatabaseUtils.GetCustom2MesQualityControlCon();
                MySqlTransaction trans1 = null;
                MySqlTransaction trans2 = null;
                MySqlTransaction trans3 = null;
                MySqlCommand cmdMS1 = new MySqlCommand();
                MySqlCommand cmdMS2 = new MySqlCommand();
                MySqlCommand cmdMS3 = new MySqlCommand();
                try
                {
                    conn1.Open();
                    conn2.Open();
                    conn3.Open();
                    trans1 = conn1.BeginTransaction();
                    trans2 = conn2.BeginTransaction();
                    trans3 = conn3.BeginTransaction();
                    cmdMS1.Transaction = trans1;
                    cmdMS2.Transaction = trans2;
                    cmdMS3.Transaction = trans3;
                    cmdMS1.Connection = conn1;
                    cmdMS2.Connection = conn2;
                    cmdMS3.Connection = conn3;
                    //Insert and update Mes_planning_excution commands execute
                    cmdMS1.CommandText = cmd1;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd2;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd3;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd4;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd5;
                    cmdMS1.ExecuteNonQuery();
                    cmdMS1.CommandText = cmd6;
                    cmdMS1.ExecuteNonQuery();
                    //Insert and update mes_base_data commands execute
                    cmdMS2.CommandText = cmd7;
                    cmdMS2.ExecuteNonQuery();
                    //Insert and update mes_quality_control commands execute
                    cmdMS3.CommandText = cmd8;
                    cmdMS3.ExecuteNonQuery();

                    trans1.Commit();
                    trans2.Commit();
                    trans3.Commit();
                    MessageBox.Show("Successfully add and update data to MES!", "Complete!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nFail to add and update data to MES!", "Error");
                    trans1.Rollback();
                    trans2.Rollback();
                    trans3.Rollback();
                }
            }
        }

        private void showData(object sender, EventArgs e)
        {
            if (SaveVariables.isAddNG == false)
            {
                if (cxb_stackWeight.Checked)
                {
                    if (dataIn != null)
                    {
                        tempWeight = totalWeight;
                        totalWeight = totalWeight + int.Parse(dataIn);
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
                        lb_totalWeight.Text = dataIn;
                        totalWeight = int.Parse(dataIn);
                        SaveVariables.scaleTotalQty = int.Parse(dataIn);
                    }
                    else
                    {
                        MessageBox.Show("Error when connect to Scale. Please reconnect and try again!");
                    }
                }
            }
            else
            {
                if (dataIn != null)
                {
                    tempNG = totalNG;
                    totalNG = totalNG + int.Parse(dataIn);
                    lb_dataNG.Text = totalNG.ToString();
                    SaveVariables.notGoodQty = totalNG;
                }
                else
                {
                    MessageBox.Show("Error when connect to Scale. Please reconnect and try again!");
                }
            }

        }

        //Event arguments
        #region EventArgs
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting().Trim().Replace("kg","");
            dataIn = dataIn.Replace(".", ",");
            this.Invoke(new EventHandler(showData));
        }

        private void Scale2MES_Load(object sender, EventArgs e)
        {
            if (SaveVariables.portName != null)
            {
                try
                {
                    serialPort1.PortName = SaveVariables.portName;
                    serialPort1.BaudRate = SaveVariables.baudRate;
                    serialPort1.DataBits = SaveVariables.dataBits;
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), SaveVariables.stopBits);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), SaveVariables.parityBits);
                    serialPort1.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    ScaleConnect scaleConnect = new ScaleConnect();
                    scaleConnect.ShowDialog();
                }
                SaveVariables.ResetVariables();
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
            else
            {
                MessageBox.Show("Please connect to Scale first!");
                this.Close();
                ScaleConnect scaleConnect = new ScaleConnect();
                scaleConnect.ShowDialog();
            }

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
            if (e.RowIndex >= 0) //Save variables to confirm chosing 
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
                    SaveVariables.dispatchQty = int.Parse(lb_dispatchQtyInfo.Text);
                }
                lb_finishQtyInfo.Text = row.Cells[5].Value.ToString();
                if (lb_finishQtyInfo.Text != null)
                {
                    SaveVariables.finishQty = int.Parse(lb_finishQtyInfo.Text);
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
                    SaveVariables.passQty = SaveVariables.scaleTotalQty - SaveVariables.notGoodQty; 
                    string btnClicked = SaveMESMessageBox.ShowBox();
                    if (btnClicked == "1")
                    {
                        //Upload logics
                        string cmd1 = UploadLogic.insertScale2JobMove(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty, SaveVariables.passQty);
                        string cmd2 = UploadLogic.insert2JobOrderRecord(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty, SaveVariables.passQty, SaveVariables.notGoodQty);
                        string cmd3 = UploadLogic.insert2WorkOrderLots(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty);
                        string cmd4 = UploadLogic.updateJobOrder(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty, SaveVariables.passQty, SaveVariables.notGoodQty);
                        string cmd5 = UploadLogic.updateWorkOrder(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty, SaveVariables.passQty, SaveVariables.notGoodQty);
                        string cmd6 = UploadLogic.updateWorkOrderProcess(SaveVariables.workOrderUUID, SaveVariables.employeeUUID, SaveVariables.scaleTotalQty, SaveVariables.passQty);
                        string cmd7;
                        if ( SaveVariables.isEmptyAutoCode == true)
                        {
                            cmd7 = UploadLogic.insertAutoCodeHis(SaveVariables.workOrderUUID, SaveVariables.employeeUUID);
                        }
                        else
                        {
                            cmd7 = UploadLogic.updateAutoCodeHis(SaveVariables.workOrderUUID, SaveVariables.employeeUUID);
                        }
                        string cmd8 = UploadLogic.insertQualityControlOrder(SaveVariables.workOrderUUID, SaveVariables.employeeUUID);

                        uploadWithTransactionSupport(cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8); //Upload logic go through here
                        SaveVariables.ResetVariables();
                        SaveVariables.ResetEmployee();
                        tempWeight = 0;
                        totalWeight = 0;
                        tempNG = 0;
                        totalNG = 0;
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
            if (SaveVariables.isAddNG == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you sure to add Not good quantity to this order ?", "Confirmation", MessageBoxButtons.OKCancel);
                {
                    if (dialogResult == DialogResult.OK)
                    {
                        SaveVariables.isAddNG = true;
                        btn_addNGQty.Text = "DONE";
                        btn_addNGQty.BackColor = Color.Yellow;
                        btn_ngReset.Enabled = true;
                        btn_ngUndo.Enabled = true;
                    }
                }
            }
            else
            {
                SaveVariables.isAddNG = false;
                btn_addNGQty.Text = "ADD NOT GOOD QUANTITY";
                btn_addNGQty.BackColor = DefaultBackColor;
                btn_ngReset.Enabled = false;
                btn_ngUndo.Enabled = false;
            }
        }

        private void cbx_employeeInfo_SelectedValueChanged(object sender, EventArgs e)
        {
            SaveVariables.employeeUUID = cbx_employeeInfo.SelectedValue.ToString();
        }

        private void btn_undoWeightAdding_Click(object sender, EventArgs e)
        {
            if (totalWeight != 0)
            {
                lb_totalWeight.Text = tempWeight.ToString();
                SaveVariables.scaleTotalQty = tempWeight;
            }
        }

        private void btn_ngUndo_Click(object sender, EventArgs e)
        {
            if (totalNG != 0)
            {
                lb_dataNG.Text = tempNG.ToString();
                SaveVariables.notGoodQty = tempNG;
            }
        }

        private void btn_ngReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reset NG weight to 0?", "Reset confirmation", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                lb_dataNG.Text = "00.00";
                totalNG = 0;
                SaveVariables.notGoodQty = totalNG;
            }
        }
        #endregion

        
    }
}
