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
    public partial class Scale2MES : Form
    {
        public Scale2MES()
        {
            InitializeComponent();
            txb_searchData.Text = UUIDGenerator.getAscId();
        }

        public DataTable GetDataFromMatsCode(string matsCode)
        {
            DataTable loadInDT = new DataTable();



            return loadInDT;
        }
    }
}
