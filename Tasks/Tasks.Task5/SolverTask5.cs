using Common;
using System;
using System.Linq;

namespace Tasks.Task5
{
    public class SolverTask5 : Task
    {
        public override void Solve()
        {
            Console.Write("Введите число от 1 до 100: ");
            var stringNumber = Console.ReadLine();
            int number;

            if (!int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("Ошибся, но не расстраивайся. Держи краба (V).^_^.(V)");
                return;
            }

            if (!(number >= 1 && number <= 100))
            {
                Console.WriteLine("От 1 до 100");
                return;
            }

            var palindroms = Enumerable.Range(0, number + 1).Where(num => CheckPalindrom(num)).ToArray();
            Console.WriteLine("Числа-палиндромы\n{0}", string.Join("\n", palindroms));
            return;
        }

        private bool CheckPalindrom(int number)
        {
            var stringNumber = number.ToString();
            var reverseStrigNumber = new string(stringNumber.Reverse().ToArray());
            return stringNumber == reverseStrigNumber;
        }
    }
}
