using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiscoo.CTe;

namespace Fiscoo.Tests.CTe
{
    [TestClass]
    public class ConsSitCTeTests
    {
        [TestMethod]
        public void TestSerialize()
        {
            var expected = @"<consSitCTe versao=""3.00"" xmlns=""http://www.portalfiscal.inf.br/cte""><tpAmb>2</tpAmb><xServ>CONSULTAR</xServ><chCTe>12345678901234567890123456789012345678901234</chCTe></consSitCTe>";
            var consSitCTe = new ConsSitCTe(2, "12345678901234567890123456789012345678901234");
            Assert.AreEqual(expected, consSitCTe.Serialize());
        }
    }
}
