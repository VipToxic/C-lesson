namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            do
            {
                count--;

                Console.WriteLine(count);
                count++;
               
            }
            while (count != 5);
        }
    }
}
