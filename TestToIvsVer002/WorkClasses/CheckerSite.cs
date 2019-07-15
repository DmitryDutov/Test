using System;
using System.Net;

namespace TestToIvsVer002.WorkClasses
{
    public class CheckerSite
    {
        public static void  CheckSite(string url, string type, string mailTo)
        {
            string result;
            bool indicator = true;
            Uri uri = new Uri(url);
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch
            {
                indicator = false;
            }
            
            result = indicator ? "Site is connected" : "No site";

            XmlCreate.CreateXml(url, type, result);
            MailSender.EmailSend(XmlCreate.FileName, mailTo);

            Console.WriteLine($"Вы проверяете сайт - {url}");
            Console.WriteLine($"Результат проверки - {result}");
        }
    }
}