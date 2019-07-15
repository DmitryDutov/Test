using System;
using System.Net;
using System.Net.Mail;

namespace TestToIvsVer002.WorkClasses
{
    public class MailSender
    {
        public static void EmailSend(string nameDoc, string mailTo)
        {
            MailAddress from = new MailAddress("ddg@eridan-perm.ru", "dmitry");
            MailAddress to = new MailAddress(mailTo);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Проверка доступа";
            m.Body = "Результаты проверки находятся во вложении";
            m.IsBodyHtml = true;

            Attachment attachment = new Attachment(nameDoc);
            m.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
            smtp.Credentials = new NetworkCredential("ddg@eridan-perm.ru", "pokemon153");
            smtp.EnableSsl = true;
            smtp.Send(m);

            Console.WriteLine("Письмо отправлено");
        }
    }
}