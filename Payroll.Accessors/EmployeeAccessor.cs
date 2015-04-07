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
            if ((string.IsNullOrEmpty(employee.FirstName)) || (string.IsNullOrEmpty(employee.LastName)))
            {
                throw new ArgumentException();
            }

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                if (employee.Id == 0)
                {
                    //create a new employee
                    employee.Id = conn.Insert(employee);
                }
                else
                {
                    conn.Update(employee);
                }

                return employee;
            }
        }


        public Union Save(string connString, Union union)
        {
            // check the data validity
            if ((string.IsNullOrEmpty(union.Name)) || (union.Dues < 0M))
            {
                throw new ArgumentException();
            }

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                if (union.Id == 0)
                {
                    //create a new union
                    union.Id = conn.Insert(union);
                }
                else
                {
                    conn.Update(union);
                }

                return union;
            }
        }
    }
}
