using System;

namespace ConsoleApp
{
    public class Program {
        public static void Main(string[] args) {
            while (true)
            {
                try { ConsoleOutput.WriteIsLeapYear(Console.ReadLine()); }
                catch (FormatException) { Console.Error.WriteLine("Input must be Formatted as a 32bit Integer!"); }
                catch (OverflowException e) { Console.Error.WriteLine(e.Message); }
            }
        }
    }
}
