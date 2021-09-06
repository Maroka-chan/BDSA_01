using System;

namespace ConsoleApp {
    public static class Number {
        public static bool IsLeapYear(int year) {
            if (year < 1582) throw new ArgumentOutOfRangeException($"Year must be larger than 1581!");
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}