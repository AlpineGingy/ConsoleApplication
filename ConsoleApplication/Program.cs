using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("Where is your location: ");
            string location = Console.ReadLine();

            // 3.
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your location is {location}");

            // 4.
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate:D}");

            // 5.
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            TimeSpan daysUntilChristmas = christmas.Subtract(currentDate);
            Console.WriteLine($"Days until Christmas {daysUntilChristmas.Days}");

            // 6.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter a width ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();

            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // 7.
            Console.WriteLine("Enter any key to quit");
            Console.ReadKey();

        }
    }
}
