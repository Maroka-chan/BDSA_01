using System;
using ConsoleApp;
using Xunit;

namespace ConsoleAppTests {
    public class ConsoleOutputTests {
        [Theory]
        [InlineData(int.MaxValue + 1L)]
        [InlineData(int.MinValue - 1L)]
        public void WriteIsLeapYear_ExceedIntegerLimit_ThrowsOverflowException(long year) {
            // Assert
            Assert.Throws<OverflowException>(() => 
                ConsoleOutput.WriteIsLeapYear(Convert.ToString(year)));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("- *")]
        [InlineData("NonIntegerFormat")]
        public void WriteIsLeapYear_GivenNonIntegerFormat_ThrowsFormatException(string year) {
            // Assert
            Assert.Throws<FormatException>(() => 
                ConsoleOutput.WriteIsLeapYear(year));
        }
    }
}