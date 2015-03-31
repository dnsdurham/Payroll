using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Managers;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.ManagerTests
{
    [TestClass]
    public class ManagerLocatorTests
    {
        [TestMethod]
        public void ManagerLocator_CreateManager()
        {
            var locator = new ManagerLocator();
            // tests for each handled interface
            Assert.AreNotEqual(null, locator.CreateManager<IEmployeeManager>());
            Assert.AreNotEqual(null, locator.CreateManager<IPayrollManager>());
            Assert.AreNotEqual(null, locator.CreateManager<IDeliveryManager>());

            // tests for bad parameters
            // the following will throw an argument exception
            try
            {
                Assert.AreEqual(null, locator.CreateManager<IFormatProvider>());
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("IFormatProvider is not supported by this locator", ex.Message);
            }
            catch (Exception)
            {
                Assert.Fail("unexpected exception");
            }
        }
    }
}
