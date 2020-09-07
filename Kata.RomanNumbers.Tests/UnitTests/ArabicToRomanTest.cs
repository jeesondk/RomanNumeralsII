using Kata.RomanNumbers.Logic;
using NUnit.Framework;
using System;

namespace Kata.RomanNumbers.Tests.UnitTests
{
    [TestFixture]
    public class ArabicToRomanTest
    {
        private ArabicToRoman arabicConverter;


        [SetUp]
        public void SetUp()
        {
            arabicConverter = new ArabicToRoman();
        }

        [TearDown]
        public void TearDown()
        {
            arabicConverter.Dispose();
        }

        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(7, ExpectedResult = "VII")]
        [TestCase(8, ExpectedResult = "VIII")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(90, ExpectedResult = "XC")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(400, ExpectedResult = "CD")]
        [TestCase(500, ExpectedResult = "D")]
        [TestCase(900, ExpectedResult = "CM")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(767, ExpectedResult = "DCCLXVII")]
        [TestCase(1994, ExpectedResult = "MCMXCIV")]
        public string CanConvertToRoman(int arabicNumeral)
        {
            return arabicConverter.ToRoman(arabicNumeral);
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void ThrowsException(int arabicNumeral)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => arabicConverter.ToRoman(arabicNumeral));

        }
    }
}
