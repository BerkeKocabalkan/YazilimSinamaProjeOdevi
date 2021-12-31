using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TCPPort;

namespace TCPPortTests
{
    [TestClass]
    public class ServerStartTest
    {
        [TestMethod]
        public void ServerStart_Test()
        {
            try
            {
                string port;
                string host;
                //ServerProcces serverProcces = new ServerProcces();
                //serverProcces.StartServer();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
