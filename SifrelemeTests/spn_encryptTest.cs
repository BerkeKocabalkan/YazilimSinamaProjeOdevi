using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SifrelemeTests
{
    [TestClass]
    public class spn_encryptTest
    {
        [TestMethod]
        public void Spn_encrypt_SendData_CurrectResult()
        {
            string data = "deneme 123";
            sha_sifreleme asd = new sha_sifreleme(data);
            var result = asd.encrypt();
            Assert.AreEqual("eae20017a02363afe93beb892953694becbaf6b71f2a62aec5aa59b173217e9a", result);
        }
    }
}
