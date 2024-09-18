using System;
using System.Diagnostics;
using System.Net;

namespace FindTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int attempts = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Введите уровень сложности:" + "\n" +
                    "1 - Легкий \t (20 попыток)" + "\n" +
                    "2 - Средний \t (10 попыток)" + "\n" +
                    "3 - Сложный \t (5 попыток)");

                int level = Convert.ToInt32(Console.ReadLine());

                switch (level)
                {
                    case 1:
                        attempts = 20;
                        validInput = true; // Завершаем цикл после правильного выбора
                        break;
                    case 2:
                        attempts = 10;
                        validInput = true; // Завершаем цикл после правильного выбора
                        break;
                    case 3:
                        attempts = 5;
                        validInput = true; // Завершаем цикл после правильного выбора
                        break;
                    default:
                        Console.WriteLine("Неправильное значение. Повторите ввод:");
                        break; // Цикл продолжается
                }
            }

            Console.WriteLine($"Вы выбрали уровень сложности. У вас {attempts} попыток.");

            // Correct the swap logic if needed
            if (b < a)
            {
                (a, b) = (b, a);
            }

            // Generate a random number between a and b
            Random random = new Random();
            int answer = random.Next(a, b + 1);

            int counter = 0;

            bool correctGuess = false;

            while (attempts > 0 && !correctGuess)
            {
                Console.WriteLine($"Угадайте число от {a} до {b}: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > answer)
                {
                    Console.WriteLine("Нужно меньше.");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Нужно больше.");
                }
                else
                {
                    Console.WriteLine("Ваш ответ верен! Поздравляем!");
                    correctGuess = true;  // Число угадано
                    break;  // Выходим из цикла
                }

                attempts--;  // Уменьшаем количество оставшихся попыток

                // Если попытки исчерпаны и число не угадано
                if (attempts == 0 && !correctGuess)
                {
                    Console.WriteLine("Число не было найдено. Попытки исчерпаны.");
                }
            }

            // Завершение программы
            Console.WriteLine("Нажмите любую клавишу для завершения программы.");
            Console.ReadKey();

        }
    }
}
