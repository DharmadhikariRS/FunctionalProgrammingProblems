using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class HaronicFunctionProblem
    {
        public void Harmonicfunction()
        {
            float ResultHarmonic = 0;

            Console.WriteLine("Enter the number= ");
            int N = int.Parse(Console.ReadLine());
            while (N < 0)
            {
                Console.WriteLine("Enter the number greater than 0 ");
                N = int.Parse(Console.ReadLine());
            }


            for (float i = 1; i <= N; i++)
            {
                ResultHarmonic += 1 / i;
            }
            Console.WriteLine("Harmonic result is= " + ResultHarmonic);
        }
    }
}
