using System;

namespace ConsoleApp {
    public static class ConsoleOutput {
        public static void WriteIsLeapYear(string year) {
            var userInput = Convert.ToInt32(year);
            Console.WriteLine(Number.IsLeapYear(userInput) ? "yay" : "nay");
        }
    }
}