using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Tasks.Task6
{
    public class SolverTask6 : Task
    {
        public override void Solve()
        {
            Console.Write("Введите грузоподъемность авоськи: ");
            var stringNumber = Console.ReadLine();

            int mas;

            if (!int.TryParse(stringNumber, out mas))
            {
                Console.WriteLine("Все мы ошибаемся, и ты сейчас ошибся...");
                return;
            }

            Console.WriteLine("Введите через пробел веса предметов, которые мы можем туда положить: ");
            var stringWeights = Console.ReadLine().Split();
            var weights = stringWeights.Select(str => int.Parse(str)).ToArray();

            Console.WriteLine("Введите через пробел цены предметов, которые мы можем туда положить: ");
            var stringCosts = Console.ReadLine().Split();
            var costs = stringCosts.Select(str => int.Parse(str)).ToArray();

            var maxTotal = Knapsack(weights, costs, mas);
            Console.WriteLine("Максимальая стоимость: {0}", maxTotal);
        }

        private int Knapsack(int[] weights, int[] costs, int needed)
        {
            int n = weights.Length;
            int[,] dp = new int[needed + 1, n + 1];
            for (int j = 1; j <= n; j++)
            {
                for (int w = 1; w <= needed; w++)
                {
                    if (weights[j - 1] <= w)
                    {
                        dp[w, j] = Math.Max(dp[w, j - 1], dp[w - weights[j - 1], j - 1] + costs[j - 1]);
                    }
                    else
                    {
                        dp[w, j] = dp[w, j - 1];
                    }
                }
            }
            return dp[needed, n];
        }
    }
}
