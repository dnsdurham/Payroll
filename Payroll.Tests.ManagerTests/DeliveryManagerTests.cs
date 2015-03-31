using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Managers;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.ManagerTests
{
    [TestClass]
    public class DeliveryManagerTests
    {
        [TestMethod]
        public void DeliveryManager_TestMe()
        {
            var locator = new ManagerLocator();
            var mgr = locator.CreateManager<IDeliveryManager>();
            Assert.AreEqual("test", mgr.TestMe("test"));
        }
    }
}
