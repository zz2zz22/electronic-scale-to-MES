using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class SaveVariables
    {
        public static String erpCode { get; set; }
        public static String productCode { get; set; }
        public static String materialCode { get; set; }
        public static double dispatchQty { get; set; }
        public static double finishQty { get; set; }
        public static String workOrderUUID { get; set; }
        public static double scaleTotalQty { get; set; }
    }
}
