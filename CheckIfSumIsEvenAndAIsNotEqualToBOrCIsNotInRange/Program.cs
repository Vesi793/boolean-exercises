namespace CheckIfSumIsEvenAndAIsNotEqualToBOrCIsNotInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 4;
            int c = 7;
            int d = -1;

            bool range = (a > 10 && a < 20)
            || (b % 2 == 0);

            bool result = !(c % 2 == 0) || (d < 0);

            Console.WriteLine(result);
            


        }

    }
}
