
using System;
using System.Collections.Generic;

namespace EmployeeBusinessLayer
{
    public class EmployeeDAL
    {
        public static int employeeCount = 0;
        public List<Employee> GetEmployeeData()
        {
            try
            {
                ContractEmployee empObj1 = new ContractEmployee(1001, "John ", "Brown", 35, 15);
                ContractEmployee empObj2 = new ContractEmployee(1002, "Will", "Smith", 38, 30);
                PermanentEmployee empObj3 = new PermanentEmployee(1003, "Jack", "Miller", 53, 30);
                PermanentEmployee empObj4 = new PermanentEmployee(1004, "Tom", "Thomas", 70, 30);
                PermanentEmployee empObj5 = new PermanentEmployee(1005, "David ", "Brown", 8, 30);

                List<Employee> empList = new List<Employee>();
                empList.Add(empObj1); employeeCount++;
                empList.Add(empObj2); employeeCount++;
                empList.Add(empObj3); employeeCount++;
                empList.Add(empObj4); employeeCount++;
                empList.Add(empObj5); employeeCount++;

                return empList;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
