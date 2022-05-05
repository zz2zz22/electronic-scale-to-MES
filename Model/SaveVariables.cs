using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class SaveVariables
    {
        public string workOrderUUID { get; set; }
        public string workOrderNo { get; set; }
        public string workOrderType { get; set; }
        public string workOrderStatus { get; set; }
        public string erpOrderNo { get; set; }
        public string productUUID { get; set; }
        public string bomUUID { get; set; }
        public string productNo { get; set; }
        public string productName { get; set; }
        public string salesOrderNo { get; set; }
        public string productProcessUUID { get; set; }
        public string specification { get; set; }
        public string planStatus { get; set; }
        public string planType { get; set; }
        public int planQty { get; set; }
        public int batchQty { get; set; }
        public int startQty { get; set; }
        public int endQty { get; set; }
        public int passQty { get; set; }
        public int notGoodQty { get; set; }
        public int scrapQty { get; set; }
        public string organizationUUID { get; set; }
        public string processUUID { get; set; }
        public string customerUUID { get; set; }
        public string customerCode { get; set; }
        public string customerName { get; set; }
        public string planStartTime { get; set; }
        public string planEndTime { get; set; }
        public string actualStartTime { get; set; }
        public string actualEndTime { get; set; }
        public string deliveryDate { get; set; }
        public string parentUUID { get; set; }
        public int splitQty { get; set; }
        public string updateBy { get; set; }
        public string createDate { get; set; }
    }
}
