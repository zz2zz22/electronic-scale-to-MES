using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;

namespace ElectronicScale2MES
{
    public class UploadLogic
    {
        public static string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public static int getJobStatus(string workOrderUUID, double finishQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            string workOrderProcesssUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select work_order_process_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string planQtyStr = sqlMesPlanningExcution.sqlExecuteScalarString("select plan_quantity from work_order_process where uuid = '" + workOrderProcesssUUID + "' and delete_flag = '0'");
            string totalFinishQty = sqlMesPlanningExcution.sqlExecuteScalarString("select finish_quantity from work_order_process where uuid = '" + workOrderProcesssUUID + "' and delete_flag = '0'");
            double totalQty = 0;
            double planQty = 0;
            if (planQtyStr != String.Empty)
            {
                planQty = double.Parse(planQtyStr);
            }
            if (totalFinishQty != String.Empty)
            {
                totalQty = double.Parse(totalFinishQty);
            }
            if (planQty == totalQty + finishQty)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
        static void executeAfterCheck_MPE(string sqlQuery)
        {
            try
            {
                if (Properties.Settings.Default.conType == 0)
                {
                    sqlMySQLCon2MesPlanningExcution sqlMySQLCon2MesPlanningExcution = new sqlMySQLCon2MesPlanningExcution();
                    sqlMySQLCon2MesPlanningExcution.sqlExecuteNonQuery(sqlQuery);
                }
                else if (Properties.Settings.Default.conType == 1)
                {
                    sqlMSSQLCon2MesPlanningExcution sqlMSSQLCon2MesPlanningExcution = new sqlMSSQLCon2MesPlanningExcution();
                    sqlMSSQLCon2MesPlanningExcution.sqlExecuteNonQuery(sqlQuery);
                }
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        public static string insertScale2JobMove(string workOrderUUID, string employeeUUID, double finishQty ,double passQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string jobMoveUUID = UUIDGenerator.getAscId();
            string moveNo = GetBaseData.moveNoGenerate();
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string jobNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct job_no from job_order where uuid = '" + jobOrderUUID + "'");
            string organizationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct belong_organization from job_order where uuid = '" + jobOrderUUID + "'");
            int jobStatus = getJobStatus(workOrderUUID, finishQty);
            string workOrderProcessUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct work_order_process_uuid from job_order where uuid = '" + jobOrderUUID + "'");
            string operationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct operation_uuid from job_order where uuid = '" + jobOrderUUID + "'");
            string operationNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct operation_no from job_order where uuid = '" + jobOrderUUID + "'");
            string operationName = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct operation_name from job_order where uuid = '" + jobOrderUUID + "'");
            string operationDesc = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct operation_description from job_order where uuid = '" + jobOrderUUID + "'");
            string operationType = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct belong_operation_type from job_order where uuid = '" + jobOrderUUID + "'");
            string productUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_uuid from job_order where uuid = '" + jobOrderUUID + "'");
            string productNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_no from job_order where uuid = '" + jobOrderUUID + "'");
            string productName = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_name from job_order where uuid = '" + jobOrderUUID + "'");
            string unitUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct unit_uuid from job_order where uuid = '" + jobOrderUUID + "'");
            string tempUnitUUID;
            
            if ( unitUUID == string.Empty)
            {
                tempUnitUUID = "NULL";
            }else
            {
                tempUnitUUID = "'" + unitUUID + "'";
            }
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data


            StringBuilder sqlInsertJM = new StringBuilder();
            sqlInsertJM.Append("Insert into job_move ");
            sqlInsertJM.Append(@"( uuid, move_no, job_order_uuid, job_no, work_order_uuid, belong_organization, job_status, work_order_process_uuid, operation_uuid, operation_no, operation_name, ");
            sqlInsertJM.Append(@"operation_description, belong_operation_type, product_uuid, product_no, product_name, unit_uuid, product_lot_no, move_out_employee_uuid, move_out_qty, move_out_pass_qty, move_out_failed_qty, ");
            sqlInsertJM.Append(@"move_out_date, move_in_employee_uuid, move_in_operation_uuid, move_in_operation_no, move_in_operation_name, move_in_qty, move_in_pass_qty, move_in_failed_qty, move_in_date, move_status, ");
            sqlInsertJM.Append(@"auto_receive_flag, delete_flag, create_by, update_by, create_date, update_date, tenant_id )");
            sqlInsertJM.Append(" values ( ");
            sqlInsertJM.Append("'" + jobMoveUUID + "','" + moveNo + "','" + jobOrderUUID + "','" + jobNo + "','" + workOrderUUID + "','" + organizationUUID + "','" + jobStatus + "','" + workOrderProcessUUID + "','" + operationUUID + "',N'" + operationNo + "',N'" + operationName + "', ");
            sqlInsertJM.Append("N'" + operationDesc + "','" + operationType + "','" + productUUID + "',N'" + productNo + "',N'" + productName + "'," + tempUnitUUID + ",'" + productLotNo + "','" + employeeUUID + "','" + passQty + "','" + passQty + "','0', ");
            sqlInsertJM.Append("'" + Date + "','" + employeeUUID + "', NULL, NULL, NULL, '" + passQty + "','" + passQty + "','0', '" + Date + "','2', ");
            sqlInsertJM.Append("'1', '0', '" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + Date + "','" + Date + "','-1') ");
            return sqlInsertJM.ToString();
        }
        public static void insert2JobOrderRecord(string workOrderUUID, string employeeUUID, double finishQty, double passQty, double failQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string jobOrderRecordUUID = UUIDGenerator.getAscId();
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string equipmentUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct equipment_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string actualEndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string actualStartTime = "";
            int checkNumberoOrder = int.Parse(sqlMesPlanningExcution.sqlExecuteScalarString("select COUNT(job_order_uuid) from job_order_record where job_order_uuid = '" + jobOrderUUID + "' and delete_flag = '0'"));
            if (checkNumberoOrder > 0)
            {
                actualStartTime = sqlMesPlanningExcution.sqlExecuteScalarString("select actual_end_time from job_order_record where job_order_uuid = '" + jobOrderUUID + "' and delete_flag = '0' order by id desc limit 1");
            }
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data

            StringBuilder sqlInsertJOR = new StringBuilder();
            sqlInsertJOR.Append("Insert into job_order_record ");
            sqlInsertJOR.Append(@"( uuid, job_order_uuid, employee_uuid, equipment_uuid, station_uuid, tooling_uuid, tooling_total_cavity_qty, ");
            sqlInsertJOR.Append(@"actual_start_time, actual_end_time, actual_finish_qty, auto_actual_finish_qty, actual_pass_qty, actual_fail_qty, ");
            sqlInsertJOR.Append(@"product_lot_no, first_check_flag, ipqc_check_flag, delete_flag, create_by, update_by, create_date, update_date, tenant_id )");
            sqlInsertJOR.Append(" value ( ");
            sqlInsertJOR.Append("'" + jobOrderRecordUUID + "','" + jobOrderUUID + "','" + employeeUUID + "','" + equipmentUUID + "','','','', ");
            sqlInsertJOR.Append("'" + actualStartTime + "','" + actualEndTime + "','" + finishQty + "','','" + passQty + "','" + failQty + "', ");
            sqlInsertJOR.Append("'" + productLotNo + "','1','0','0','" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + Date + "','" + Date + "','-1')");

            executeAfterCheck_MPE(sqlInsertJOR.ToString());
        }
        public static void insert2WorkOrderLots(string workOrderUUID, string employeeUUID, double finishQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string workOrderLotsUUID = UUIDGenerator.getAscId();
            string materialUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_uuid from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string materialNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_no from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string materialName = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_name from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string specification = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct specification from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string lot_no = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data

            StringBuilder sqlInsertWOL = new StringBuilder();
            sqlInsertWOL.Append("Insert into work_order_lots ");
            sqlInsertWOL.Append(@"(uuid, work_order_uuid, material_uuid, material_no, material_name, specification, lot_no, ");
            sqlInsertWOL.Append(@"serial_no, lot_qty, is_product, tenant_id, delete_flag, create_by, update_by, create_date, update_date )");
            sqlInsertWOL.Append(" value ( ");
            sqlInsertWOL.Append("'" + workOrderLotsUUID + "','" + workOrderUUID + "','" + materialUUID + "','" + materialNo + "','" + materialName + "','" + specification + "','" + lot_no + "', ");
            sqlInsertWOL.Append("'','" + finishQty + "','1','-1','0','" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + Date + "','" + Date + "' )");

            executeAfterCheck_MPE(sqlInsertWOL.ToString());
        }

        public static void updateJobOrder(string workOrderUUID, string employeeUUID, double finishQty, double passQty, double failQty)
        {
            int jobStatus = getJobStatus(workOrderUUID, finishQty);
            StringBuilder sqlUpdateJO = new StringBuilder();
            sqlUpdateJO.Append("");
        }
    }
}
