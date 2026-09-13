namespace Курсор_триугольник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("------ПЕРВЫЙ МЕТОД------");
            Console.Write("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("------ВТОРОЙ МЕТОД------");
            Console.Write("Введите высоту: ");
            int height_1 = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= height_1; i++)
            {
                Console.SetCursorPosition(height_1 - i, i + 1);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            



        }
    }
}
