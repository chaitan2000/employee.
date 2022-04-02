
using System;
using System.Collections.Generic;

namespace EmployeeBusinessLayer
{
    public class EmployeeBL:IPayTax
    {
        
        public List<Employee> GetEmployeeData()
        {
            try
            {
                EmployeeDAL dalObj = new EmployeeDAL();
                List<Employee> empList = dalObj.GetEmployeeData();
                return empList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }



         double IPayTax.calcuateTax(double amount)
        {
            try
            {
                amount = amount * 12;
                if (amount < 250000)
                {
                    return 0.00;
                }
                else if (amount > 250001 && amount < 500000)
                {
                    return 0.05 * amount;
                }
                else if (amount > 500001 && amount < 750000)
                {
                    return 0.1 * amount;
                }
                else
                {
                    return 0.2 * amount;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
