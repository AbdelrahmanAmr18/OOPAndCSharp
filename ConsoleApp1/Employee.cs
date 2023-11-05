using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        //private int id;
        private float salary;
        //private string? name;
        //public int Id
        //{
        //    set { id = value; }
        //    get { return id; }
        //}
        public float Salary {
            set { salary = value>0?value:0; } 
            get { return salary; }
        }

        //public string? Name
        //{
        //    set { name = value; }
        //    get { return name; }
        //}

        // automatic property 

        public int Id { get; set; }
        public string? Name { get; set; }


        private void DoSomeThing()
        {
            Console.WriteLine("Do Some Thing");
        }


        public string Message()
        {
            DoSomeThing();
            return "";
        }

        protected internal void Message2()
        {
            Console.WriteLine("this is message from Message2 and it's protected");
        }
    }
}
