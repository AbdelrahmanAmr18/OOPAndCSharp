using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContractEmployee:Employee
    {
        public override float CalculateTotalSalary()
        {
            return (float)(GrossSalary - Deduction + (GrossSalary * 0.1) - SalaryTax);
        }
    }
}
