using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestExample {
    public class Customer {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
    public class CollectionsSample {
        public static Customer GetCustomer(Customer[] customers, int index) {
            return customers[index];
        }
    }
}
