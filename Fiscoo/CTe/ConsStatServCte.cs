﻿using System;
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
}
