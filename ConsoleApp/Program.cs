using System;

namespace ConsoleApp
{
    public class Program {
        public static void Main(string[] args) {
            while (true) {
                try
                {
                    var userInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Number.IsLeapYear(userInput) ? "yay" : "nay");
                }
                catch (FormatException) { Console.WriteLine("Input must be Formatted as a 32bit Integer!"); }
            }
        }
    }
}
