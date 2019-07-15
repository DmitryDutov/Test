using System;
using TestToIvsVer002.WorkClasses;

namespace TestToIvsVer002
{
    class Program
    {
        static void Main(string[] args)
        {
            string site;
            string mailTo = "dmitry_dutov@inbox.ru";

            switch (args.Length)
            {
                case 0:

                    site = "https://ya.ru/";
                    CheckerSite.CheckSite(site, "site", mailTo);
                    
                    string sql =
                        @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=ERIDAN-DDG-VM\SQLEXPRESS01";
                    CheckerSql.CheckSql(sql, "sql", mailTo);

                    break;

                case 1:

                    if (args[0] == "help")
                    {
                        Console.WriteLine("============================================================");
                        Console.WriteLine("1) Чтобы проверить сайт введите: -site адрес сайта");
                        Console.WriteLine("2) Чтобы проверить SQL Server введите: -sql строка подключения");
                        Console.WriteLine("3) Если ввести -site/-sql адрес e-mail, то можно будет выбрать адрес отправки\n");
                        Console.WriteLine("По значения по умолчанию: ");
                        Console.WriteLine("site - https://ya.ru/");
                        Console.WriteLine(@"sql - Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=ERIDAN-DDG-VM\SQLEXPRESS01");
                        Console.WriteLine("e-mail - dmitry_dutov@inbox.ru");
                        Console.WriteLine("============================================================");
                    }

                    break;


                case 2:
                    if (args[0] == "-site")
                    {
                        XmlReaderIt.XmlReading("site");

                        site = args[1];
                        CheckerSite.CheckSite(site, "site", mailTo);
                    }

                    if (args[0] == "-sql")
                    {
                        XmlReaderIt.XmlReading("sql");

                        sql = args[1];
                        CheckerSite.CheckSite(sql, "sql", mailTo);
                    }

                    break;

                case 3:
                    if (args[0] == "-site")
                    {
                        XmlReaderIt.XmlReading("site");

                        site = args[1];
                        CheckerSite.CheckSite(site, "site", args[2]);
                    }

                    if (args[0] == "-sql")
                    {
                        XmlReaderIt.XmlReading("sql");

                        sql = args[1];
                        CheckerSite.CheckSite(sql, "sql", args[2]);
                    }

                    break;
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
