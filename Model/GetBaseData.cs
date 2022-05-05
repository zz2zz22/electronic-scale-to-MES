using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class GetBaseData
    {
        public static string getProdNo(string workOrderUUID)
        {
            StringBuilder sqlGetProdNo = new StringBuilder();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            sqlGetProdNo.Append("Select distinct product_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = 0");
            string prodNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString(sqlGetProdNo.ToString());
            return prodNo;
        }
        public static DataTable getWorkOrderDTtoDataGrid()
        {
            DataTable dt = new DataTable();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            StringBuilder sqlGetWO = new StringBuilder();
            sqlGetWO.Append("select * from work_order where order_uuid in (select work_order_uuid from work_order_process where dispatch_quantity > finish_quantity) AND work_order.order_no LIKE '%SEMI%' AND work_order.delete_flag = '0' order by work_order.create_date");
            sqlMesPlanningExcutionCon.sqlDataAdapterFillDatatable(sqlGetWO.ToString(), ref dt);
            return dt;
        }
        public static DataTable getSearchOrder ()
    }
}
