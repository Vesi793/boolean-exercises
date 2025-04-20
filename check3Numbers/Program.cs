namespace check3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 15;
            int z = 10;

            bool result = x > 15 && y < 20 || z == 10;

            Console.WriteLine(result);
        }
    }
}
