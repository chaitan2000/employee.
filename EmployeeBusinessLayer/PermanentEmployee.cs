using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessLayer
{
   public class PermanentEmployee:Employee
    {
        public int noOfDays { get; set; }
        public PermanentEmployee(int ID, string fname, string lname, int age, int noOfDays)
            : base(ID, fname, lname, age)
        {
            this.noOfDays = noOfDays;
        }
        public double CalculateSalary(int noOfDays)
        {
            return noOfDays * 5000;
        }

    }
}
