namespace Цикл_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Подсчет суммы от 1 до 10
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Сумма: " + sum);

            // узнать четное или не четное
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Значение {i} четное");
                }
                else
                {
                    Console.WriteLine($"Значение {i} нечетное");
                }
            }

            // Сколько не четных и четных

            int even = 0;
            int odd = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"Четных чисел: {even}");
            Console.WriteLine($"Не четных чисел: {odd}");


            // обратный цикл
            int i10 = int.Parse(Console.ReadLine());
            for (; i10 >= 0; i10--)
            {
                Console.WriteLine(i10);
            }

        }
    }
}