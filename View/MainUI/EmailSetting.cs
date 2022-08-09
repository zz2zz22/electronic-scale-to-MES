using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace ElectronicScale2MES
{
    public partial class EmailSetting : Form
    {
        static System.Timers.Timer timer;
        
        public EmailSetting()
        {
            InitializeComponent();
        }
        public static void schedule_Timer()
        {
            DateTime nowTime = DateTime.Now;
            DateTime scheduledTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 11, 16, 0, 0); //Specify your scheduled time HH,MM,SS
            //DataReport.addReport(DataReport.RP_TYPE.Fail, DateTime.Now.ToShortTimeString(), "", "", "", "", "", "", "", "", "");
            if (nowTime > scheduledTime)
            { 
                scheduledTime = scheduledTime.AddDays(1);
            }

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            
            timer = new System.Timers.Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
            Properties.Settings.Default.excelFileName = "Report_" + DateTime.Now.ToString("yyyy-MM-dd") + ".xlsx";
            Properties.Settings.Default.Save();
        }
        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            DataReport.SaveExcel("", Properties.Settings.Default.excelFileName, Properties.Settings.Default.sender, Properties.Settings.Default.senderPwd);
            schedule_Timer();
        }

        private void btn_changeSender_Click(object sender, EventArgs e)
        {
            if (btn_changeSender.Text == "CHANGE")
            {
                ConfirmPwdMessageBox pwdMessageBox = new ConfirmPwdMessageBox();
                pwdMessageBox.ShowDialog();
                if (ConfirmPwdMessageBox.isAdmin == true)
                {

                    txb_sender.Enabled = true;
                    txb_senderPwd.Enabled = true;
                    btn_changeSender.Text = "SAVE";
                }
            }
            else
            {
                Properties.Settings.Default.sender = txb_sender.Text;
                Properties.Settings.Default.senderPwd = txb_senderPwd.Text;
                Properties.Settings.Default.Save();
                btn_changeSender.Text = "CHANGE";
                MessageBox.Show("Successfully save sender info!");
            }
        }

        private void EmailSetting_Load(object sender, EventArgs e)
        {
            txb_sender.Text = Properties.Settings.Default.sender;
            txb_senderPwd.Text = Properties.Settings.Default.senderPwd;
            LoadReceiverGrid();
        }

        public void LoadReceiverGrid()
        {
            if (Properties.Settings.Default.receivers == "")
            {
                Properties.Settings.Default.receivers = null;
            }
            this.dtgv_receivers.Rows.Clear();
            this.dtgv_receivers.Columns.Clear();
            string[] receivers;
            if (Properties.Settings.Default.receivers != null)
            {
                receivers = Properties.Settings.Default.receivers.Split('-');
            }
            else
            {
                receivers = null;
            }
            dtgv_receivers.RowHeadersVisible = false;
            dtgv_receivers.ColumnHeadersVisible = false;
            dtgv_receivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgv_receivers.Columns.Add("receiver", "Receivers");
            if (receivers != null)
            {
                for (int i = 0; i < receivers.Length; i++)
                {
                    this.dtgv_receivers.Rows.Add(receivers[i]);
                }
            }
            this.dtgv_receivers.Sort(this.dtgv_receivers.Columns["receiver"], ListSortDirection.Ascending);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.receivers != null && Properties.Settings.Default.receivers.Contains(txb_addReceiver.Text))
            {
                if (txb_addReceiver.Text == "")
                {
                    MessageBox.Show("Receiver address is empty! Please input a value before press save!");
                }
                else
                {
                    MessageBox.Show("Receiver '" + txb_addReceiver.Text + "' have existed!");
                }
                txb_addReceiver.Clear();
                
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Do you want to add '" + txb_addReceiver.Text + "' to list of receivers ?", "Confirmation", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    if (txb_addReceiver.Text != null)
                    {
                        if (Properties.Settings.Default.receivers == null)
                        {
                            Properties.Settings.Default.receivers += txb_addReceiver.Text;
                            Properties.Settings.Default.Save();
                        }
                        else if (Properties.Settings.Default.receivers != null)
                        {
                            Properties.Settings.Default.receivers += "-" + txb_addReceiver.Text;
                            Properties.Settings.Default.Save();
                        }
                        LoadReceiverGrid();
                        txb_addReceiver.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please in put receiver email address !");
                    }
                }
                
            }
        }

        private void dtgv_receivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_receivers.Rows[e.RowIndex];

                txb_addReceiver.Text = row.Cells[0].Value.ToString();
                Properties.Settings.Default.selectedReceiver = txb_addReceiver.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txb_addReceiver.Text == "")
            {
                MessageBox.Show("Please select receiver need to delete !");
            }
            else
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Delete '" + txb_addReceiver.Text + "' from receivers list ?", "Delete receiver confirmation", MessageBoxButtons.OKCancel);
                
                if (dialogResult == DialogResult.OK)
                {
                    string remainReceiver = Properties.Settings.Default.receivers;
                    string[] receivers = Properties.Settings.Default.receivers.Split('-');
                    if (receivers[0] == Properties.Settings.Default.selectedReceiver)
                    {
                        if (remainReceiver == Properties.Settings.Default.selectedReceiver)
                        {
                            Properties.Settings.Default.receivers = remainReceiver.Replace(Properties.Settings.Default.selectedReceiver, null);
                        }
                        else
                        {
                            Properties.Settings.Default.receivers = remainReceiver.Replace(Properties.Settings.Default.selectedReceiver + "-", null);
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.receivers = remainReceiver.Replace("-" + Properties.Settings.Default.selectedReceiver, null);
                    }
                    MessageBox.Show("Xóa thành công " + Properties.Settings.Default.selectedReceiver + " khỏi danh sách người nhận!");
                    Properties.Settings.Default.Save();
                    LoadReceiverGrid();
                }
                txb_addReceiver.Clear();
                txb_addReceiver.Clear();
            }
        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_search.Text))
            {
                this.dtgv_receivers.Rows.Clear();
                this.dtgv_receivers.Columns.Clear();
                dtgv_receivers.RowHeadersVisible = false;
                dtgv_receivers.ColumnHeadersVisible = false;
                dtgv_receivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgv_receivers.Columns.Add("receiver", "Receivers");
                string receiverSearch = "";
                string[] receivers;
                if (Properties.Settings.Default.receivers != null)
                {
                    receivers = Properties.Settings.Default.receivers.Split('-');
                }
                else
                {
                    receivers = null;
                }

                for (int i = 0; i < receivers.Length; i++)
                {
                    if (receivers[i].Contains(txb_search.Text))
                    {
                        if (receiverSearch == "")
                        {
                            receiverSearch += receivers[i];
                        }
                        else
                        {
                            receiverSearch += "-" + receivers[i];
                        }

                    }
                }
                string[] receiverSearchList = receiverSearch.Split('-');
                if (receiverSearchList != null)
                {
                    for (int j = 0; j < receiverSearchList.Length; j++)
                    {
                        this.dtgv_receivers.Rows.Add(receiverSearchList[j]);
                    }
                }

            }
            else
            {
                LoadReceiverGrid();
            }
        }
    }
}
