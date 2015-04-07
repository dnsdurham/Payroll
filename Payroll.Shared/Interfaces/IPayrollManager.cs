
using System;

namespace Payroll.Shared.Interfaces
{
    public interface IPayrollManager
    {
        string TestMe(string input);
        void ProcessPayroll(DateTime payrollDate);
    }
}
