using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SifrelemeTests
{
    [TestClass]
    public class VeriAlTest
    {
        public void checkVeriAl(bool checkSPN, bool chechSHA)
        {
            Client.Form1 form1 = new Form1();
            string girdi = "Deneme123";
            string key = "12345678";
            bool succes;

            try
            {
                form1.VeriAl(girdi, key, checkSPN, chechSHA);
                succes = true;
            }
            catch (Exception ex)
            {
                succes = false;
            }
            Assert.AreEqual(true, succes);
        }

        [TestMethod]
        public void veriAlTest_chechSPN_is_True_chechSHA_is_False()
        {
            bool checkSPN = true;
            bool chechSHA = false;
            checkVeriAl(checkSPN, chechSHA);
        }
        [TestMethod]
        public void veriAlTest_chechSPN_is_False_chechSHA_is_True()
        {
            bool checkSPN = false;
            bool chechSHA = true;
            checkVeriAl(checkSPN, chechSHA);
        }
        [TestMethod]
        public void veriAlTest_chechSPN_is_False_chechSHA_is_False()
        {
            bool checkSPN = false;
            bool chechSHA = false;
            checkVeriAl(checkSPN, chechSHA);
        }
    }
}
