using System;
using System.Xml;

namespace TestToIvsVer002.WorkClasses
{
    public class XmlReaderIt
    {
        public static void XmlReading(string type)
        {
            var doc = new XmlDocument();
            doc.Load("connections - " + type + ".xml");
            var root = doc.DocumentElement;
            Console.WriteLine("Результаты предыдущей проверки\n");
            foreach (var child in root.ChildNodes)
            {
                if (child is XmlElement node)
                {
                    Console.Write($"Адрес: - {node["Target"].InnerText}\n");
                    Console.WriteLine();
                    Console.Write($"Состояние: - {node["Available"].InnerText}\n");
                }
            }
        }
    }
}