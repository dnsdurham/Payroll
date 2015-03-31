using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class PaymentAccessor : IPaymentAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }
    }
}
