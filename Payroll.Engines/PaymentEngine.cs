using Payroll.Shared.Interfaces;

namespace Payroll.Engines
{
    class PaymentEngine : EngineBase, IPaymentEngine
    {
        public string TestMe(string input)
        {
            return AccessorLocator.CreateAccessor<IPaymentAccessor>().TestMe(input);
        }
    }
}
