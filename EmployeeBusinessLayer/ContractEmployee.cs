using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessLayer
{
   public class ContractEmployee : Employee
    {
        public ContractEmployee():base()
        {

        }
        public int noOfHours { get; set; }
        public ContractEmployee(int ID,string fname,string lname,int age,int noOfHours)
            : base(ID, fname, lname, age)
        {
            this.noOfHours = noOfHours;
        }

        public double CalculateSalary(int noOfHours)
        {
            return noOfHours * 10000;
        }
    }
}
