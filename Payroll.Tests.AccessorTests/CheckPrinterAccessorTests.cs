using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class CheckPrinterAccessorTests
    {
        [TestMethod]
        public void CheckPrinterAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<ICheckPrinterAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }
    }
}
