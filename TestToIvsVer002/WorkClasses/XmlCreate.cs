using System.Xml.Linq;

namespace TestToIvsVer002.WorkClasses
{
    public class XmlCreate
    {
        public static string FileName { get; set; }
        public static void CreateXml(string adr, string type, string result)
        {

            XDocument xdoc = new XDocument();
            XElement testSiteElement = new XElement("TestElement");
            XAttribute siteNameAttribute = new XAttribute("Name", "Test connection");
            XElement siteAdressElement = new XElement("Target", adr);
            XElement siteAvailableElement = new XElement("Available", result);
            testSiteElement.Add(siteNameAttribute);
            testSiteElement.Add(siteAdressElement);
            testSiteElement.Add(siteAvailableElement);

            XElement connections = new XElement("connections");
            connections.Add(testSiteElement);
            xdoc.Add(connections);

            FileName = "connections - " + type + ".xml";
            xdoc.Save(FileName);
        }
    }
}