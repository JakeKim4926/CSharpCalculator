using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        private string strNumber = "";
        private string strInputNum = "";
        private int status = 0;
        private Operator currentOperator = Operator.NONE;

        public Form1()
        {
            InitializeComponent();

            // 숫자 버튼 클릭 이벤트 연결
            button1.Click += NumberButton_Click;
            button2.Click += NumberButton_Click;
            button3.Click += NumberButton_Click;
            button4.Click += NumberButton_Click;
            button5.Click += NumberButton_Click;
            button6.Click += NumberButton_Click;
            button7.Click += NumberButton_Click;
            button8.Click += NumberButton_Click;
            button9.Click += NumberButton_Click;
        }

        public bool IsDecimal(string temp)
        {
            if (temp.Contains("."))
                return true;

            return false;
        }

        public void calculate()
        {
            switch (currentOperator)
            {
                case Operator.PLUS:
                    if (IsDecimal(strNumber) || IsDecimal(strInputNum))
                    {
                        double result = double.Parse(strNumber) + double.Parse(strInputNum);
                        strNumber = result.ToString();
                    }
                    else
                    {
                        long result = long.Parse(strNumber) + long.Parse(strInputNum);
                        strNumber = result.ToString();
                    }
                    break;
                case Operator.MINUS:
                    if (IsDecimal(strNumber) || IsDecimal(strInputNum))
                    {
                        double result = double.Parse(strNumber) - double.Parse(strInputNum);
                        strNumber = result.ToString();
                    }
                    else
                    {
                        long result = long.Parse(strNumber) - long.Parse(strInputNum);
                        strNumber = result.ToString();
                    }
                    break;

            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                strInputNum += btn.Text;
                textBox1.Text = strInputNum;
            }

        }

        private void button０_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strInputNum))
                return;

            strInputNum += "0";
            textBox1.Text = strInputNum;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            strInputNum = "";
            textBox1.Text = strInputNum;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            strInputNum = "";
            strNumber = "";
            textBox1.Text = strInputNum;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            currentOperator = Operator.PLUS;

            if (string.IsNullOrEmpty(strNumber))
                strNumber = strInputNum;
            else
                calculate();
            strInputNum = "";
            textBox1.Text = strNumber;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            currentOperator = Operator.MINUS;

            if (string.IsNullOrEmpty(strNumber))
                strNumber = strInputNum;
            else
                calculate();
            strInputNum = "";
            textBox1.Text = strNumber;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            currentOperator = Operator.MULTIPLY;

            if (string.IsNullOrEmpty(strNumber))
                strNumber = strInputNum;
            else
                calculate();
            strInputNum = "";
            textBox1.Text = strNumber;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            currentOperator = Operator.DIVIDE;

            if (string.IsNullOrEmpty(strNumber))
                strNumber = strInputNum;
            else
                calculate();
            strInputNum = "";
            textBox1.Text = strNumber;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            calculate();
            strInputNum = "";
            textBox1.Text = strNumber;
        }
    }

    public enum Operator
    {
        NONE,
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE,
        MOD
    }

    
}
