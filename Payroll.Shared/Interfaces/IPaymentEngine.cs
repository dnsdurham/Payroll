
using Payroll.Shared.DataContracts;

namespace Payroll.Shared.Interfaces
{
    public interface IPaymentEngine
    {
        string TestMe(string input);
        Paycheck CreatePaycheck(Employee employee, PayrollDataItem[] payrollDataItems, TimeCard[] timeCards);
    }
}
