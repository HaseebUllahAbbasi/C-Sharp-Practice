using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex user_name_reg = new Regex("[a-zA-Z0-9]{8,}");
            //label3.Text = user_name_reg.IsMatch(user_name.Text).ToString();
            Regex pass_reg = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[a-zA-Z]).{8,}$");
            //label3.Text = pass_reg.IsMatch(password.Text).ToString();
            if(pass_reg.IsMatch(password.Text) && user_name_reg.IsMatch(user_name.Text) && (!user_name.Text.Contains(",")) && (!password.Text.Contains(",") && !found(user_name.Text,password.Text))) 
            {

                label3.Text = "written";
                //please write your path here 

                StreamWriter writer = File.AppendText(@"C:\Users\PeaceSeeker\Documents\C_Sharp\Lab_7\Users\user.txt");
                writer.WriteLine(user_name.Text+","+password.Text);
                writer.Close();
            }
            else
            {
                label3.Text = "please try again";
            }
        }

        private bool found(string text1, string text2)
        {
            //please write your path here 
            StreamReader streamReader = File.OpenText(@"C:\Users\PeaceSeeker\Documents\C_Sharp\Lab_7\Users\user.txt");
            string data;
            while ( (data = streamReader.ReadLine())!=null )
            {
                string[] array = data.Split(',');
                foreach(string item in array)
                {
                    if (item.Equals(user_name.Text))
                    {
                        streamReader.Close();
                        return true;
                        
                    }
                }
            }
            streamReader.Close();
            return false;
        }
    }
}
