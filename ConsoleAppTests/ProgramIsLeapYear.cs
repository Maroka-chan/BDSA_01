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
        public void Year_Is_LeapYear(int year) {
            // Assert
            Assert.True(ConsoleApp.Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(25)]
        [InlineData(100)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void Year_Is_Not_LeapYear(int year) {
            // Assert
            Assert.False(ConsoleApp.Program.IsLeapYear(year));
        }
    }
}
