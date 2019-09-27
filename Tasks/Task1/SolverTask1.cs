using Common;
using System;
using System.Linq;

namespace Tasks.Task1
{
    public class SolverTask1 : Task
    {
        public override void Solve()
        {
            Console.Write("Введите целое число: ");
            var stringNumber = Console.ReadLine();

            int number;
            // TryParse - Попытка парсинга числа.
            // Если строка - валидное целое число, вернёт true, а в number
            // запишется это число.
            // Иначе - вернёт false, number останется без изменений
            if (!int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("Все мы ошибаемся, и ты сейчас ошибся...");
                return;
            }
            
            if (number % 2 == 0)            
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");

            if (number < 2)
            {
                Console.WriteLine("Число не является ни простым, ни составным");
                return;
            }

            var delimitersCount = Enumerable.Range(1, number)
                .Where(delimiter => number % delimiter == 0).Count();

            if (delimitersCount == 2)
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число составное");

            return;
        }
    }
}
