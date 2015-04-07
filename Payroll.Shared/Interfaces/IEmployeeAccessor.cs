using System;
using Payroll.Shared.DataContracts;

namespace Payroll.Shared.Interfaces
{
    public interface IEmployeeAccessor
    {
        string TestMe(string input);
        Employee Save(string connString, Employee employee);
        Union Save(string connString, Union union);
    }
}
