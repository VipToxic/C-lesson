namespace Цикл_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3; // 9
            double s = 0; // 4

            while (x < 20)
            {
                x += 2;
                if (x % 5 == 0)
                {
                    continue;
                }
                s += x % 4;
            }
            Console.WriteLine(s);
        }
    }
}