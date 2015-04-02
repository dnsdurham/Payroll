using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll.Accessors;
using Payroll.Shared.DataContracts;
using Payroll.Shared.Interfaces;

namespace Payroll.Tests.AccessorTests
{
    [TestClass]
    public class EmployeeAccessorTests
    {
        string _connectionString;
        TransactionScope _transactionScope;
        IAccessorLocator _locator;
        IEmployeeAccessor _empAccessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PayrollDatabase"].ConnectionString;
            // transactions used to be able to roll back any DML statements to keep test database consistent
            _transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew);
            _locator = new AccessorLocator();
            _empAccessor = _locator.CreateAccessor<IEmployeeAccessor>();
        }

        #region Utilities

        private Employee NewEmployee()
        {
            return new Employee()
            {
                FirstName = "Gern",
                HireDate = DateTime.Today,
                LastName = "Blansten"
            };
            
        }

        #endregion

        [TestMethod]
        public void EmployeeAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IEmployeeAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }

        /// <summary>
        /// This test verifies we can save a new employee
        /// </summary>
        [TestMethod]
        public void EmployeeAccessor_SaveNew()
        {
            Employee emp = NewEmployee();
            _empAccessor.Save(_connectionString, emp);

            // test basic employee data save
            Assert.IsTrue(emp.Id > 0);

            // test for a valid reference to a union
            Employee empUnion = NewEmployee();
            empUnion.UnionId = 1; // setting it to the static test union in the test db
            _empAccessor.Save(_connectionString, empUnion);
            Assert.IsTrue(empUnion.Id > 0);
            Assert.IsTrue(empUnion.UnionId > 0);
        }

        /// <summary>
        /// This test verifies we can save a new employee with a union reference
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void EmployeeAccessor_SaveNewInvalidUnion()
        {
            Employee emp = NewEmployee();

            // Test an invalid union reference
            emp.UnionId = 0; // set it to an invalid union key
            _empAccessor.Save(_connectionString, emp);
        }

        /// <summary>
        /// this test verifies that we are throwing exceptions when we have invalid field data
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeAccesor_SaveNewInvalidFirstName()
        {
            Employee emp = NewEmployee();
            // clear the FirstName
            emp.FirstName = "";
            _empAccessor.Save(_connectionString, emp);  
            Assert.Fail();

            // TODO: add tests for other fields
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _transactionScope.Dispose();
        }
    }

    
}
