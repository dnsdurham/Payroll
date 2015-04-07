
using Payroll.Shared.DataContracts;

namespace Payroll.Shared.Interfaces
{
    public interface IPaymentAccessor
    {
        string TestMe(string input);
        Paycheck Save(string connString, Paycheck paycheck);
    }
}
