using Xunit;

using static RomanNumerals_Kata.RomanConverter;

namespace RomanNumerals_Kata
{
    public class RomanConverterShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(1981, "MCMLXXXI")]
        [InlineData(3724, "MMMDCCXXIV")]
        public void Convert_Arabic_For_Given_Roman(int arabic, string roman)
        {
            Assert.Equal(arabic, ArabicFor(roman));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("MCMLXXXI", 1981)]
        [InlineData("MMMDCCXXIV", 3724)]
        public void Convert_Roman_For_Given_Arabic(string roman, int arabic)
        {
            Assert.Equal(roman, RomanFor(arabic));
        }
    }
}