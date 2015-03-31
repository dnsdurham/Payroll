using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class PayrollDataAccessorTests
    {
        [TestMethod]
        public void PayrolLDataAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IPayrollDataAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }
}
