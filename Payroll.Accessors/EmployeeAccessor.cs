using System;
using System.Data.SqlClient;
using DapperExtensions;
using Payroll.Shared.DataContracts;
using Payroll.Shared.Interfaces;

namespace Payroll.Accessors
{
    class EmployeeAccessor : IEmployeeAccessor
    {
        public string TestMe(string input)
        {
            return input;
        }

        public Employee Save(string connString, Employee employee)
        {
            // check the data validity
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                throw new ArgumentException();
            }

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                if (employee.Id == 0)
                {
                    //create a new product
                    employee.Id = conn.Insert(employee);
                }
                else
                {
                    conn.Update(employee);
                }

                return employee;
            }
        }
    }
}
