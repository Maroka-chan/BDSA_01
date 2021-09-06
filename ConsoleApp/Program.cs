using System;

namespace ConsoleApp
{
    public class Program {
        public static void Main(string[] args) {
            while (true) {
                var userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Number.IsLeapYear(userInput) ? "yay" : "nay");
            }
        }
    }
}
