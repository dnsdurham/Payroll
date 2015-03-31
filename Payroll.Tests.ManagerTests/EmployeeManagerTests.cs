using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Managers;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.ManagerTests
{
    [TestClass]
    public class EmployeeManagerTests
    {
        [TestMethod]
        public void EmployeeManager_TestMe()
        {
            var locator = new ManagerLocator();
            var mgr = locator.CreateManager<IEmployeeManager>();
            Assert.AreEqual("test", mgr.TestMe("test"));
        }
    }
}
