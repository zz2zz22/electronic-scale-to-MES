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
        public static int getJobStatus(string workOrderUUID, double scaleTotalQty)
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
            if (planQty == totalQty + scaleTotalQty)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }
        
        public static string insertScale2JobMove(string workOrderUUID, string employeeUUID, double scaleTotalQty, double passQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string jobMoveUUID = UUIDGenerator.getAscId();
            string moveNo = GetBaseData.moveNoGenerate();
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string jobNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct job_no from job_order where uuid = '" + jobOrderUUID + "'");
            string organizationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct belong_organization from job_order where uuid = '" + jobOrderUUID + "'");
            int jobStatus = getJobStatus(workOrderUUID, scaleTotalQty);
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

        public static string insert2JobOrderRecord(string workOrderUUID, string employeeUUID, double scaleTotalQty, double passQty, double failQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string jobOrderRecordUUID = UUIDGenerator.getAscId();
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string equipmentUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct equipment_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string actualEndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string actualStartTime = "NULL";
            int checkNumberoOrder = int.Parse(sqlMesPlanningExcution.sqlExecuteScalarString("select COUNT(job_order_uuid) from job_order_record where job_order_uuid = '" + jobOrderUUID + "' and delete_flag = '0'"));
            if (checkNumberoOrder > 0)
            {
                actualStartTime = "'" + sqlMesPlanningExcution.sqlExecuteScalarString("select actual_end_time from job_order_record where job_order_uuid = '" + jobOrderUUID + "' and delete_flag = '0' order by id desc limit 1") + "'";
            }
            string stationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct station_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string tempStationUUID;

            if (stationUUID == string.Empty)
            {
                tempStationUUID = "NULL";
            }
            else
            {
                tempStationUUID = "'" + stationUUID + "'";
            }
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data

            StringBuilder sqlInsertJOR = new StringBuilder();
            sqlInsertJOR.Append("Insert into job_order_record ");
            sqlInsertJOR.Append(@"( uuid, job_order_uuid, employee_uuid, equipment_uuid, station_uuid, tooling_uuid, tooling_total_cavity_qty, ");
            sqlInsertJOR.Append(@"actual_start_time, actual_end_time, actual_finish_qty, auto_actual_finish_qty, actual_pass_qty, actual_fail_qty, ");
            sqlInsertJOR.Append(@"product_lot_no, first_check_flag, ipqc_check_flag, delete_flag, create_by, update_by, create_date, update_date, tenant_id )");
            sqlInsertJOR.Append(" values ( ");
            sqlInsertJOR.Append("'" + jobOrderRecordUUID + "','" + jobOrderUUID + "','" + employeeUUID + "','" + equipmentUUID + "'," + tempStationUUID + ",'','', ");
            sqlInsertJOR.Append("" + actualStartTime + ",'" + actualEndTime + "','" + scaleTotalQty + "',NULL,'" + passQty + "','" + failQty + "', ");
            sqlInsertJOR.Append("'" + productLotNo + "','1','0','0','" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + Date + "','" + Date + "','-1')");

            return sqlInsertJOR.ToString();
        }
        public static string insert2WorkOrderLots(string workOrderUUID, string employeeUUID, double scaleTotalQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string workOrderLotsUUID = UUIDGenerator.getAscId();
            string materialUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_uuid from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string materialNo = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_no from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string materialName = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct product_name from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string specification = sqlMesPlanningExcution.sqlExecuteScalarString("select distinct specification from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string lot_no = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data

            StringBuilder sqlInsertWOL = new StringBuilder();
            sqlInsertWOL.Append("Insert into work_order_lots ");
            sqlInsertWOL.Append(@"(uuid, work_order_uuid, material_uuid, material_no, material_name, specification, lot_no, ");
            sqlInsertWOL.Append(@"serial_no, lot_qty, is_product, tenant_id, delete_flag, create_by, update_by, create_date, update_date )");
            sqlInsertWOL.Append(" values ( ");
            sqlInsertWOL.Append("'" + workOrderLotsUUID + "','" + workOrderUUID + "','" + materialUUID + "',N'" + materialNo + "',N'" + materialName + "',N'" + specification + "','" + lot_no + "', ");
            sqlInsertWOL.Append("NULL,'" + scaleTotalQty + "','1','-1','0','" + getEmpCreateCode + "','" + getEmpCreateCode + "','" + Date + "','" + Date + "' )");

            return sqlInsertWOL.ToString();
        }

        public static string updateJobOrder(string workOrderUUID, string employeeUUID, double scaleTotalQty, double passQty, double failQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            int jobStatus = getJobStatus(workOrderUUID, scaleTotalQty);
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data
            StringBuilder sqlUpdateJO = new StringBuilder();
            sqlUpdateJO.Append("update job_order set employee_uuid = '" + employeeUUID + "', job_status = '" + jobStatus + "', actual_finish_qty = COALESCE(actual_finish_qty, 0) + " + scaleTotalQty + ", ");
            sqlUpdateJO.Append("product_lot_no = '" + productLotNo + "', pass_qty = COALESCE(pass_qty, 0) + " + passQty + ", failed_qty = COALESCE(failed_qty, 0) + " + failQty + ", update_by = '" + getEmpCreateCode + "', update_date = '" + Date + "' ");
            sqlUpdateJO.Append("where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");

            return sqlUpdateJO.ToString();
        }

        public static string updateWorkOrder(string workOrderUUID, string employeeUUID, double scaleTotalQty, double passQty, double failQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data
            StringBuilder sqlUpdateWO = new StringBuilder();
            sqlUpdateWO.Append("update work_order set end_quantity = COALESCE(end_quantity, 0) + " + scaleTotalQty + ", pass_quantity = COALESCE(pass_quantity,0) + " + passQty + ", not_good_quantity = COALESCE(not_good_quantity, 0) + " + failQty + ", ");
            sqlUpdateWO.Append("update_by = '" + getEmpCreateCode + "', update_date = '" + Date + "' ");
            sqlUpdateWO.Append("where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");

            return sqlUpdateWO.ToString();
        }

        public static string updateWorkOrderProcess(string workOrderUUID, string employeeUUID, double scaleTotalQty, double passQty)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string getWOPUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select work_order_process_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data
            StringBuilder sqlUpdateWOP = new StringBuilder();
            sqlUpdateWOP.Append("update work_order_process set finish_quantity = COALESCE(finish_quantity , 0) + " + scaleTotalQty + ", check_pass_quantity = COALESCE(check_pass_quantity, 0) + " + passQty + ", ");
            sqlUpdateWOP.Append("roll_in_quantity = COALESCE(roll_in_quantity, 0) + " + passQty + ", update_by = '" + getEmpCreateCode + "', update_date = '" + Date + "' ");
            sqlUpdateWOP.Append("where uuid = '" + getWOPUUID + "' and work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");

            return sqlUpdateWOP.ToString();
        }

        public static int getNextValueQC(string workOrderUUID)
        {
            int currentValue;
            int nextValue;
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            string jobNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString("select job_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string currentNumber = sqlMesBaseData.sqlExecuteScalarString("Select current_number from autocode_his where autocode_rule_uuid = '4AL735T142O1' and autocode_no like '%" + jobNo + "%' and delete_flag = '0'");

            if (currentNumber == String.Empty)
            {
                currentValue = 0;
                nextValue = currentValue + 1;
                SaveVariables.isEmptyAutoCode = true;
            }
            else
            {
                currentValue = int.Parse(currentNumber);
                nextValue = currentValue + 1;
                SaveVariables.isEmptyAutoCode = false;
            }
            if (nextValue.ToString().Length > 6)
            {
                nextValue = 0;
            }
            return nextValue;
        }
        public static string insertAutoCodeHis(string workOrderUUID, string employeeUUID)
        {
            int currentNumber = getNextValueQC(workOrderUUID);
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();

            string jobNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString("select job_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");

            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'");
            StringBuilder sqlInsertAutocodeHis = new StringBuilder();
            sqlInsertAutocodeHis.Append("insert into autocode_his ");
            sqlInsertAutocodeHis.Append(@"(uuid, autocode_rule_uuid, autocode_info_uuid, autocode_no, current_number, delete_flag, ");
            sqlInsertAutocodeHis.Append(@"create_by, update_by, create_date, update_date, tenant_id) ");
            sqlInsertAutocodeHis.Append(" values ( ");
            sqlInsertAutocodeHis.Append("'" + UUIDGenerator.getAscId() + "', '4AL735T142O1', '4AL735VJK8X1', '" + jobNo + "{0}" + "', '" + currentNumber + "','0', ");
            sqlInsertAutocodeHis.Append("'" + getEmpCreateCode + "', '" + getEmpCreateCode + "', '" + Date + "', '" + Date + "', '-1')");
            return sqlInsertAutocodeHis.ToString();
        }
        public static string updateAutoCodeHis(string workOrderUUID, string employeeUUID)
        {
            int currentNumber = getNextValueQC(workOrderUUID);
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string jobNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString("select job_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'");
            string autocodeHisUUID = sqlMesBaseData.sqlExecuteScalarString("Select uuid from autocode_his where autocode_rule_uuid = '4AL735T142O1' and autocode_no like '%" + jobNo + "%' and delete_flag = '0'");
            StringBuilder sqlUpdateAutocodeHis = new StringBuilder();
            sqlUpdateAutocodeHis.Append("update autocode_his set current_number = '" + currentNumber + "', update_by = '" + getEmpCreateCode + "', update_date  = '" + Date + "' where uuid = '" + autocodeHisUUID + "' and autocode_rule_uuid = '4AL735T142O1' and autocode_no like '%" + jobNo + "%' and delete_flag = '0'");
            return sqlUpdateAutocodeHis.ToString();
        }

        public static string qcNoGenerator(string workOrderUUID)
        {
            string currentNo = getNextValueQC(workOrderUUID).ToString();
            sqlMesPlanningExcutionCon sqlMesPlanningExcutionCon = new sqlMesPlanningExcutionCon();

            string jobNo = sqlMesPlanningExcutionCon.sqlExecuteScalarString("select job_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string qcNo = jobNo + currentNo.PadLeft(6, '0');

            return qcNo;
        }

        public static string insertQualityControlOrder(string workOrderUUID, string employeeUUID)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string productLotNo = GetBaseData.getProdLotNo(workOrderUUID);
            string qcNo = qcNoGenerator(workOrderUUID);
            string workOrderNo = sqlMesPlanningExcution.sqlExecuteScalarString("select order_no from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string saleOrderNo = sqlMesPlanningExcution.sqlExecuteScalarString("select sales_order_no from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string productUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select product_uuid from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string productNo = sqlMesPlanningExcution.sqlExecuteScalarString("select product_no from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string productName = sqlMesPlanningExcution.sqlExecuteScalarString("select product_name from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string specification = sqlMesPlanningExcution.sqlExecuteScalarString("select specification from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            
            string jobOrderUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string jobOrderRecordUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select uuid from job_order_record where job_order_uuid = '" + jobOrderUUID + "' and delete_flag = '0'");
            string workOrderProcessUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select work_order_process_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string operationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select operation_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string operationNo = sqlMesPlanningExcution.sqlExecuteScalarString("select operation_no from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string operationName = sqlMesPlanningExcution.sqlExecuteScalarString("select operation_name from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string operationDesc = sqlMesPlanningExcution.sqlExecuteScalarString("select operation_description from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string sectionUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select section_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string groupUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select group_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string tempGroupUUID;
            if (groupUUID == String.Empty)
            {
                tempGroupUUID = "NULL";
            }
            else
            {
                tempGroupUUID = "'" + groupUUID + "'";
            }
            string organizationUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select belong_organization from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string unitUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select unit_uuid from job_order where work_order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string tempUnitUUID;
            if (unitUUID == String.Empty)
            {
                tempUnitUUID = "NULL";
            }
            else
            {
                tempUnitUUID = "'" + unitUUID + "'";
            }
            string planStartTime = sqlMesPlanningExcution.sqlExecuteScalarString("select plan_start_time from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string planEndTime = sqlMesPlanningExcution.sqlExecuteScalarString("select plan_end_time from work_order where order_uuid = '" + workOrderUUID + "' and delete_flag = '0'");
            string getEmpCreateCode = sqlMesBaseData.sqlExecuteScalarString("SELECT CODE FROM mes_base_data.employee_info WHERE employee_info.uuid = '" + employeeUUID + "'"); // get employee code from mes_base_data

            StringBuilder sqlInsertQLCO = new StringBuilder();
            sqlInsertQLCO.Append("insert into quality_control_order ");
            sqlInsertQLCO.Append(@"( uuid, qc_no, work_order_uuid, work_order_no, sales_order_no, product_uuid, product_no, ");
            sqlInsertQLCO.Append(@"product_name, specification, job_order_uuid, job_order_record_uuid, work_order_process_uuid, operation_uuid, ");
            sqlInsertQLCO.Append(@"operation_no, operation_name, operation_description, section_uuid, group_uuid, belong_organization, job_move_uuid, ");
            sqlInsertQLCO.Append(@"job_move_no, relation_job_uuid, relation_job_no, qc_organization, employee_uuid, finish_quantity, qc_operation_type, qc_conclusion, qc_status, ");
            sqlInsertQLCO.Append(@"send_quantity, send_time, unit_uuid, plan_start_time, plan_end_time, actual_start_time, actual_end_time, product_lot_no, qc_checker, pass_qty, failed_qty, ");
            sqlInsertQLCO.Append(@"scrap_qty, remade_qty, remade_process, rework_qty, oversize_qty, repair_flag, scrap_made_qty, scrap_material_qty, process_result, delete_flag, ");
            sqlInsertQLCO.Append(@"create_by, update_by, create_date, update_date, tenant_id ) ");
            sqlInsertQLCO.Append(" values (");
            sqlInsertQLCO.Append("'" + UUIDGenerator.getAscId() + "','" + qcNo + "','" + workOrderUUID + "','" + workOrderNo + "','" + saleOrderNo + "','" + productUUID + "',N'" + productNo + "', ");
            sqlInsertQLCO.Append("N'" + productName + "',N'" + specification + "','" + jobOrderUUID + "','" + jobOrderRecordUUID + "','" + workOrderProcessUUID + "','" + operationUUID + "', ");
            sqlInsertQLCO.Append("'" + operationNo + "',N'" + operationName + "',N'" + operationDesc + "','" + sectionUUID + "','" + tempGroupUUID + "','" + organizationUUID + "', NULL, ");
            sqlInsertQLCO.Append("NULL, NULL, NULL, NULL, '" + employeeUUID + "','1','QC_OPERATION_TYPE1', NULL, '0', ");
            sqlInsertQLCO.Append("NULL, NULL, " + tempUnitUUID + ", '" + planStartTime + "','" + planEndTime + "', NULL, NULL, '" + productLotNo + "', NULL, '0', '0' , ");
            sqlInsertQLCO.Append("NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', ");
            sqlInsertQLCO.Append("'" + getEmpCreateCode + "', '" + getEmpCreateCode + "','" + Date + "','" + Date + "', '-1')");

            return sqlInsertQLCO.ToString();
        }
    }
}
