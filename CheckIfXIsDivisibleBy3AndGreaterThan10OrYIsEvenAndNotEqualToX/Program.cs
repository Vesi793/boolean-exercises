namespace CheckIfXIsDivisibleBy3AndGreaterThan10OrYIsEvenAndNotEqualToX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 8;

            bool result = ((x % 3 == 0) && (x > 10))
                || ((y % 2 == 0) && (y != x));

            Console.WriteLine(result);
        }
    }
}
