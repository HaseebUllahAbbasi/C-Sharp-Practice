using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		string option ="";
		int number_1;
		int number_2;
		int sum=0;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		

        private void clicked_number(object sender, EventArgs e)
        {
			Button btn = (Button)sender;
			textBox.AppendText(btn.Text);
		}
		int count = 0;
		private void clicked_Operator(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
            Console.WriteLine(textBox.Text);
			number_1 =int.Parse(textBox.Text);
			option = btn.Text;
			textBox.Text = "";
		}

        private void equal(object sender, EventArgs e)
        {
			number_2 = int.Parse(textBox.Text);
			textBox.Text = sum.ToString();
			
			if(option=="+")
				textBox.Text = (number_2+number_1).ToString();
			else if (option == "-")
				textBox.Text = (number_1-number_2).ToString();
			else if (option == "*")
				textBox.Text = (number_2 * number_1).ToString();
			else if (option == "/")
				textBox.Text = (number_1 / number_2).ToString();
			else if (option == "%")
				textBox.Text = (sum % number_2).ToString();

			


		}

		private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear(object sender, EventArgs e)
        {
			textBox.Text = "";
			sum = 0;
			number_1 = 0;
			number_2 = 0;
			option = "";

        }
    }
}
