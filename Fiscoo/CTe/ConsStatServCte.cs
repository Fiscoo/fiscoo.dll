using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Fiscoo.CTe
{
    [XmlRoot("consStatServCte", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class ConsStatServCte
    {
        public ConsStatServCte() { }
        public ConsStatServCte(int ambiente)
        {
            tpAmb = ambiente;
        }

        private string _versao = "2.00";
        [XmlAttribute]
        public string versao
        {
            get
            {
                return _versao;
            }
            set
            {
                throw new NotSupportedException("Setting the versao property is not supported");
            }
        }

        [XmlElement]
        public int tpAmb { get; set; }

        private string _xServ = "STATUS";
        [XmlElement]
        public string xServ
        {
            get
            {
                return _xServ;
            }
            set
            {
                throw new NotSupportedException("Setting the xServ property is not supported");
            }
        }
    }

    public static class XmlExtension
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null) return string.Empty;

            var xmlSerializer = new XmlSerializer(typeof(T));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, "http://www.portalfiscal.inf.br/cte");

            XmlWriterSettings settings = new XmlWriterSettings();
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
