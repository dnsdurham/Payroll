using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class PaymentAccessorTests
    {
        [TestMethod]
        public void PaymentAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IPaymentAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }
}
