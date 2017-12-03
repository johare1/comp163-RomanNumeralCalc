using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralCalculator
{
    public class RomanNumber
    {
        public int arabicNumber;
        public String romanNum = String.Empty;
        private Dictionary<char, int> CharValues = null;
        private string[] ThousandsLetters = { "", "M", "MM", "MMM" };
        private string[] HundredsLetters = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] TensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] OnesLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        //constructors

        public RomanNumber(String rn) {
            this.romanNum = rn;
        }

        public RomanNumber(int n) {
            this.arabicNumber = n;
        }

        //-----------conversion methods to and from roman to arabic -------
        //parts of the code for these Conversion methods were used and altered from csharphelper.com/blog/2016/04/convert-to-and-from-roman-numerals-in-c/

        public int Convert() {

            if (CharValues == null)
            {
                CharValues = new Dictionary<char, int>();
                CharValues.Add('I', 1);
                CharValues.Add('V', 5);
                CharValues.Add('X', 10);
                CharValues.Add('L', 50);
                CharValues.Add('C', 100);
                CharValues.Add('D', 500);
                CharValues.Add('M', 1000);
            }

            if (romanNum.Length == 0) return 0;

            // convert letter value
            arabicNumber = 0;
            int lastValue = 0;
            for (int i = romanNum.Length - 1; i >= 0; i--)
            {
                int newValue = CharValues[romanNum[i]];

                //add or subtract 
                if (newValue < lastValue)
                    arabicNumber -= newValue;
                else
                {
                    arabicNumber += newValue;
                    lastValue = newValue;
                }
            }
          
            return arabicNumber;
        }

        public string convertToRoman() {

           string result = string.Empty;

            //thousands
            int num;
            num = arabicNumber / 1000;
            result += ThousandsLetters[num];
            arabicNumber %= 1000;

            //hundreds.
            num = arabicNumber / 100;
            result += HundredsLetters[num];
            arabicNumber %= 100;

            //tens
            num = arabicNumber / 10;
            result += TensLetters[num];
            arabicNumber %= 10;

            //ones
            result += OnesLetters[arabicNumber];

            return result;

        }


    }
}
