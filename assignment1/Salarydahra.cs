using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Salarydahra
    {
        static void Main(string[] args)
        {
            int HRA, DA ;
            Console.WriteLine("enter basic salary");
            int salary=Convert.ToInt32(Console.ReadLine()); 

            if(salary<=10000)
            {
                DA = salary * 80 / 100;
                HRA=salary * 20 / 100;
            }
            else if(salary<=20000)
            {
                DA = salary *  90 / 100;
                HRA = salary * 35 / 100;
            }
            else
            {
                DA = salary * 95 / 100;
                HRA = salary * 40 / 100;

                int gross = salary + DA + HRA;
                Console.WriteLine($"gross salary is {gross}rs");
            }
        }
    }
}
