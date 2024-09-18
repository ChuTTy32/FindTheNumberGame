using System;

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

            // Correct the swap logic if needed
            if (b < a)
            {
                (a, b) = (b, a);
            }

            // Generate a random number between a and b
            Random random = new Random();
            int answer = random.Next(a, b + 1);

            bool correctGuess = false;

            while (!correctGuess)
            {
                Console.WriteLine($"Угадайте число от {a} до {b}: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > answer)
                {
                    Console.WriteLine("Ваше число больше загаданного.");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Ваше число меньше загаданного.");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число.");
                    correctGuess = true;
                }
            }
        }
    }
}
