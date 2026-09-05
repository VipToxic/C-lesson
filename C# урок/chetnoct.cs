namespace C__урок
{
    internal class chetnoct
    {
        
        public static bool IsStop(string st)
        {
            Console.Clear();
            return st == "стоп";
        }
        static void Main(string[] args)
        {
            
            //ConsoleKey consoleKey = Console.ReadKey().Key;

            while (true)
            {

                Console.Write("Введите первое число: ");
                string input1 = Console.ReadLine();
                Console.Write("Введите второе число: ");
                string input2 = Console.ReadLine();

                Console.Write("Выберите операцию (+, -, /, *, %) или \"стоп\" чтопы закончить работу: ");   
                string input3 = Console.ReadLine();
                if (IsStop(input3))
                {
                    Console.WriteLine("Завершаем операцию");
                    break;
                }

                if (double.TryParse(input1, out double input1_1) && double.TryParse(input2, out double input2_2))
                {
                    switch (input3)
                    {
                        case "+":
                            double summ = input1_1 + input2_2;
                            Console.WriteLine($"Результат {input1_1} + {input2_2}: {summ}");
                            break;
                        case "-":
                            double summ1 = input1_1 - input2_2;
                            Console.WriteLine($"Результат {input1_1} - {input2_2}: {summ1}");
                            break;
                        case "*":
                            double summ2 = input1_1 * input2_2;
                            Console.WriteLine($"Результат {input1_1} * {input2_2}: {summ2}");
                            break;
                        case "/":
                            if(input2_2 == 0)
                            {
                                Console.WriteLine($"{input1_1} невозможно делить на 0");
                                break;
                            }
                            double summ3 = input1_1 / input2_2;
                            Console.WriteLine($"Результат {input1_1} / {input2_2}: {summ3}");
                            break;
                        case "%":
                            if (input2_2 == 0)
                            {
                                Console.WriteLine("Нельзя получать остаток от деления на 0!");
                                break;
                            }
                            double summ4 = input1_1 % input2_2;
                            Console.WriteLine($"Результат {input1_1} % {input2_2}: {summ4}");
                            break;
                        default:
                            Console.WriteLine("Такой операции нет!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Введите коректные данные!!!");
                }
            }
            Console.WriteLine("Операция завершена!");
        }
    }
}