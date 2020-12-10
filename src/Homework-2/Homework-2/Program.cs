using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату чтобы узнать день недели: ");
            string date1 = Console.ReadLine();
            bool dateweek = DateTime.TryParse(date1, out DateTime date);
            if (dateweek)
            {
                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Неправильно введена дата.");
            }

            Console.ReadLine();
        }
    }
}