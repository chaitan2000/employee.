using System;

namespace EmployeeBusinessLayer
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }

        public Employee()
        {

        }

        public Employee(int EmployeeID,string fname,string lname,int age)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = fname;
            this.LastName = lname;
            this.age = age;
        }

    }
}
