using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("7");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("0");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void minus(object sender, EventArgs e)
        {

            num1 = textBox1.Text;
            textBox1.Text = "";
            op = "-";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result(object sender, EventArgs e)
        {
            num2 =  textBox1.Text;
            if(op=="+")
                textBox1.Text = (int.Parse(num1) + int.Parse(num2)).ToString();
            else if(op=="-")
            {
                textBox1.Text = (int.Parse(num1) - int.Parse(num2)).ToString();
            }
            else if (op == "/")
            {
                textBox1.Text = (int.Parse(num1) / int.Parse(num2)).ToString();
            }
            else if (op == "*")
            {
                textBox1.Text = (int.Parse(num1) * int.Parse(num2)).ToString();
            }


        }

        private void add(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            textBox1.Text = "";
            op = "+";
        }
        string op;
        string num2;
        string num1;

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("4");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("5");
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("6");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            num1 = textBox1.Text;
            textBox1.Text = "";
            op = "/";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            num1 = textBox1.Text;
            textBox1.Text = "";
            op = "*";
        }
    }
}
