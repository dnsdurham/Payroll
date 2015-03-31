using Payroll.Accessors;
using Payroll.Shared.Interfaces;

namespace Payroll.Engines
{
    public abstract class EngineBase
    {
        protected IAccessorLocator AccessorLocator { get; set; }

        protected EngineBase()
        {
            AccessorLocator = new AccessorLocator();
        }
    }
}
