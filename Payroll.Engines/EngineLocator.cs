using System;
using Payroll.Shared.Interfaces;

namespace Payroll.Engines
{
    public class EngineLocator : IEngineLocator
    {
        public T CreateEngine<T>() where T : class
        {
            if (typeof(T) == typeof(IPaymentEngine))
                return new PaymentEngine() as T;

            throw new ArgumentException(typeof(T).Name + " is not supported by this locator");
        }
    }
}
