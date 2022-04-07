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
    public partial class MainTask : Form
    {
        public MainTask()
        {
            InitializeComponent();
        }

        private void xuibtn_scale2MES_Click(object sender, EventArgs e)
        {
            Scale2MES scale2MES = new Scale2MES();
            scale2MES.ShowDialog();
        }
    }
}
