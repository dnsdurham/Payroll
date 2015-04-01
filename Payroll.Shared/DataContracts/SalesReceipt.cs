using System;

namespace Payroll.Shared.DataContracts
{
    public class SalesReceipt
    {
        public long? Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
