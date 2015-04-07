
using System;
using Payroll.Shared.DataContracts;

namespace Payroll.Shared.Interfaces
{
    public interface IPayrollDataAccessor
    {
        string TestMe(string input);
        PayrollDataItem[] GetPayrollItems(long employeeId, DateTime payDate);
        TimeCard[] GetTimeCards(long employeeId, DateTime payDate);
    }
}
