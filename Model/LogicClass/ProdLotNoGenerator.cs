using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class ProdLotNoGenerator
    {
        public static string prodDate = DateTime.Now.ToString("yyyyMdd");
        
        public static string generateProdLotNo()
        {
            string prodLotNo = (GetBaseData.getProdNo(SaveVariables.workOrderUUID) + prodDate).Trim();
            return prodLotNo;
        }
    }
}
