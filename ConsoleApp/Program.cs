using System;

namespace ConsoleApp
{
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year) {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}
