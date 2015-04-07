using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class PayrollDataAccessor : IPayrollDataAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }

        public Shared.DataContracts.PayrollDataItem[] GetPayrollItems(long employeeId, System.DateTime payDate)
        {
            throw new System.NotImplementedException();
        }

        public Shared.DataContracts.TimeCard[] GetTimeCards(long employeeId, System.DateTime payDate)
        {
            throw new System.NotImplementedException();
        }
    }
}
