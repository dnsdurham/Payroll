using System;

namespace Payroll.Shared.DataContracts
{
    public class TimeCard
    {
        public long? Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime CardDate { get; set; }
    }
}
