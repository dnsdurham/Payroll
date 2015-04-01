using Payroll.Shared.DataContracts;

namespace Payroll.Shared.Interfaces
{
    public interface IEmployeeAccessor
    {
        string TestMe(string input);
        Employee Save(string connectionString, Employee employee);
    }
}
