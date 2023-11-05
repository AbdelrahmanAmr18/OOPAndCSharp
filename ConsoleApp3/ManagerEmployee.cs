using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ManagerEmployee : Employee
    {
        public override float CalculateTotalSalary()
        {
            return (float)(GrossSalary + GrossSalary * 0.3 - SalaryTax);
        }
    }
}
