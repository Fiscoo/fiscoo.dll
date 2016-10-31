using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Fiscoo.CTe
{
    public static class XmlExtension
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null) return string.Empty;

            var xmlSerializer = new XmlSerializer(typeof(T));

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, "http://www.portalfiscal.inf.br/cte");

            var settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            //settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = false;
            settings.OmitXmlDeclaration = true;

            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    xmlSerializer.Serialize(xmlWriter, value, namespaces);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
