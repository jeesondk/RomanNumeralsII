using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.RomanNumbers.Logic
{
    public class ArabicToRoman :IDisposable
    {
        private Dictionary<int, string> _arabicToRoman;
        private StringBuilder romanNumeral;

        public ArabicToRoman()
        {
            InitDictionary();
            romanNumeral = new StringBuilder();
        }


        private void InitDictionary()
        {
            _arabicToRoman = new Dictionary<int, string>
            {
                {1000,"M"},
                {900,"CM"},
                {500,"D"},
                {400,"CD"},
                {100,"C"},
                {90,"XC"},
                {50,"L"},
                {40,"XL"},
                {10,"X"},
                {9,"IX"},
                {5,"V"},
                {4,"IV"},
                {1 ,"I"}
            };
        }

        public string ToRoman(int arabicNumeral)
        {
            CheckBoundaryConditions(arabicNumeral);

            foreach(var arabicDigit in _arabicToRoman.Keys)
            {
                while(arabicNumeral >= arabicDigit)
                {
                    romanNumeral.Append(_arabicToRoman[arabicDigit]);
                    arabicNumeral -= arabicDigit;
                }
            }
            return romanNumeral.ToString();
        }

        private void CheckBoundaryConditions(int arabicNumeral)
        {
            if (arabicNumeral <= 0)
                throw new ArgumentOutOfRangeException("Roman Numbers cannot express zero or negative values. \r\n Reference: http://turner.faculty.swau.edu/mathematics/materialslibrary/roman/");
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   _arabicToRoman = null;
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
