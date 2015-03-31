using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class DirectDepositAccessorTests
    {
        [TestMethod]
        public void DirectDepositAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IDirectDepositAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }
}
