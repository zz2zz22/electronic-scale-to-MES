using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
using ClosedXML.Excel;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace ElectronicScale2MES
{
    public class DataReport
    {
        static DataReport s_drInstance = null;


        DataTable successReportTB = null;
        DataTable failReportTB = null;

        #region CreateDatatable
        private DataReport()
        {
            successReportTB = new DataTable();

            DataColumn cl1 = new DataColumn();
            cl1.ColumnName = "Transfer Time"; //DateTime.Now
            cl1.DataType = typeof(string);

            DataColumn cl2 = new DataColumn();
            cl2.ColumnName = "MoveNo"; // 
            cl2.DataType = typeof(string);

            DataColumn cl3 = new DataColumn();
            cl3.ColumnName = "OrderNo"; // 
            cl3.DataType = typeof(string);

            DataColumn cl4 = new DataColumn();
            cl4.ColumnName = "Product Code";
            cl4.DataType = typeof(string);

            DataColumn cl5 = new DataColumn();
            cl5.ColumnName = "Product Name"; 
            cl5.DataType = typeof(string);

            DataColumn cl6 = new DataColumn();
            cl6.ColumnName = "Finish Quantity"; // 
            cl6.DataType = typeof(string);

            DataColumn cl7 = new DataColumn();
            cl7.ColumnName = "Not good Quantity";
            cl7.DataType = typeof(string);

            DataColumn cl8 = new DataColumn();
            cl8.ColumnName = "Actual finish Quantity";
            cl8.DataType = typeof(string);

            DataColumn cl9 = new DataColumn();
            cl9.ColumnName = "Upload Employee";
            cl9.DataType = typeof(string);

            successReportTB.Columns.AddRange(new DataColumn[] { cl1, cl2, cl3, cl4, cl5, cl6, cl7, cl8, cl9});



            failReportTB = new DataTable();

            DataColumn clf1 = new DataColumn();
            clf1.ColumnName = "Transfer Time";
            clf1.DataType = typeof(string);

            DataColumn clf2 = new DataColumn();
            clf2.ColumnName = "OrderNo"; // 
            clf2.DataType = typeof(string);

            DataColumn clf3 = new DataColumn();
            clf3.ColumnName = "Message"; // 
            clf3.DataType = typeof(string);

            failReportTB.Columns.AddRange(new DataColumn[] { clf1, clf2, clf3 });
        }

        public static void addReport(RP_TYPE rpType, string transDate, string MoveNo, string OrderNo, string prodCode, string prodName, string finishQty, string NgQty, string actualFinishQty, string employee, string ex)
        {
            if (s_drInstance == null)
            {
                s_drInstance = new DataReport();
            }
            s_drInstance.writeReport(rpType, transDate, MoveNo, OrderNo, prodCode, prodName, finishQty, NgQty, actualFinishQty, employee, ex);
        }

        private void writeReport(RP_TYPE rpType, string transDate, string MoveNo, string OrderNo, string prodCode, string prodName, string finishQty, string NgQty, string actualFinishQty, string employee, string ex)
        {
            if (rpType == RP_TYPE.Fail)
            {
                failReportTB.Rows.Add(new object[] { transDate, OrderNo, ex});
            }
            else
            {
                if (rpType == RP_TYPE.Success)
                {
                    successReportTB.Rows.Add(new object[] { transDate, MoveNo, OrderNo, prodCode, prodName, finishQty, NgQty, actualFinishQty, employee });
                }
            }
        }
        public enum RP_TYPE
        {
            Fail,
            Success
        };
        #endregion
        public static void SaveExcel(string excelFilePath, string fileName, string sender, string sender_pw)
        {
            if (s_drInstance == null)
            {
                s_drInstance = new DataReport();
            }
            s_drInstance.ExportToExcel(excelFilePath, fileName);
            s_drInstance.SendReport(sender, sender_pw);
            s_drInstance = null;
        }

        public void ExportToExcel(string excelFilePath, string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Scale2MES_Reports";
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
            if (dir.Exists == false)
                dir.Create();

            XLWorkbook wb = new XLWorkbook();
            var ws1 = wb.Worksheets.Add(successReportTB, "Success MO");
            var ws2 = wb.Worksheets.Add(failReportTB, "Failed MO");
            wb.Style.Fill.BackgroundColor = XLColor.NoColor;
            ws1.Column("A").Width = 19;
            ws1.Column("B").Width = 11;
            ws1.Column("C").Width = 14;
            ws1.Column("D").Width = 14;
            ws1.Column("E").Width = 15;
            ws1.Column("F").Width = 22;
            ws1.Column("G").Width = 25;
            ws1.Column("H").Width = 13;
            ws1.Column("I").Width = 34;

            ws2.Column("A").Width = 19;
            ws2.Column("B").Width = 15;
            ws2.Column("C").Width = 58;
            

            // check file path
            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    wb.SaveAs(Path.Combine(excelFilePath, fileName));
                    Properties.Settings.Default.excelFilePath = Path.Combine(excelFilePath, fileName);
                    Properties.Settings.Default.Save();
                }
                catch (Exception )
                {
                   
                }
            }
            else
            { // no file path is given
                wb.SaveAs(Path.Combine(path, fileName));
                Properties.Settings.Default.excelFilePath = Path.Combine(path, fileName);
                Properties.Settings.Default.Save();
            }
            wb.Dispose();
        }

        public void SendReport(string sender, string sender_pw)
        {
            Properties.Settings.Default.Save();
            string[] receivers = Properties.Settings.Default.receivers.Split('-');
            for (int i = 0; i < receivers.Length; i++)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("pro56.emailserver.vn");
                mail.From = new MailAddress(sender);
                mail.To.Add(receivers[i]);
                mail.Subject = "Scale to MES daily generate transfer report : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                mail.Body = "This is an auto generated report! Please don't reply!";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(Properties.Settings.Default.excelFilePath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sender, sender_pw);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                mail.Dispose();
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
