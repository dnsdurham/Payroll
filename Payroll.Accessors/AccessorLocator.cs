using System;
using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    public class AccessorLocator : IAccessorLocator
    {
        public T CreateAccessor<T>() where T : class
        {
            if (typeof(T) == typeof(ICheckPrinterAccessor))
                return new CheckPrinterAccessor() as T;

            if (typeof(T) == typeof(IDirectDepositAccessor))
                return new DirectDepositAccessor() as T;

            if (typeof(T) == typeof(IEmployeeAccessor))
                return new EmployeeAccessor() as T;

            if (typeof(T) == typeof(IPaymentAccessor))
                return new PaymentAccessor() as T;

            if (typeof(T) == typeof(IPayrollDataAccessor))
                return new PayrollDataAccessor() as T;

            throw new ArgumentException(typeof(T).Name + " is not supported by this locator");
        }
    }
}
