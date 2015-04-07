using Payroll.Shared.Interfaces;

namespace Payroll.Managers
{
    class PayrollManager: ManagerBase, IPayrollManager
    {
        public string TestMe(string input)
        {
            string result = AccessorLocator.CreateAccessor<IPayrollDataAccessor>().TestMe(input);
            result = AccessorLocator.CreateAccessor<IEmployeeAccessor>().TestMe(result);
            result = AccessorLocator.CreateAccessor<IPaymentAccessor>().TestMe(result);
            return EngineLocator.CreateEngine<IPaymentEngine>().TestMe(result);
        }

        public void ProcessPayroll(System.DateTime payrollDate)
        {
            throw new System.NotImplementedException();
        }
    }
}
