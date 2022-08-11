namespace FunctionalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your selection from below");
            Console.WriteLine("1. Flip Coin Percentage prorram");
            Console.WriteLine("3. Power of Two");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    FlipCoinPercentProgram flipCoinPercentProgram = new FlipCoinPercentProgram();
                    flipCoinPercentProgram.FlipCoinPercentage();
                    Console.WriteLine();
                    break;
                case 2:
                    LeapYearProgram leapYearProgram = new LeapYearProgram();
                    leapYearProgram.LeapYear();
                    Console.WriteLine();
                    break;
                case 3:
                    PowersOfTwo powersOfTwo=new PowersOfTwo();
                    powersOfTwo.PowerOfTwo();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
        }
    }
}