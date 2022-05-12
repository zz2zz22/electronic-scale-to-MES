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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            xuiWidgetPanel1.Controls.Add(childForm);
            xuiWidgetPanel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void xuibtn_mainTask_Click(object sender, EventArgs e)
        {
            openChildForm(new MainTask());
        }
    }
}
