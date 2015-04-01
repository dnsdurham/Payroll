using System;

namespace Payroll.Shared.DataContracts
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public long? UnionId { get; set; }
    }
}
