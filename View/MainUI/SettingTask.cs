using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicScale2MES
{
    public partial class SettingTask : Form
    {
        public SettingTask()
        {
            InitializeComponent();
        }

        private void xuibtn_changeDTB_Click(object sender, EventArgs e)
        {
            ConfirmPwdMessageBox pwdMessageBox = new ConfirmPwdMessageBox();
            pwdMessageBox.ShowDialog();
            if (ConfirmPwdMessageBox.isAdmin == true)
            {
                ChangeDatabase changeDatabase = new ChangeDatabase();
                changeDatabase.ShowDialog();
            }
        }
    }
}
