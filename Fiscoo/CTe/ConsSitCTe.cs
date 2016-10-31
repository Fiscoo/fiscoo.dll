using System;
using System.Xml.Serialization;

namespace Fiscoo.CTe
{
    [XmlRoot("consSitCTe", Namespace = "http://www.portalfiscal.inf.br/cte")]
    public class ConsSitCTe
    {
        public ConsSitCTe() { }
        public ConsSitCTe(int ambiente, string chaveAcesso)
        {
            tpAmb = ambiente;
            chCTe = chaveAcesso;
        }

        private string _versao = "3.00";
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

        private string _xServ = "CONSULTAR";
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

        [XmlElement]
        public string chCTe { get; set; }
    }
}
