namespace CombinationOrAndAndWith_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 25;
            int c = 40;

            bool result = (a > 20 && a < 50) ||
                (b > 30 && b < 40) || (c == 40);

            Console.WriteLine(result);
        }
    }
}
