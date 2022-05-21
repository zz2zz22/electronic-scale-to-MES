using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;
using System.Threading;

namespace ElectronicScale2MES
{
    public partial class ChangeDatabase : Form
    {
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        public ChangeDatabase()
        {
            InitializeComponent();
        }

        private void ChangeDatabase_Load(object sender, EventArgs e)
        {
            txb_hostName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txb_hostName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //auto.Add(txb_hostName.Text);
            txb_hostName.AutoCompleteCustomSource = autoComplete;
            cbx_dbType.SelectedIndex = Properties.Settings.Default.conType;
            txb_hostName.Text = Properties.Settings.Default.conHost;
            if (Properties.Settings.Default.conType == 0)
            {
                lb_hostType.Visible = false;
                cbx_hostType.Visible = false;
            }
            else
            {
                lb_hostType.Visible = true;
                cbx_hostType.Visible = true;
                cbx_hostType.SelectedIndex = Properties.Settings.Default.conHostType;
                if (Properties.Settings.Default.conHostType == 0)
                {
                    txb_hostUsername.Enabled = true;
                    txb_hostPassword.Enabled = true;
                    txb_hostUsername.Text = Properties.Settings.Default.conUser;
                    txb_hostPassword.Text = Properties.Settings.Default.conPassword;
                }
                else
                {
                    txb_hostUsername.Enabled = false;
                    txb_hostPassword.Enabled = false;
                    txb_hostUsername.Text = "";
                    txb_hostPassword.Text = "";
                }
            }
        }

        private void cbx_dbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbx_dbType.SelectedIndex == 0)
            {
                lb_hostType.Visible = false;
                cbx_hostType.Visible = false;
                txb_hostUsername.Enabled = true;
                txb_hostPassword.Enabled = true;

                Properties.Settings.Default.conType = 0;
            }else if (cbx_dbType.SelectedIndex == 1)
            {
                cbx_hostType.SelectedIndex = 0;
                lb_hostType.Visible = true;
                cbx_hostType.Visible = true;
                cbx_hostType.SelectedIndex = Properties.Settings.Default.conHostType;
                Properties.Settings.Default.conType = 1;
            }
        }

        private void cbx_hostType_SelectedValueChanged(object sender, EventArgs e)
        {
            txb_hostUsername.Text = "";
            txb_hostPassword.Text = "";
            if (cbx_hostType.SelectedIndex == 0)
            {
                txb_hostUsername.Enabled = true;
                txb_hostPassword.Enabled = true;
                Properties.Settings.Default.conHostType = 0;
            }
            else
            {
                txb_hostUsername.Enabled = false;
                txb_hostPassword.Enabled = false;
                Properties.Settings.Default.conHostType = 1;
            }
        }

        public static void checkDB_Conn()
        {
            if (Properties.Settings.Default.conType == 0)
            {
                MySqlConnection mySQLCon = DatabaseUtils.Get_TestMySQLDB();
                mySQLCon.Open();
            }
            else
            {
                SqlConnection msSQLCon = DatabaseUtils.Get_TestMSSQLDB();
                msSQLCon.Open();
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            rtb_logShow.Clear();
            Thread.Sleep(1500);
            Properties.Settings.Default.conHost = txb_hostName.Text;
            Properties.Settings.Default.conUser = txb_hostUsername.Text;
            Properties.Settings.Default.conPassword = txb_hostPassword.Text;
            Properties.Settings.Default.Save();
            if (String.IsNullOrWhiteSpace(txb_hostName.Text))
            {
                rtb_logShow.Text = "Please input host name !";
            }
            else
            {
                try
                { 
                    checkDB_Conn();
                    rtb_logShow.Text = "Successfully connect to database!";
                    autoComplete.Add(txb_hostName.Text);
                }
                catch(Exception ex)
                {
                    rtb_logShow.Text = ex.Message;
                }
                
            }
        }
    }
}
