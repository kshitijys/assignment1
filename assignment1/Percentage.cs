using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1

{ 
    internal class Percentage


    { 
            static void Main(string[] args)

            {
                Console.WriteLine("enter marks of physics");
                int physics = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter marks of chemistry");
                int chemistry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter marks of maths");
                int maths = Convert.ToInt32(Console.ReadLine());

                int totalmarks = physics + chemistry + maths;
                int percent = totalmarks * 100 / 300;

                if (percent > 80)
                {
                    Console.WriteLine("grade is A");
                }
                else if (percent >= 70)
                {
                    Console.WriteLine("grade is B");
                }
                else if (percent >= 60)
                {
                    Console.WriteLine("grade is C");
                }
                else
                {
                    Console.WriteLine("grade id D");
                }


            }
        }
    }


