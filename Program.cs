using System;

namespace Lab42Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть ціле число: ");
            string? userInput = Console.ReadLine();

            try
            {
                int val = Int32.Parse(userInput!);
                Console.WriteLine($"Успішно прочитано: {val}");
            }
            catch (FormatException)
            {
                Console.WriteLine("[Помилка формату]: Введене значення не є цілим числом!");
            }
        }
    }
}
