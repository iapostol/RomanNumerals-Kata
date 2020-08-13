using System.Collections.Generic;

namespace RomanNumerals_Kata
{
    public static class RomanConverter
    {
        private static readonly Dictionary<char, int> RomanToArabic = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private static readonly Dictionary<int, string> ArabicToRoman = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public static int ArabicFor(string roman)
        {
            var array = roman.ToCharArray();

            int arabic = 0;

            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                var symbol = array[currentIndex];

                int currentValue = RomanToArabic[symbol];

                int nextValue = (currentIndex + 1 < array.Length) ? RomanToArabic[array[currentIndex + 1]] : 0;

                if (currentValue < nextValue)
                    arabic -= currentValue;
                else
                    arabic += currentValue;
            }

            return arabic;
        }

        public static string RomanFor(int arabic)
        {
            var roman = string.Empty;

            foreach (var item in ArabicToRoman)
            {
                while (arabic >= item.Key)
                {
                    roman += item.Value;
                    arabic -= item.Key;
                }
            }

            return roman;
        }
    }
}
