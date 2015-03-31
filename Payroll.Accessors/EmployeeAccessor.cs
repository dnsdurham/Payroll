using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class EmployeeAccessor : IEmployeeAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }
    }
}
