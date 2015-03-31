using Payroll.Accessors;
using Payroll.Engines;
using Payroll.Shared.Interfaces;

namespace Payroll.Managers
{
    public abstract class ManagerBase
    {
        protected IEngineLocator EngineLocator { get; set; }
        protected IAccessorLocator AccessorLocator { get; set; }

        protected ManagerBase()
        {
            EngineLocator = new EngineLocator();
            AccessorLocator = new AccessorLocator();
        }
    }
}
