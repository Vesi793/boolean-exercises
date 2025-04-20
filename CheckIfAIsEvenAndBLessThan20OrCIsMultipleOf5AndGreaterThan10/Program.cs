namespace CheckIfAIsEvenAndBLessThan20OrCIsMultipleOf5AndGreaterThan10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 18;
            int c = 25;

            bool result = ((a % 2 == 0) && (b < 20))
            || ((c % 5 == 0) && (c > 10));

            Console.WriteLine(result);
        }
    }
}
