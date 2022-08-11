namespace FunctionalProgrammingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your selection from below");
            Console.WriteLine("1. Flip Coin Percentage prorram");
            Console.WriteLine("2 Leap year ");
            Console.WriteLine("3. Power of Two");
            Console.WriteLine("4. Harmonic Number");
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
                case 4:
                    HaronicFunctionProblem haronicFunctionProblem= new HaronicFunctionProblem();
                    haronicFunctionProblem.Harmonicfunction();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
        }
    }
}