
namespace Payroll.Shared.Interfaces
{
    public interface IDeliveryManager
    {
        string TestMe(string input);
        void DeliverPaycheck(long paycheckId);
    }
}
