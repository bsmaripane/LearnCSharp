using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructors
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        //Readonly instance field initialised from the constructor
        private readonly int _id;

        // Read only property
        public int Id { get { return _id; } }

        // Class property
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Class constructor
        public Customer()
        {
            _id = nextId++;
            Name = string.Empty;
            Address = string.Empty;
            ContactNumber = string.Empty;
        }
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            _id = nextId++;
            Name = name;
            Address = "N/A";
            ContactNumber = "N/A";
        }

        // Class methiod
        public void SetDetails(string name, string address, string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"\nCustomer details\nID: {Id}\nName: {Name}\nAddress: {Address}\nContact: {ContactNumber}");
        }
    }
}
