using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class Employee
{
    public string JobTitle {  get; set; }
    public double Salary { get; set; }
    partial void OnJobAssigned() => Console.WriteLine("A new Job has been assigned.");
    public void AssignJob(string jobTitle)
    {
        this.JobTitle = jobTitle;
        OnJobAssigned();
    }
}
