namespace While
{
    internal class Program
    {
        /*
          Цикл While
         */
        static void Main(string[] args)
        {

            // для того чтобы не заканчивался итерация
            while (true)
            {
                // обьявление переменных и запрос на ввод чисел
                int count = 0;
                int count2 = 0;
                double sum;
                double coun;
                Console.Write("Введите начало диапазоно: ");
                string range = Console.ReadLine();
                Console.Write("Введите конец диапазоно: ");
                string end_range = Console.ReadLine();

                // Конвертация чисел
                if (double.TryParse(range, out double rangeT) && double.TryParse(end_range, out double end_rangeT))
                {
                    coun = (end_rangeT - rangeT) + 1; // подсчет количиства чисел
                    sum = ((rangeT + end_rangeT) * coun) / 2; // подсчет суммы по формуле
                    double oddSum = 0;
                    double evenSum = 0;

                    // тут проверка чисел тоесть их правильный порядок
                    if (end_rangeT < rangeT)
                    {
                        Console.WriteLine("Конечная число не может быть меньше начальной");
                        Console.WriteLine("завершаем операцию");
                        break;
                    }

                    // Сам процесс подсчета
                    while (rangeT <= end_rangeT)
                    {
                        // С начала выводим число что у нас есть
                        Console.Write(rangeT + " ");

                        // Проверяем на четность
                        if (rangeT % 2 == 0)
                        {
                            count++; //  если четный + четная число
                            oddSum = oddSum + rangeT;
                        }
                        else
                        {
                            count2++; // если нет то + не четная число
                            evenSum = evenSum + rangeT;
                        }

                        // После чего плюсуем к начальному числу + 1
                        // чтобы проверить следуюшее число в диапазоне
                        rangeT++;
                        
                        
                    }

                    // Вывод полученых данных
                    Console.WriteLine("\nКоличество четных чисел: " + count);
                    Console.WriteLine("Количество нечетных чисел: " + count2);
                    Console.WriteLine("Сумма чисел равен к " + sum);
                    Console.WriteLine("Сумма четных чисел: " + oddSum);
                    Console.WriteLine("Сумма нечетных чисел: " + evenSum);
                }
                else
                {
                    // если вводимые данные не коректные то выводиться это сообщения
                    Console.WriteLine("Введите коректные данные!");
                }

            }
            

            


        }
    }
}
