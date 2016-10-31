using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiscoo.CTe;

namespace Fiscoo.Tests.CTe
{
    [TestClass]
    public class ConsStatServCteTests
    {
        [TestMethod]
        public void TestSerialize()
        {
            var expected = @"<consStatServCte versao=""2.00"" xmlns=""http://www.portalfiscal.inf.br/cte""><tpAmb>2</tpAmb><xServ>STATUS</xServ></consStatServCte>";
            var consStatServCte = new ConsStatServCte(2);
            Assert.AreEqual(expected, consStatServCte.Serialize());
        }
    }
}
