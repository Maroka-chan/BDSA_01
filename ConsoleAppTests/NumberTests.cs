using ConsoleApp;
using Xunit;

namespace ConsoleAppTests
{
    public class ProgramIsLeapYear {
        [Theory]
        [InlineData(4)]
        [InlineData(12)]
        [InlineData(400)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsLeapYear_GivenLeapYear_ReturnsTrue(int year) {
            // Assert
            Assert.True(Number.IsLeapYear(year));
        }

        [Theory]
        [InlineData(25)]
        [InlineData(100)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsLeapYear_GivenNonLeapYear_ReturnsFalse(int year) {
            // Assert
            Assert.False(Number.IsLeapYear(year));
        }
    }
}
