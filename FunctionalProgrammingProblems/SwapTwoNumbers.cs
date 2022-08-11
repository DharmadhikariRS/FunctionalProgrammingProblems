using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class SwapTwoNumbers
    {
        internal void SwapNumbers()
        {
            Console.WriteLine("C# Program to Swap Two Numbers");
            Console.WriteLine("Enter value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = int.Parse(Console.ReadLine());
            (a, b) = SwapTwoNumbersfn(a, b);
            Console.WriteLine("value of a and b are: {0} {1} ", a, b);
        }
        private (int, int) SwapTwoNumbersfn(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            return (a, b);
        }
    }
}
