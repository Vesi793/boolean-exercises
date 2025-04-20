namespace CheckThe3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 18;
            int c = 12;

            bool result = (a > 20 && b <= 18) || (c > 10);

            Console.WriteLine(result);
        }
    }
}
