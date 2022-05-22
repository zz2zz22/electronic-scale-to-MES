using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;

namespace ElectronicScale2MES
{
    class DatabaseUtils
    {
        //Data connection to get data 
        #region BaseDataCon 
        public static MySqlConnection GetMes_Base_DataDBC() 
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Planning_ExcutionDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Quality_ControlDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_quality_control";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
        #endregion

        //Data connection to insert data to / test database con is valid ?
        #region Test&CustomDataCon
        public static MySqlConnection Get_TestMySQLDB()
        {
            string host = Properties.Settings.Default.conHost;
            string user = Properties.Settings.Default.conUser;
            string password = Properties.Settings.Default.conPassword;

            return DatabaseSQLServerUtils.TestMySQL(host, user, password);
        }

        public static SqlConnection Get_TestMSSQLDB()
        {
            if (Properties.Settings.Default.conHostType == 0)
            {
                string datasource = Properties.Settings.Default.conHost;
                string user = Properties.Settings.Default.conUser;
                string password = Properties.Settings.Default.conPassword;
                

                return DatabaseSQLServerUtils.TestMSSQL(datasource, user, password);
            }
            else
            {
                string datasource = Properties.Settings.Default.conHost; //test
                return DatabaseSQLServerUtils.TestMSSQL(datasource, null, null);
            }
        }

        //Custom MySQL Connection
        public static MySqlConnection GetCustom2MesBaseDataCon()
        {
            string host = Properties.Settings.Default.conHost;
            string user = Properties.Settings.Default.conUser;
            string password = Properties.Settings.Default.conPassword;
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetCustom2DatabaseConnection(host, user, password, database);
        }
        public static MySqlConnection GetCustom2MesPlanningExcutionCon()
        {
            string host = Properties.Settings.Default.conHost;
            string user = Properties.Settings.Default.conUser;
            string password = Properties.Settings.Default.conPassword;
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetCustom2DatabaseConnection(host, user, password, database);
        }

        public static MySqlConnection GetCustom2MesQualityControlCon()
        {
            string host = Properties.Settings.Default.conHost;
            string user = Properties.Settings.Default.conUser;
            string password = Properties.Settings.Default.conPassword;
            string database = "mes_quality_control";

            return DatabaseSQLServerUtils.GetCustom2DatabaseConnection(host, user, password, database);
        }

        //Custom MSSQL Connection
        public static SqlConnection GetCustomMesBaseData()
        {
            if (Properties.Settings.Default.conHostType == 0)
            {
                string datasource = Properties.Settings.Default.conHost;
                string user = Properties.Settings.Default.conUser;
                string password = Properties.Settings.Default.conPassword;
                string database = "mes_base_data";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, user, password);
            }
            else
            {
                string datasource = Properties.Settings.Default.conHost; //test//DESKTOP-R9UCIUR\SQLEXPRESS
                string database = "mes_base_data";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, null, null);
            }
        }
        public static SqlConnection GetCustomMesPlanningExcutionCon()
        {
            if (Properties.Settings.Default.conHostType == 0)
            {
                string datasource = Properties.Settings.Default.conHost;
                string user = Properties.Settings.Default.conUser;
                string password = Properties.Settings.Default.conPassword;
                string database = "mes_planning_excution";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, user, password);
            }
            else 
            {
                string datasource = Properties.Settings.Default.conHost; //test//DESKTOP-R9UCIUR\SQLEXPRESS
                string database = "mes_planning_excution";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, null, null);
            }
        }

        public static SqlConnection GetCustomMesQualityControlCon()
        {
            if (Properties.Settings.Default.conHostType == 0)
            {
                string datasource = Properties.Settings.Default.conHost;
                string user = Properties.Settings.Default.conUser;
                string password = Properties.Settings.Default.conPassword;
                string database = "mes_quality_control";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, user, password);
            }
            else 
            {
                string datasource = Properties.Settings.Default.conHost; //test
                string database = "mes_quality_control";

                return DatabaseSQLServerUtils.GetCustomDatabaseConnection(datasource, database, null, null);
            }
        }
        #endregion
    }
}
