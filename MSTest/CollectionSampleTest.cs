using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSUnitTestExample;

namespace MSTest {
    [TestClass]
    public class CollectionSampleTest {
        [TestMethod]
        public void GetCustomer_ShouldGetSomeCustomer() {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer{FirstName = "jhon", LastName = "macleane"},
                                                    new Customer{FirstName = "clint", LastName = "eastwood"}};
            int index = 1;
            Customer expect = customers[index];

            //Act
            Customer actual = CollectionsSample.GetCustomer(customers, index);

            //Asserts
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        [ExpectedException(typeof (IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutOfRangeException() {
            //Arrange
            Customer[] customers = new Customer[2] {new Customer{FirstName = "jhon", LastName = "macleane"},
                                                    new Customer{FirstName = "clint", LastName = "eastwood"}};
            int index = 3;

            //Act
            CollectionsSample.GetCustomer(customers, index);
        }
    }
}
