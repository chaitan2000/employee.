using EmployeeBusinessLayer;

using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL blObj = new EmployeeBL();
            IPayTax pObj = blObj;
            List<Employee> empList =  blObj.GetEmployeeData();

            try
            {
                foreach (Employee emp in empList)
                {
                    Console.Write(emp.EmployeeID.ToString() + " " + emp.FirstName + " " + emp.LastName + " " + emp.age.ToString());

                    Type empType = emp.GetType();

                    if (empType.Equals(typeof(ContractEmployee)))
                    {
                        ContractEmployee conEmp = (ContractEmployee)emp;
                        double sal = conEmp.CalculateSalary(15);
                        double tax = pObj.calcuateTax(sal);
                        Console.Write(" Contract Employee  " + sal);
                        Console.Write("  Tax to be paid " + tax);
                    }
                    else if (empType.Equals(typeof(PermanentEmployee)))
                    {
                        PermanentEmployee conEmp = (PermanentEmployee)emp;
                        double sal = conEmp.CalculateSalary(30);
                        double tax = pObj.calcuateTax(sal);
                        Console.Write(" Permanent Employee  " + sal);
                        Console.Write("  Tax to be paid  " + tax);
                    }

                    Console.WriteLine();


                }
                Console.WriteLine("Number of employees are : " + EmployeeDAL.employeeCount);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
