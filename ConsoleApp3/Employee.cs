using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Employee
    {
        #region Pascal and camelcase
        // pascal // camel case 

        // AhmedEbrahimElsayed pascal
        //camel ahmedEbrahim 
        #endregion
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public float GrossSalary { get; set; }

        public float Deduction { get; set; }
        public float SalaryTax { set; get; }

        public string? EmployeeType { set; get; }
        // manager  => 0.3 
        //Employee 0.1 
        // ContractEmployee
        //FreeLanceEmployee 
        //Officeboy
        // OCP (open for extension closed for modifaction .) => violate for this priciple

        public int Sum(int num1, int num2)
        {

            return num1 + num2;

        }


        public int Sum(int num1, int num2, int num3)
        {

            return num1 + num2;
        }

        public int Sum(int num1, int num2, float num3)
        {

            return num1 + num2 + (int) num3;
        }


        public int Sum(float num3,int num1, int num2)
        {

            return num1 + num2 + (int)num3;
        }

        // summary of overrloading 
        // mthod with the same name but have different signature

        // signature is number of parameters and the order of parameter and ty

        // 

        //public void Sum(int num1, int num2)
        //{


        //}


        public abstract float CalculateTotalSalary();

    }
}
