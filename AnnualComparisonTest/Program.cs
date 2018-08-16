using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualComparisonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week?");
            int hourWeekly = Convert.ToInt32(Console.ReadLine());
            int totalOne = hourlyRate * hourWeekly * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int hourlyRateTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work in a week?");
            int hourWeeklyTwo = Convert.ToInt32(Console.ReadLine());
            int totalTwo = hourlyRateTwo * hourWeeklyTwo * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(totalOne);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(totalTwo);

            bool compareOneTwo = totalOne > totalTwo;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(compareOneTwo);
            Console.Read();
        }
    }
}
