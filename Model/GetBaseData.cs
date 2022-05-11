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
            sqlGetWO.Append("select work_order.order_no as ERP_Code, work_order.product_no as Product_Code, ");
            sqlGetWO.Append("GROUP_CONCAT(work_order_material.material_no) AS Material_Code, ");
            sqlGetWO.Append("work_order_process.plan_quantity AS Plan, work_order_process.dispatch_quantity AS Dispatch, work_order_process.finish_quantity AS Finish, work_order.create_date AS CreateDate, work_order.order_uuid AS UUID ");
            sqlGetWO.Append("from work_order ");
            sqlGetWO.Append("JOIN work_order_process ON work_order.order_uuid = work_order_process.work_order_uuid ");
            sqlGetWO.Append("JOIN work_order_material ON work_order.order_uuid = work_order_material.work_order_uuid ");
            sqlGetWO.Append("WHERE work_order.order_uuid in (select work_order_process.work_order_uuid from work_order_process where work_order_process.dispatch_quantity > work_order_process.finish_quantity) ");
            sqlGetWO.Append("AND work_order.order_no LIKE '%SEMI%' AND work_order.delete_flag = '0' AND work_order_material.delete_flag = '0' ");
            sqlGetWO.Append("GROUP BY work_order.order_uuid order by work_order.create_date desc");
            sqlMesPlanningExcutionCon.sqlDataAdapterFillDatatable(sqlGetWO.ToString(), ref dt);
            
            return dt;
        }    
    }
}
