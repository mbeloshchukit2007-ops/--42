using System;

namespace Lab42Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть число: ");
            string? userInput = Console.ReadLine();
            int number = Int32.Parse(userInput!);
            Console.WriteLine($"Отримано число: {number}");
        }
    }
}
