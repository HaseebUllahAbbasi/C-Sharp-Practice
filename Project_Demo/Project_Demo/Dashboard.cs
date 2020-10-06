using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo_project.User;
using Project_Demo.All_User_Controls;

namespace Project_Demo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Room(object sender, EventArgs e)
        {
            moving_Panel.Left = Add_button.Left + 16;
            add_Rooms1.Visible = true;
            add_Rooms1.BringToFront();
            
        }

        private void Customer_Registration(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl11.BringToFront();
            moving_Panel.Left = Customer_button.Left + 16;
            
        }

        private void Check_Out(object sender, EventArgs e)
        {
           
            moving_Panel.Left = CheckOut_Button.Left + 16;
            userControl21.Visible = true;
            userControl21.BringToFront();
        }

        private void Customer_Details(object sender, EventArgs e)
        {

            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            moving_Panel.Left = Customer_Detail_button.Left + 16;
        }

        private void Employees(object sender, EventArgs e)
        {
            moving_Panel.Left = Employees_button.Left + 16;
            userControl31.Visible = true;
            userControl31.BringToFront();
        }

        private void Logout(object sender, EventArgs e)
        {
            moving_Panel.Left = LogOut_Button.Left + 16;
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void add_Rooms1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            add_Rooms1.Visible = false;
            customerDetails1.Visible = false;
            userControl11.Visible = false;
            Add_button.PerformClick();
           


        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
