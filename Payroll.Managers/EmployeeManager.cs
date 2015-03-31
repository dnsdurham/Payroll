using Payroll.Shared.Interfaces;

namespace Payroll.Managers
{
    class EmployeeManager : ManagerBase, IEmployeeManager
    {
        public string TestMe(string input)
        {
            return AccessorLocator.CreateAccessor<IEmployeeAccessor>().TestMe(input);
        }
    }
}
