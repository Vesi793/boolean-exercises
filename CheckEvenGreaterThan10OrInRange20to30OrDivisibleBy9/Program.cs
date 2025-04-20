namespace CheckEvenGreaterThan10OrInRange20to30OrDivisibleBy9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 28;
            int c = 18;

            bool result = ((a % 2 == 0) &&
                (a > 10)) || ((b < 30) && (b > 20))
            || (c % 9 == 0);

            Console.WriteLine(result);
        }
    }
}
