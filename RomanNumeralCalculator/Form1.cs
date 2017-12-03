using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        String userInputNumber1 = String.Empty;
        String userInputNumber2 = String.Empty;
        bool isFirstNumber = true;
        String _calcMode = string.Empty;

        //this method runs when a numeric button is clicked and the click event runs
        public void PressLetterButton(String b) {
            RomanNumber currNumber;
            if (isFirstNumber == true)
            {
                userInputNumber1 += b;
                currNumber = new RomanNumber(userInputNumber1);
                txtCalcOutput.Text = currNumber.romanNum;
                txtConvertedNumber.Text = currNumber.Convert().ToString();
                currNumber.romanNum = string.Empty;
            }
            else if(isFirstNumber == false)
            {
                userInputNumber2 += b;
                currNumber = new RomanNumber(userInputNumber2);
                txtCalcOutput.Text = currNumber.romanNum;
                txtConvertedNumber.Text = currNumber.Convert().ToString();
                currNumber.romanNum = string.Empty;
            }

            
        }



        //-----------button click events--------------

        private void btnEqual_Click(object sender, EventArgs e)
        {
            RomanNumber number1 = new RomanNumber(userInputNumber1);
            RomanNumber number2 = new RomanNumber(userInputNumber2);
            RomanNumber result;
            //MessageBox.Show(newNumber.Convert().ToString());
            Equation newEquation = new Equation(userInputNumber1, userInputNumber2);
            if (_calcMode == "ADD")
            {
                result = new RomanNumber(newEquation.AddNumbers());
                result.romanNum = result.convertToRoman();
                txtCalcOutput.Text = result.romanNum;
                txtConvertedNumber.Text = result.Convert().ToString();
            }
            else if (_calcMode == "SUBTRACT")
            {
                result = new RomanNumber(newEquation.SubtractNumbers());
                result.romanNum = result.convertToRoman();
                txtCalcOutput.Text = result.romanNum;
                txtConvertedNumber.Text = result.Convert().ToString();
            }
            else if (_calcMode == "MULTIPLY")
            {
                result = new RomanNumber(newEquation.MultiplyNumbers());
                result.romanNum = result.convertToRoman();
                txtCalcOutput.Text = result.romanNum;
                txtConvertedNumber.Text = result.Convert().ToString();
                //test MessageBox.Show(newEquation.MultiplyNumbers().ToString() + " test");
            }
            else if (_calcMode == "DIVIDE")
            {
                result = new RomanNumber(newEquation.DivideNumbers());
                result.romanNum = result.convertToRoman();
                txtCalcOutput.Text = result.romanNum;
                txtConvertedNumber.Text = result.Convert().ToString();
            }
            else {
                txtCalcOutput.Text = "ERR";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCalcOutput.ReadOnly = true;
            txtConvertedNumber.ReadOnly = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Jack O'Hare \nMade for Comp 163 2017 \nLoyola University Chicago");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            isFirstNumber = false;
            _calcMode = "DIVIDE";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            isFirstNumber = false;
            _calcMode = "MULTIPLY";
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isFirstNumber = false;
            _calcMode = "ADD";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            isFirstNumber = false;
            _calcMode = "SUBTRACT";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            PressLetterButton("I");

        }

        private void btnV_Click(object sender, EventArgs e)
        {
            PressLetterButton("V");

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            PressLetterButton("X");

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            PressLetterButton("L");

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            PressLetterButton("M");

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            PressLetterButton("D");

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            PressLetterButton("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isFirstNumber = true;
            userInputNumber1 = String.Empty;
            userInputNumber2 = String.Empty;
            txtCalcOutput.Text = userInputNumber1;
            txtConvertedNumber.Text = userInputNumber1;
        }
    }
}
