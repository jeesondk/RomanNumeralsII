using System;
using System.Collections.Generic;

namespace Kata.RomanNumbers.Logic
{
    public class RomanToArabic :IDisposable
    {
        private Dictionary<string, int> _romanToArabic;

        public RomanToArabic()
        {
            InitDictionary();
        }


        private void InitDictionary()
        {
            _romanToArabic = new Dictionary<string, int>
            {
                {"M", 1000},
                {"CM", 900},
                {"D",  500},
                {"CD", 400},
                {"C",  100},
                {"XC",  90},
                {"L",   50},
                {"XL",  40},
                {"X",   10},
                {"IX",   9},
                {"V",    5},
                {"IV",   4},
                {"I",    1}
            };
        }

        public int ToArabic(string romanNumeral)
        {
            int arabicNumber = 0;

            while(romanNumeral.Length != 0)
            {
                foreach(string token in _romanToArabic.Keys)
                {
                    if (romanNumeral.StartsWith(token))
                    {
                        romanNumeral = romanNumeral.Substring(token.Length);
                        arabicNumber += _romanToArabic[token];
                    }
                }
            }

            return arabicNumber;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _romanToArabic = null;
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
