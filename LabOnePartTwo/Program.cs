using System;

namespace LabOnePartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user to input numbers and convert to DateTime Format
            Console.WriteLine("Please enter a date in the format mm/dd/yyyy");
            DateTime DateOne = Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Please enter another date in the format mm/dd/yyyy");
            DateTime DateTwo = Convert.ToDateTime(Console.ReadLine()).Date;


            //Calculate the times based on difference in days
            TimeSpan Difference = DateOne.Subtract(DateTwo);

            float DifferenceYears = Difference.Days / 365;

            float DifferenceMonths = DifferenceYears * 12;

            float DifferenceHours = Difference.Days * 24;

            float DifferenceMinutes = DifferenceHours * 60;


            //Display the previous calculations
            Console.WriteLine("The Difference between the dates is:");
            Console.WriteLine("Years:" + DifferenceYears);
            Console.WriteLine("Months:" + DifferenceMonths);
            Console.WriteLine("Days:" + Difference.Days);
            Console.WriteLine("Hours:" + DifferenceHours);
            Console.WriteLine("Seconds:" + DifferenceMinutes);

        }
    }
}