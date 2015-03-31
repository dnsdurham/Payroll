using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Engines;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.EngineTests
{
    [TestClass]
    public class EngineLocatorTests
    {
        [TestMethod]
        public void EngineLocator_CreateEngine()
        {
            var locator = new EngineLocator();
            // tests for each handled interface
            Assert.AreNotEqual(null, locator.CreateEngine<IPaymentEngine>());

            // tests for bad parameters
            // the following will throw an argument exception
            try
            {
                Assert.AreEqual(null, locator.CreateEngine<IFormatProvider>());
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
