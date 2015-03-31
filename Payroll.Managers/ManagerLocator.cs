using System;
using Payroll.Shared.Interfaces;

namespace Payroll.Managers
{
    public class ManagerLocator : IManagerLocator
    {
        public T CreateManager<T>() where T : class
        {
            if (typeof(T) == typeof(IEmployeeManager))
                return new EmployeeManager() as T;

            if (typeof(T) == typeof(IPayrollManager))
                return new PayrollManager() as T;

            if (typeof(T) == typeof(IDeliveryManager))
                return new DeliveryManager() as T;
            
            throw new ArgumentException(typeof(T).Name + " is not supported by this locator");
        }
    }
}
