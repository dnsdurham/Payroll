using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Managers;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.ManagerTests
{
    [TestClass]
    public class PayrollManagerTests
    {
        [TestMethod]
        public void PayrollManager_TestMe()
        {
            var locator = new ManagerLocator();
            var mgr = locator.CreateManager<IPayrollManager>();
            Assert.AreEqual("test", mgr.TestMe("test"));
        }
    }
}
