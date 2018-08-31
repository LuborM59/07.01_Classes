using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_Classes
{
    class Program
    {
        class Employeee
        // struct Employeee
        {
            public string fName;
            public string lName;
            public decimal Plat;

            public decimal getPlat();
            {
                return this.Plat ;
            
            }
    }
        static void Main(string[] args)
        {
            Employeee employee1;

            // create new instance - object
            employee1 = new Employeee();

            employee1.fName = "Lubor";
            employee1.lName = "Martinsky";

            Console.WriteLine("FName : = {0}, LName: = {1}", employee1.fName, employee1.lName);
            Console.WriteLine();

            
        }
    }
}
