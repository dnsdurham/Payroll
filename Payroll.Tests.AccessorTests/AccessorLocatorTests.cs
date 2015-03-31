using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class AccessorLocatorTests
    {
        [TestMethod]
        public void AccessorLocator_CreateAccessor()
        {
            var locator = new AccessorLocator();
            // tests for each handled interface
            Assert.AreNotEqual(null, locator.CreateAccessor<ICheckPrinterAccessor>());
            Assert.AreNotEqual(null, locator.CreateAccessor<IDirectDepositAccessor>());
            Assert.AreNotEqual(null, locator.CreateAccessor<IEmployeeAccessor>());
            Assert.AreNotEqual(null, locator.CreateAccessor<IPaymentAccessor>());
            Assert.AreNotEqual(null, locator.CreateAccessor<IPayrollDataAccessor>());

            // tests for bad parameters
            // the following will throw an argument exception
            try
            {
                Assert.AreEqual(null, locator.CreateAccessor<IFormatProvider>());
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
