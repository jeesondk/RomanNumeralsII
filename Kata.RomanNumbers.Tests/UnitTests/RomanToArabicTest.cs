using Kata.RomanNumbers.Logic;
using NUnit.Framework;

namespace Kata.RomanNumbers.Tests.UnitTests
{
    [TestFixture]
    public class RomanToArabicTest
    {
        private RomanToArabic romanConverter;

        [SetUp]
        public void SetUp()
        {
            romanConverter = new RomanToArabic();
        }

        [TearDown]
        public void TearDown()
        {
            romanConverter.Dispose();
        }
        [TestCase("I", ExpectedResult = 1)]
        [TestCase("II", ExpectedResult = 2)]
        [TestCase("III", ExpectedResult = 3)]
        [TestCase("IV", ExpectedResult = 4)]
        [TestCase("V", ExpectedResult = 5)]
        [TestCase("VI", ExpectedResult = 6)]
        [TestCase("VII", ExpectedResult = 7)]
        [TestCase("VIII", ExpectedResult = 8)]
        [TestCase("IX", ExpectedResult = 9)]
        [TestCase("X", ExpectedResult = 10)]
        [TestCase("XL", ExpectedResult = 40)]
        [TestCase("L", ExpectedResult = 50)]
        [TestCase("XC", ExpectedResult = 90)]
        [TestCase("C", ExpectedResult = 100)]
        [TestCase("CD", ExpectedResult = 400)]
        [TestCase("D", ExpectedResult = 500)]
        [TestCase("CM", ExpectedResult = 900)]
        [TestCase("M", ExpectedResult = 1000)]
        [TestCase("DCCLXVII", ExpectedResult = 767)]
        [TestCase("MCMXCIV", ExpectedResult = 1994)]
        public int CanConvertFromRoman(string romanNumeral)
        {
            return romanConverter.ToArabic(romanNumeral);
        }
    }
}
