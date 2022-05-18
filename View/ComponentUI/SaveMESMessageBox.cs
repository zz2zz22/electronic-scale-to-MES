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
    public partial class SaveMESMessageBox : Form
    {
        public SaveMESMessageBox()
        {
            InitializeComponent();
        }
        static SaveMESMessageBox newMessageBox;
        static string Button_id;

        public static string ShowBox()
        {
            newMessageBox = new SaveMESMessageBox();
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            lb_erpCodeInfo.Text = SaveVariables.erpCode;
            lb_prodCodeInfo.Text = SaveVariables.productCode;
            lb_matCodeInfo.Text = SaveVariables.materialCode;
            lb_scaleQtyInfo.Text = SaveVariables.scaleTotalQty.ToString();
            lb_dispatchQtyInfo.Text = SaveVariables.dispatchQty.ToString();
            lb_employeeInfo.Text = GetBaseData.getEmployeeName(SaveVariables.employeeUUID);
        }

        private void btn_msgBoxConfirm_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
            
        }

        private void btn_msgBoxCancel_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
            Button_id = "2";
        }
    }
}
