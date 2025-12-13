using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructors
{
    internal class Customer
    {
        // Class property
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Class constructor
        public Customer()
        {
            Name = string.Empty;
            Address = string.Empty;
            ContactNumber = string.Empty;
        }
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            Name = name;
        }

        // Class methiod
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
