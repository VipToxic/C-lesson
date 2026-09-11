namespace цикл_for_парктика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // практика 1
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (i == 37)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Цикл завершен");

            // практика 2[
            int pluscount = 0;

           for (int i = 0 ; i < 5; i++)
            {
                Console.Write("Введите число: ");
                string number = Console.ReadLine();
                if (int.TryParse(number, out int number_1))
                {
                    if (number_1 == 0)
                    {
                        Console.WriteLine("Операция завершена!");
                        break;
                    }

                    if (number_1 < 0)
                    {
                        continue;
                    }
                    if (number_1 > 0)
                    {
                        pluscount++;
                    }
                }
                else
                {
                    Console.WriteLine("Введите коректные данные!");
                }

            }
            Console.WriteLine("Положительных чисел: " + pluscount);

        }
    }
}
