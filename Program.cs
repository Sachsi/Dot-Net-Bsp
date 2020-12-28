using System;
using Humanizer;

namespace Dot_Net_Bsp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantities");
            HumanizeQutites();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }

        static void HumanizeQutites()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }
        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}
