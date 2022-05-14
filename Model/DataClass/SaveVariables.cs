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
        public static String employeeUUID { get; set; }

        public static void ResetVariables()
        { 
            erpCode = null;
            workOrderUUID = null;
            materialCode = null;
            productCode = null;
            finishQty = 0;
            dispatchQty = 0;
            scaleTotalQty = 0;
        } 
        public static void ResetEmployee()
        {
            employeeUUID = null;
        }
    }
}
