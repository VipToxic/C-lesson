namespace Тернарный_оператор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Унарный оператор
            int a = 0;
            a++; // если операдна одинь

            // Бинарный
            int b = 1;
            int c = 2;
            int d = b + c; // Если операторов две 

            // Тернарный оператор

            Console.Write("Введите число: ");
            int output = int.Parse(Console.ReadLine());


            // Как в if else мы проверяем данные на true и false 
            // после знака ? идет как бы что вернуть 0 если данные равны true и то же число
            // если данные false
            int input = (output < 0) ? 0 : output;

            Console.WriteLine(input);

        }
    }
}
