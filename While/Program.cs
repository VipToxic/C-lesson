namespace While
{
    internal class Program
    {
        /*
          Цикл While
         */
        static void Main(string[] args)
        {
            /*
            while (true)
            {
                int count = 0;
                int count2 = 0;
                Console.Write("Введите начало диапазоно: ");
                string range = Console.ReadLine();
                Console.Write("Введите конец диапазоно: ");
                string end_range = Console.ReadLine();

                if (double.TryParse(range, out double rangeT) && double.TryParse(end_range, out double end_rangeT))
                {
                    if (end_rangeT < rangeT)
                    {
                        Console.WriteLine("Конечная число не может быть меньше начальной");
                        Console.WriteLine("завершаем операцию");
                        break;
                    }

                    while (rangeT <= end_rangeT)
                    {

                        Console.Write(rangeT + " ");
                        if (rangeT % 2 == 0)
                        {
                            count++;
                        }
                        else
                        {
                            count2++;
                        }
                        rangeT++;
                    }
                    Console.WriteLine("\nКоличество четных чисел: " + count);
                    Console.WriteLine("Количество нечетных чисел: " + count2);
                }
                else
                {
                    Console.WriteLine("Введите коректные данные!!!");
                }

            }
            */

            for (int i = 1; i < 10000; i++)
            {
                Console.WriteLine(i + 1);
            }


        }
    }
}
