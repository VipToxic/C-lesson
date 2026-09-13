namespace Вложенные_циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            Console.WriteLine("--------------------");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <=5; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            */
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

        }
    }
}
