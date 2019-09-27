using Common;
using System;

namespace Tasks.Task2
{
    public class SolverTask2 : Task
    {
        public override void Solve()
        {
            Console.Write("Введите 2 числа через пробел: ");
            var stringOfNumbers = Console.ReadLine();
            var stringNumbers = stringOfNumbers.Split(); //stringNumbers = string[2]

            int a, b;
            // TryParse - Попытка парсинга числа.
            // Если строка - валидное целое число, вернёт true, а в number
            // запишется это число.
            // Иначе - вернёт false, number останется без изменений
            if (!int.TryParse(stringNumbers[0], out a))
            {
                Console.WriteLine("Ты ошибся, но... Здесь могла быть ваша реклама");
                return;
            }

            if (!int.TryParse(stringNumbers[1], out b))
            {
                Console.WriteLine("Ты ошибся, но... Здесь могла быть ваша реклама");
                return;
            }

            if (a < 0 || b < 0)
            {
                Console.WriteLine("Отрицательные числа как отрицательные персонажи - не всегда к месту");
                return;
            }

            var gcd = GCD(a, b);
            var lcm = LCM(a, b);

            Console.WriteLine("НОК: {0}", lcm);
            Console.WriteLine("НОД: {0}", gcd);

            return;
        }

        private int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }

        private int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
    }
}
