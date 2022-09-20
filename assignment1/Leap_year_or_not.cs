using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Leap_year_or_not
    {

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter a year");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine($"entered year {year} is a leap year");


                        }
                        else
                        {
                            Console.WriteLine($"entered year {year} is not a leap year ");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"entered year {year} is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine($"entered year {year} is not a leap year");
                }
            }
        }
    } 
}









            
                   
                

            
        