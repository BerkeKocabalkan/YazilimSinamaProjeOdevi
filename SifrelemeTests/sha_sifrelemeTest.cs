using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SifrelemeTests
{
    [TestClass]
    public class sha_sifrelemeTest
    {
        [TestMethod]
        public void sha_sifreleme_sendData_currectResult()
        {
            string data = "deneme 123";
            sha_sifreleme asd = new sha_sifreleme(data);
            var result = asd.encrypt();
            Assert.AreEqual("eae20017a02363afe93beb892953694becbaf6b71f2a62aec5aa59b173217e9a", result);
        }

    }
}
