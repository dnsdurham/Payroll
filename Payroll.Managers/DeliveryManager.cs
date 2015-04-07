using Payroll.Shared.Interfaces;

namespace Payroll.Managers
{
    class DeliveryManager : ManagerBase, IDeliveryManager
    {
        public string TestMe(string input)
        {
            string result = AccessorLocator.CreateAccessor<IPaymentAccessor>().TestMe(input);
            result = AccessorLocator.CreateAccessor<ICheckPrinterAccessor>().TestMe(result);
            return AccessorLocator.CreateAccessor<IDirectDepositAccessor>().TestMe(result);
        }

        public void DeliverPaycheck(long paycheckId)
        {
            throw new System.NotImplementedException();
        }
    }
}
