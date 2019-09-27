using Common;
using System;
using System.Linq;

namespace Tasks.Task4
{
    public class SolverTask4 : Task
    {
        public override void Solve()
        {
            Console.WriteLine("Введите предложение в одну строку");
            var sentence = Console.ReadLine().ToLower();
            var words = sentence.Split();

            Console.Write("Введите раздражающее слово в тексте: ");
            var angryWord = Console.ReadLine().ToLower();
            
            var foundCount = words.Where(word => word.Trim(new char[] { ' ', '.', ',', '\\', '/' }) == angryWord).Count();           
            
            Console.WriteLine("Это слово раздражает вас {0} раз", foundCount);
            return;
        }
    }
}
