using System;

namespace Payroll.Shared.DataContracts
{
    public class Paycheck
    {
        public long? Id { get; set; }
        public long EMployeeId { get; set; }
        public DateTime PayDate { get; set; }
    }
}
