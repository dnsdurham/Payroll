using System;

namespace Payroll.Shared.DataContracts
{
    public class UnionServiceCharge
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime ChargeDate { get; set; }
    }
}
