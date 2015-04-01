using Payroll.Shared.DataContracts;
using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class EmployeeAccessor : IEmployeeAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }

        public Employee Save(string connectionString, Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
