using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Client;

namespace SifrelemeTests
{
    [TestClass]
    public class turkceKarakterFonkTest
    {
        [TestMethod]
        public void turkceKarakterFonk_SendTxt_retun_gi()
        {
            Client.Form1 form1 = new Form1();
            string text = "kağıt";
            string result=form1.turkceKarakterFonk(text);
            Assert.AreEqual("kagit", result);
        }

        [TestMethod]
        public void turkceKarakterFonk_SendTxt_retun_GI()
        {
            Client.Form1 form1 = new Form1();
            string text = "KAĞIT";
            string result = form1.turkceKarakterFonk(text);
            Assert.AreEqual("KAGIT", result);
        }
        [TestMethod]
        public void turkceKarakterFonk_SendTxt_retun_Ou()
        {
            Client.Form1 form1 = new Form1();
            string text = "Öbürleri";
            string result = form1.turkceKarakterFonk(text);
            Assert.AreEqual("Oburleri", result);
        }
    }
}
