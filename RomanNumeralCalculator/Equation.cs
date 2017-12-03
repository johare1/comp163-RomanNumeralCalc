using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralCalculator
{
    public class Equation
    {
        RomanNumber romanNumber1;
        RomanNumber romanNumber2;
        int n1 = 0;
        int n2 = 0;


        public Equation(string r1, string r2) {
            romanNumber1 = new RomanNumber(r1);
            romanNumber2 = new RomanNumber(r2);
        }

        public int AddNumbers() {
            n1 = romanNumber1.Convert();
            n2 = romanNumber2.Convert();
            return n1 + n2; 
        }

        public int SubtractNumbers()
        {
            n1 = romanNumber1.Convert();
            n2 = romanNumber2.Convert();
            return n1 - n2;
        }

        public int MultiplyNumbers()
        {
          
            n1 = romanNumber1.Convert();
            n2 = romanNumber2.Convert();



            return n1 * n2;
        }

        public int DivideNumbers()
        {
            n1 = romanNumber1.Convert();
            n2 = romanNumber2.Convert();

            return n1 / n2;

        }

    }
}
