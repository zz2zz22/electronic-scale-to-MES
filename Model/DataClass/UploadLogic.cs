using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class UploadLogic
    {
        public static void insertScale2JobMove(string workOrderUUID, string employeeUUID, double passQty)
        { 
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
           
            string jobMoveUUID = UUIDGenerator.getAscId();
            string moveNo = GetBaseData.moveNoGenerate();
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string jobNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct job_no from job_order where uuid = '" + jobOrderUUID + "'");
            string organizationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct belong_organization from job_order where uuid = '" + jobOrderUUID + "'");
            string jobStatus = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct job_status from job_order where uuid = '" + jobOrderUUID + "'");
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
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data
            string moveDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            StringBuilder sqlInsertMPE = new StringBuilder();
            sqlInsertMPE.Append("Insert into job_move ");
            sqlInsertMPE.Append(@"( uuid, move_no, job_order_uuid, job_no, work_order_uuid, belong_organization, job_status, work_order_process_uuid, operation_uuid, operation_no, operation_name, ");
            sqlInsertMPE.Append(@"operation_description, belong_operation_type, product_uuid, product_no, product_name, unit_uuid, product_lot_no, move_out_employee_uuid, move_out_qty, move_out_pass_qty, move_out_failed_qty, ");
            sqlInsertMPE.Append(@"move_out_date, move_in_employee_uuid, move_in_operation_uuid, move_in_operation_no, move_in_operation_name, move_in_qty, move_in_pass_qty, move_in_failed_qty, move_in_date, move_status, ");
            sqlInsertMPE.Append(@"auto_receive_flag, delete_flag, create_by, update_by, create_date, update_date, tenant_id )");
            sqlInsertMPE.Append(" value ( ");
            sqlInsertMPE.Append("'" + jobMoveUUID + "','" + moveNo + "','" + jobOrderUUID + "','" + jobNo + "','" + workOrderUUID + "','" + organizationUUID + "','" + jobStatus + "','" + workOrderProcessUUID + "','" + operationUUID + "','" + operationNo + "','" + operationName + "', ");
            sqlInsertMPE.Append("'" + operationDesc + "','" + operationType + "','" + productUUID + "','" + productNo + "','" + productName + "','" + unitUUID + "','" + productLotNo + "','" + employeeUUID + "','" + passQty + "','" + passQty + "','0', ");
            sqlInsertMPE.Append("'" + moveDate + "','" + employeeUUID + "', '', '', '', '" + passQty + "','" + passQty + "','0', '" + moveDate + "','2', ");
            sqlInsertMPE.Append("'1', '0', '" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + moveDate + "','" + moveDate + "','-1') ");
            sqlMesPlanningExcution.sqlExecuteNonQuery(sqlInsertMPE.ToString());
        }
        public static void insert2JobOrderRecord(string jobOrderUUID, string employeeUUID)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();

            string jobOrderRecordUUID = UUIDGenerator.getAscId();
                
        }
    }
}
