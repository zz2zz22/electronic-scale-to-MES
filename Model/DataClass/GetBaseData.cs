﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class GetBaseData
    {
        public static string prodDate = DateTime.Now.ToString("yyyyMd");
        private static String moveNo = "";
        public static String moveNoGenerate() //Move No generate rule
        {
            DateTime date = DateTime.Now;
            moveNo = "MV" + date.ToString("yyyyMMddHHmmssfff");
            return moveNo;
        }
        public static string getProdLotNo(string workOrderUUID) //Product Lot No generate rule
        {
            StringBuilder sqlGetProdNo = new StringBuilder();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            sqlGetProdNo.Append("Select distinct product_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = 0");
            string prodNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString(sqlGetProdNo.ToString());
            return (prodNo + prodDate).Trim();
        }
        
        public static string getEmployeeName(string empUUID) //Get employee code - name from employee uuid for user to select
        {
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            StringBuilder sqlSelectEmp = new StringBuilder();
            sqlSelectEmp.Append("SELECT CONCAT(CODE,' - ' ,NAME) FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + empUUID + "'");
            return sqlMesBaseData.sqlExecuteScalarString(sqlSelectEmp.ToString());
        }
        public static DataTable getWorkOrderDTtoDataGrid() // get all order to data grid view
        {
            DataTable dt = new DataTable();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            StringBuilder sqlGetWO = new StringBuilder();
            sqlGetWO.Append("select work_order.order_no as ERP_Code, work_order.product_no as Product_Code, ");
            sqlGetWO.Append("GROUP_CONCAT(work_order_material.material_no) AS Material_Code, ");
            sqlGetWO.Append("work_order_process.plan_quantity AS Plan, work_order_process.dispatch_quantity AS Dispatch, work_order_process.finish_quantity AS Finish, DATE_FORMAT(work_order.create_date, '%d/%m/%Y %H:%i:%s') AS CreateDate, work_order.order_uuid AS UUID ");
            sqlGetWO.Append("from work_order ");
            sqlGetWO.Append("JOIN work_order_process ON work_order.order_uuid = work_order_process.work_order_uuid ");
            sqlGetWO.Append("JOIN work_order_material ON work_order.order_uuid = work_order_material.work_order_uuid ");
            sqlGetWO.Append("WHERE work_order.order_uuid in (select work_order_process.work_order_uuid from work_order_process where work_order_process.dispatch_quantity != work_order_process.finish_quantity AND work_order_process.delete_flag = '0') ");
            sqlGetWO.Append("AND work_order.order_no LIKE '%SEMI%' AND work_order.order_status = 'ORDER_3' AND work_order.delete_flag = '0' AND work_order_material.delete_flag = '0' ");
            sqlGetWO.Append("GROUP BY work_order.order_uuid order by work_order.create_date desc");
            sqlMesPlanningExcutionCon.sqlDataAdapterFillDatatable(sqlGetWO.ToString(), ref dt);

            return dt;
        }
    }
}
