using System;
using System.Data.OleDb;

namespace TestToIvsVer002.WorkClasses
{
    public class CheckerSql
    {
        public static void CheckSql(string url, string type, string mailTo)
        {
            string result;
            bool indicator = true;
            OleDbConnection coonect = new OleDbConnection(url);
            try
            {
                coonect.Open();
                coonect.Close();
            }
            catch
            {
                indicator = false;
            }

            result = indicator ? "SQL is connected" : "No SQL";

            XmlCreate.CreateXml(url, type, result);
            MailSender.EmailSend(XmlCreate.FileName, mailTo);

            Console.WriteLine($"Вы проверяете SQL Server - {url}");
            Console.WriteLine($"Результат проверки - {result}");
        }
    }
}