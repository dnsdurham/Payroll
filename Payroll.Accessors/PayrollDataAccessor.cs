using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class PayrollDataAccessor : IPayrollDataAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }
    }
}
