using Common;
using System;
using System.Collections.Generic;
using Tasks.Task1;
using Tasks.Task2;
using Tasks.Task3;
using Tasks.Task4;
using Tasks.Task5;
using Tasks.Task6;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();
            tasks.Add(new SolverTask1());
            tasks.Add(new SolverTask2());
            tasks.Add(new SolverTask3());
            tasks.Add(new SolverTask4());
            tasks.Add(new SolverTask5());
            tasks.Add(new SolverTask6());

            while (true)
            {
                Console.WriteLine("Выберите задание");
                Console.WriteLine("1. Чет/нечет, простое/составное");
                Console.WriteLine("2. НОК, НОД");
                Console.WriteLine("3. Предложение, слова");
                Console.WriteLine("4. Поиска слова в тексте");
                Console.WriteLine("5. Палиндромы");
                Console.WriteLine("6. Рюкзак");
                Console.WriteLine();
                Console.WriteLine("0. Выход");
                Console.WriteLine("-------------------------");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                    continue;

                if (choice == 0)
                    break;

                if (choice > tasks.Count)
                    continue;

                var task = tasks[choice - 1];

                task.Solve();
                Console.WriteLine("=========================");
            }
        }        
    }
}
