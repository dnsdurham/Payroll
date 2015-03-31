
namespace Payroll.Shared.Interfaces
{
    public interface IAccessorLocator
    {
        T CreateAccessor<T>() where T : class;
    }
}
