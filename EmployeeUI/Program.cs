using System;
using EmployeeBusinessLayer;

namespace EmployeeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Maintatinence\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Empoyee ID : ");
            int employeeID  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
         


            Console.WriteLine("Choose the type of the car");

            Console.WriteLine("\t1 - Contract Employee");
            Console.WriteLine("\t2 - Permanenet Employee");

            Console.Write("Your option? ");
            IPayTax pObj = new EmployeeBL();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("No of Hours of working : ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    ContractEmployee conEmp = new ContractEmployee(employeeID, firstName, lastName, age, hours);
                    double sal = conEmp.CalculateSalary(15);
                    double tax = pObj.calcuateTax(sal);
                    Console.WriteLine(" Contract Employee  " + sal);
                    Console.WriteLine("  Tax to be paid " + tax);

                    break;
                case "2":
                    Console.WriteLine("No of days of working : ");
                    int days = Convert.ToInt32(Console.ReadLine());
                    PermanentEmployee pemp = new PermanentEmployee(employeeID, firstName, lastName, age, days);
                    double psal = pemp.CalculateSalary(15);
                    double ptax = pObj.calcuateTax(psal);
                    Console.WriteLine(" Contract Employee  " + psal);
                    Console.WriteLine("  Tax to be paid " + ptax);


                    break;
                default:

                    break;
            }
        }
    }
}
