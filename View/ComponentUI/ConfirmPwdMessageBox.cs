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
    public partial class ConfirmPwdMessageBox : Form
    {
        public ConfirmPwdMessageBox()
        {
            InitializeComponent();
        }
        public static bool isAdmin { get; set; }
        
        private void btn_confirmPassword_Click(object sender, EventArgs e)
        {
            lb_logShow.Text = String.Empty;
            if (txb_inputPassword.Text == "techlink@123")
            {
                isAdmin = true;
                this.Close();
            }
            else
            {
                lb_logShow.Text = "Wrong password please try again!";
                isAdmin = false;
            }
        }

        private void txb_inputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_logShow.Text = String.Empty;
                if (txb_inputPassword.Text == "techlink@123")
                {
                    isAdmin = true;
                    this.Close();
                }
                else
                {
                    lb_logShow.Text = "Wrong password please try again!";
                    isAdmin = false;
                }
            }
        }
    }
}
