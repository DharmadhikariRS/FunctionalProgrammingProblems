using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    internal class PrimeFactors
    {
        public void PrimeFactorsFn()
        {
            Console.WriteLine("Enter Number");
            int N = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("prime factor of " + N);
            for (i = 1; i <= N / 2; i++)
            {

                int count = 0;

                if (N % i == 0)
                {
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
