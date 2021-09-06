using System;
using ConsoleApp;
using Xunit;

namespace ConsoleAppTests
{
    public class ProgramIsLeapYear {
        [Theory]
        [InlineData(1584)]
        [InlineData(1600)]
        [InlineData(1832)]
        [InlineData(2000)]
        [InlineData(3284)]
        public void IsLeapYear_GivenLeapYear_ReturnsTrue(int year) {
            // Assert
            Assert.True(Number.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1582)]
        [InlineData(1689)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsLeapYear_GivenNonLeapYear_ReturnsFalse(int year) {
            // Assert
            Assert.False(Number.IsLeapYear(year));
        }
        
        [Theory]
        [InlineData(1581)]
        [InlineData(0)]
        [InlineData(-89)]
        [InlineData(1473)]
        [InlineData(3)]
        public void IsLeapYear_GivenYearBelow1582_ThrowsArgumentOutOfRangeException(int year) {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Number.IsLeapYear(year));
        }
    }
}
