using Common;
using System;
using System.Linq;

namespace Tasks.Task3
{
    public class SolverTask3 : Task
    {
        public override void Solve()
        {
            Console.WriteLine("Введите предложение в одну строку");
            var sentence = Console.ReadLine();
            var words = sentence.Split();
            var sortedWords = (string[])words.Clone();

            // Количество слов
            var wordsCount = words.Length; 
            Console.WriteLine("Количество слов: {0}", wordsCount);

            // Отсортированные
            Array.Sort(sortedWords);
            Console.WriteLine("Отсортированные: {0}", string.Join(" ", sortedWords));

            // Первая буква заглавная
            words = words.Select(word => FirstLetterToUpper(word)).ToArray();
            Console.WriteLine("Заглавные буквы: {0}", string.Join(" ", words));
            return;
        }
        private string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
