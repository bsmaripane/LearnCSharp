using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    partial void OnJobAssigned();
}
