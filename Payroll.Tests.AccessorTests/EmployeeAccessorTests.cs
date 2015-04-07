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

        /// <summary>
        /// Creates a new instance of a generic employee
        /// </summary>
        /// <returns></returns>
        private Employee NewEmployee()
        {
            return new Employee()
            {
                FirstName = "Gern",
                HireDate = DateTime.Today,
                LastName = "Blansten"
            };
            
        }

        /// <summary>
        /// Creates a new instance of a generic union
        /// </summary>
        /// <returns></returns>
        private Union NewUnion()
        {
            return new Union()
            {
                Dues = 1.00M,
                Name = "Test Union"
            };
        }

        /// <summary>
        /// Create a union record in the database to be used by the other tests
        /// </summary>
        /// <returns>Union</returns>
        private Union CreateUnionRecord()
        {
            return _empAccessor.Save(_connectionString, NewUnion());
        }

        #endregion

        [TestMethod]
        public void EmployeeAccessor_TestMe()
        {
            var locator = new AccessorLocator();
            var engine = locator.CreateAccessor<IEmployeeAccessor>();
            Assert.AreEqual("test", engine.TestMe("test"));
        }

        #region Employee Tests
        
        /// <summary>
        /// This test verifies we can save a new employee
        /// </summary>
        [TestMethod]
        public void EmployeeAccessor_SaveNew()
        {
            var emp = NewEmployee();
            _empAccessor.Save(_connectionString, emp);

            // test basic employee data save
            Assert.IsTrue(emp.Id > 0);
            Assert.IsTrue(emp.FirstName == NewEmployee().FirstName);
            Assert.IsTrue(emp.LastName == NewEmployee().LastName);
            Assert.IsTrue(emp.HireDate == NewEmployee().HireDate);

            // test for a valid reference to a union
            var empUnion = NewEmployee();
            var union = CreateUnionRecord();
            empUnion.UnionId = union.Id; 
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
            var emp = NewEmployee();

            // Test an invalid union reference
            emp.UnionId = 0; // set it to an invalid union key
            _empAccessor.Save(_connectionString, emp);
        }

        /// <summary>
        /// this test verifies that we are throwing exceptions when we have invalid first name
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeAccessor_InvalidFirstName()
        {
            var emp = NewEmployee();
            // clear the FirstName
            emp.FirstName = "";
            _empAccessor.Save(_connectionString, emp); // should throw exception
        }

        /// <summary>
        /// this test verifies that we are throwing exceptions when we have invalid first name
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeAccessor_InvalidLastName()
        {
            var emp = NewEmployee();
            // clear the FirstName
            emp.LastName = "";
            _empAccessor.Save(_connectionString, emp); // should throw exception
        }

        #endregion


        #region Union Tests

        /// <summary>
        /// Verfies the ability to add a union
        /// </summary>
        [TestMethod]
        public void EmployeeAccessor_SaveNewUnion()
        {
            var union = NewUnion();
            _empAccessor.Save(_connectionString, union);

            // test basic union data save
            Assert.IsTrue(union.Id > 0);
            Assert.IsTrue(union.Dues == NewUnion().Dues);
            Assert.IsTrue(union.Name == NewUnion().Name);
        }

        /// <summary>
        /// this test verifies that we are throwing exceptions when we have invalid field data
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeAccessor_InvalidUnionName()
        {
            var union = NewUnion();
            // clear the Name
            union.Name = "";
            _empAccessor.Save(_connectionString, union); // should throw exception
        }

        /// <summary>
        /// this test verifies that we are throwing exceptions when we have invalid field data
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeAccessor_SaveUnionInvalidDues()
        {
            var union = NewUnion();
            // Set the dues < 0
            union.Dues = -1.00M;
            _empAccessor.Save(_connectionString, union); // should throw exception
        }

        #endregion

        [TestCleanup]
        public void TestCleanup()
        {
            _transactionScope.Dispose();
        }
    }

    
}
