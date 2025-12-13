using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClass
{
    internal class Car
    {
        // member variable
        private string _model = "";
        private string _brand = "";

        // property
        public string Model { get => _model; set => _model = value; }  // lambda expression
        public string Brand {
            get { 
                if (IsLuxury) 
                    return _brand + " - Luxury edition";
                return _brand; }
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                    _brand = value; }
            }

        public bool IsLuxury { get; set; }

        // Constructor
        public Car(string model, string brand, bool isLuxury = false)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"An Object of {Model} {Brand} Car has been created!");
            IsLuxury = isLuxury;
        }

        // Class method
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }
    }
}
