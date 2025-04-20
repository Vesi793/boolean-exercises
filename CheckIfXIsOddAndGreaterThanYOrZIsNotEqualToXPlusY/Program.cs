namespace CheckIfXIsOddAndGreaterThanYOrZIsNotEqualToXPlusY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 4;
            int z = 20;

            bool result = ((x % 2 != 0) && (x > y))
                || (z != (x = y));

            Console.WriteLine(result);
               
        }
    }
}
