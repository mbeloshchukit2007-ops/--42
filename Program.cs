using System;

namespace Lab42Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Перевірка коректності введення цілих чисел (Обробка винятків) ---\n");

            bool success = false;
            int parsedValue = 0;

            while (!success)
            {
                Console.Write("Введіть ціле число: ");
                string? userInput = Console.ReadLine();

                try
                {
                    parsedValue = Int32.Parse(userInput!);
                    success = true;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("[Помилка]: Введено порожній рядок (null). Спробуйте ще раз.\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("[Помилка]: Введене значення не є цілим числом. Спробуйте ще раз.\n");
                }
                catch (OverflowException) when (userInput != null && userInput.Trim().StartsWith("-"))
                {
                    Console.WriteLine("[Помилка]: Число менше за мінімально можливе для типу Int32 (-2 147 483 648). Спробуйте ще раз.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("[Помилка]: Число більше за максимально можливе для типу Int32 (2 147 483 647). Спробуйте ще раз.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Невідома помилка]: {ex.Message}. Спробуйте ще раз.\n");
                }
                finally
                {
                    Console.WriteLine("-> [finally]: Спробу введення опрацьовано.");
                }
            }

            Console.WriteLine($"\nРезультат: Успішно введено число {parsedValue}");
        }
    }
}
