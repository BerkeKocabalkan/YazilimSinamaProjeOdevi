using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SifrelemeTests
{
    [TestClass]
    public class spn_decryptTest
    {
        [TestMethod]
        public void spn_sifreleme_SendData_CurrectResult()
        {
            
            string data = "11101101101011011110100100101111111010111010111110100000100001011000000000010101";
            string key = "12345678";
            spn_sifreleme spn = new spn_sifreleme(data, key);
            string result = spn.decrypt(data);
            Assert.AreEqual("Deneme 123", result);

        }
    }
}
