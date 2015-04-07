using Payroll.Shared.Interfaces;

namespace Payroll.Engines
{
    class PaymentEngine : EngineBase, IPaymentEngine
    {
        public string TestMe(string input)
        {
            return AccessorLocator.CreateAccessor<IPaymentAccessor>().TestMe(input);
        }

        public Shared.DataContracts.Paycheck CreatePaycheck(Shared.DataContracts.Employee employee, Shared.DataContracts.PayrollDataItem[] payrollDataItems, Shared.DataContracts.TimeCard[] timeCards)
        {
            throw new System.NotImplementedException();
        }
    }
}
