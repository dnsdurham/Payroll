using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class EmployeeAccessorTests
    {
        [TestMethod]
        public void EmployeeAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IEmployeeAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }

    
}
