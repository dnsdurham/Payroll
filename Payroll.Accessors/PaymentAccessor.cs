using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class PaymentAccessor : IPaymentAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }

        public Shared.DataContracts.Paycheck Save(string connString, Shared.DataContracts.Paycheck paycheck)
        {
            throw new System.NotImplementedException();
        }
    }
}
