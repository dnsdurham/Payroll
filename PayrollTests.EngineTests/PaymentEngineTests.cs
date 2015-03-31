using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Engines;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.EngineTests
{
    [TestClass]
    public class PaymentEngineTests
    {
        [TestMethod]
        public void PaymentEngine_TestMe()
        {
            var locator = new EngineLocator();
            var engine = locator.CreateEngine<IPaymentEngine>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }
}
