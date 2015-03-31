using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class CheckPrinterAccessor : ICheckPrinterAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }
    }
}
