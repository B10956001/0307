using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int meal_cost_change = (int)meal_cost;
            int total = meal_cost_change + tip_percent + tax_percent;
            string total_cost = $"餐費總額為：{total}";
            Console.WriteLine(total_cost);
            Console.WriteLine(total_cost);
        }
    }
}
