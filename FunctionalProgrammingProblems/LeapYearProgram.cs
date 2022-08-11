using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class LeapYearProgram
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter the Year= ");
            float Year = float.Parse(Console.ReadLine());
            while (Year < 1000 && Year > 9999)
            {
                Console.WriteLine("Enter 4 digit Year= ");
                Year = float.Parse(Console.ReadLine());

            }

            if (Year % 100 == 0)
            {
                if (Year % 400 == 0)
                {
                    Console.WriteLine("{0} is Leap Year", Year);
                }
                else
                {
                    Console.WriteLine("{0} is Not Leap Year", Year);
                }
            }
            else if (Year % 4 == 0)
            {
                Console.WriteLine("{0} is  Leap Year", Year);
            }
            else
            {
                Console.WriteLine("{0} is Not Year", Year);

            }
        }
    }

}
