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

    }
}
