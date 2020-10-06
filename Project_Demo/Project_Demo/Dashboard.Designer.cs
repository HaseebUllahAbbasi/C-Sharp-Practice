namespace Project_Demo
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.moving_Panel = new System.Windows.Forms.Panel();
            this.LogOut_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Employees_button = new Guna.UI2.WinForms.Guna2Button();
            this.Customer_Detail_button = new Guna.UI2.WinForms.Guna2Button();
            this.CheckOut_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Customer_button = new Guna.UI2.WinForms.Guna2Button();
            this.Add_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControl21 = new demo_project.User.UserControl2();
            this.userControl11 = new demo_project.User.UserControl1();
            this.customerDetails1 = new Project_Demo.All_User_Controls.CustomerDetails();
            this.add_Rooms1 = new Project_Demo.All_User_Controls.Add_Rooms();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControl31 = new demo_project.User.UserControl3();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.moving_Panel);
            this.panel1.Controls.Add(this.LogOut_Button);
            this.panel1.Controls.Add(this.Employees_button);
            this.panel1.Controls.Add(this.Customer_Detail_button);
            this.panel1.Controls.Add(this.CheckOut_Button);
            this.panel1.Controls.Add(this.Customer_button);
            this.panel1.Controls.Add(this.Add_button);
            this.panel1.Location = new System.Drawing.Point(64, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1913, 108);
            this.panel1.TabIndex = 0;
            // 
            // moving_Panel
            // 
            this.moving_Panel.BackColor = System.Drawing.Color.Cornsilk;
            this.moving_Panel.Location = new System.Drawing.Point(35, 95);
            this.moving_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.moving_Panel.Name = "moving_Panel";
            this.moving_Panel.Size = new System.Drawing.Size(257, 6);
            this.moving_Panel.TabIndex = 1;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.LogOut_Button.BorderRadius = 18;
            this.LogOut_Button.CheckedState.Parent = this.LogOut_Button;
            this.LogOut_Button.CustomImages.Parent = this.LogOut_Button;
            this.LogOut_Button.FillColor = System.Drawing.Color.SteelBlue;
            this.LogOut_Button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.ForeColor = System.Drawing.Color.White;
            this.LogOut_Button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.LogOut_Button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.LogOut_Button.HoverState.FillColor = System.Drawing.Color.Red;
            this.LogOut_Button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_Button.HoverState.Parent = this.LogOut_Button;
            this.LogOut_Button.Location = new System.Drawing.Point(1607, 14);
            this.LogOut_Button.Margin = new System.Windows.Forms.Padding(4);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.ShadowDecoration.Parent = this.LogOut_Button;
            this.LogOut_Button.Size = new System.Drawing.Size(293, 80);
            this.LogOut_Button.TabIndex = 0;
            this.LogOut_Button.Text = "LOGOUT";
            this.LogOut_Button.Click += new System.EventHandler(this.Logout);
            // 
            // Employees_button
            // 
            this.Employees_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Employees_button.BorderRadius = 18;
            this.Employees_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Employees_button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Employees_button.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Employees_button.CheckedState.Parent = this.Employees_button;
            this.Employees_button.CustomImages.Parent = this.Employees_button;
            this.Employees_button.FillColor = System.Drawing.Color.SteelBlue;
            this.Employees_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_button.ForeColor = System.Drawing.Color.White;
            this.Employees_button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Employees_button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Employees_button.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Employees_button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_button.HoverState.Parent = this.Employees_button;
            this.Employees_button.Location = new System.Drawing.Point(1291, 14);
            this.Employees_button.Margin = new System.Windows.Forms.Padding(4);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.ShadowDecoration.Parent = this.Employees_button;
            this.Employees_button.Size = new System.Drawing.Size(293, 80);
            this.Employees_button.TabIndex = 0;
            this.Employees_button.Text = "EMPLOYEES";
            this.Employees_button.Click += new System.EventHandler(this.Employees);
            // 
            // Customer_Detail_button
            // 
            this.Customer_Detail_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Customer_Detail_button.BorderRadius = 18;
            this.Customer_Detail_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Customer_Detail_button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Customer_Detail_button.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Customer_Detail_button.CheckedState.Parent = this.Customer_Detail_button;
            this.Customer_Detail_button.CustomImages.Parent = this.Customer_Detail_button;
            this.Customer_Detail_button.FillColor = System.Drawing.Color.SteelBlue;
            this.Customer_Detail_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Detail_button.ForeColor = System.Drawing.Color.White;
            this.Customer_Detail_button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Customer_Detail_button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Customer_Detail_button.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Customer_Detail_button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Detail_button.HoverState.Parent = this.Customer_Detail_button;
            this.Customer_Detail_button.Location = new System.Drawing.Point(972, 14);
            this.Customer_Detail_button.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_Detail_button.Name = "Customer_Detail_button";
            this.Customer_Detail_button.ShadowDecoration.Parent = this.Customer_Detail_button;
            this.Customer_Detail_button.Size = new System.Drawing.Size(293, 80);
            this.Customer_Detail_button.TabIndex = 0;
            this.Customer_Detail_button.Text = "CUSTOMER DETAILS";
            this.Customer_Detail_button.Click += new System.EventHandler(this.Customer_Details);
            // 
            // CheckOut_Button
            // 
            this.CheckOut_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.CheckOut_Button.BorderRadius = 18;
            this.CheckOut_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CheckOut_Button.CheckedState.FillColor = System.Drawing.Color.White;
            this.CheckOut_Button.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CheckOut_Button.CheckedState.Parent = this.CheckOut_Button;
            this.CheckOut_Button.CustomImages.Parent = this.CheckOut_Button;
            this.CheckOut_Button.FillColor = System.Drawing.Color.SteelBlue;
            this.CheckOut_Button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_Button.ForeColor = System.Drawing.Color.White;
            this.CheckOut_Button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.CheckOut_Button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.CheckOut_Button.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.CheckOut_Button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_Button.HoverState.Parent = this.CheckOut_Button;
            this.CheckOut_Button.Image = ((System.Drawing.Image)(resources.GetObject("CheckOut_Button.Image")));
            this.CheckOut_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CheckOut_Button.ImageOffset = new System.Drawing.Point(20, 0);
            this.CheckOut_Button.ImageSize = new System.Drawing.Size(40, 40);
            this.CheckOut_Button.Location = new System.Drawing.Point(648, 14);
            this.CheckOut_Button.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOut_Button.Name = "CheckOut_Button";
            this.CheckOut_Button.ShadowDecoration.Parent = this.CheckOut_Button;
            this.CheckOut_Button.Size = new System.Drawing.Size(293, 80);
            this.CheckOut_Button.TabIndex = 0;
            this.CheckOut_Button.Text = "CHECKOUT";
            this.CheckOut_Button.Click += new System.EventHandler(this.Check_Out);
            // 
            // Customer_button
            // 
            this.Customer_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Customer_button.BorderRadius = 18;
            this.Customer_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Customer_button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Customer_button.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Customer_button.CheckedState.Parent = this.Customer_button;
            this.Customer_button.CustomImages.Parent = this.Customer_button;
            this.Customer_button.FillColor = System.Drawing.Color.SteelBlue;
            this.Customer_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_button.ForeColor = System.Drawing.Color.White;
            this.Customer_button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Customer_button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Customer_button.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Customer_button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_button.HoverState.Parent = this.Customer_button;
            this.Customer_button.Image = ((System.Drawing.Image)(resources.GetObject("Customer_button.Image")));
            this.Customer_button.ImageOffset = new System.Drawing.Point(2, 0);
            this.Customer_button.ImageSize = new System.Drawing.Size(40, 40);
            this.Customer_button.Location = new System.Drawing.Point(332, 14);
            this.Customer_button.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_button.Name = "Customer_button";
            this.Customer_button.ShadowDecoration.Parent = this.Customer_button;
            this.Customer_button.Size = new System.Drawing.Size(293, 80);
            this.Customer_button.TabIndex = 0;
            this.Customer_button.Text = "CUSTOMER REGISTRATION";
            this.Customer_button.Click += new System.EventHandler(this.Customer_Registration);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Add_button.BorderRadius = 18;
            this.Add_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Add_button.CheckedState.FillColor = System.Drawing.Color.White;
            this.Add_button.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Add_button.CheckedState.Parent = this.Add_button;
            this.Add_button.CustomImages.Parent = this.Add_button;
            this.Add_button.FillColor = System.Drawing.Color.SteelBlue;
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Add_button.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Add_button.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Add_button.HoverState.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.HoverState.Parent = this.Add_button;
            this.Add_button.Image = ((System.Drawing.Image)(resources.GetObject("Add_button.Image")));
            this.Add_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_button.ImageOffset = new System.Drawing.Point(10, 0);
            this.Add_button.ImageSize = new System.Drawing.Size(40, 40);
            this.Add_button.Location = new System.Drawing.Point(17, 14);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_button.Name = "Add_button";
            this.Add_button.ShadowDecoration.Parent = this.Add_button;
            this.Add_button.Size = new System.Drawing.Size(293, 80);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "ADD ROOM";
            this.Add_button.Click += new System.EventHandler(this.Add_Room);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Controls.Add(this.customerDetails1);
            this.panel2.Controls.Add(this.add_Rooms1);
            this.panel2.Location = new System.Drawing.Point(64, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1587, 645);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.Location = new System.Drawing.Point(1, 6);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(48, 46);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.UseTransparentBackground = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2CircleButton2.Location = new System.Drawing.Point(1, 60);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(48, 46);
            this.guna2CircleButton2.TabIndex = 2;
            this.guna2CircleButton2.UseTransparentBackground = true;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Location = new System.Drawing.Point(4, 1);
            this.userControl21.Margin = new System.Windows.Forms.Padding(4);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1468, 568);
            this.userControl21.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Location = new System.Drawing.Point(8, 8);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1468, 568);
            this.userControl11.TabIndex = 2;
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.White;
            this.customerDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerDetails1.ForeColor = System.Drawing.SystemColors.Control;
            this.customerDetails1.Location = new System.Drawing.Point(0, 0);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1468, 568);
            this.customerDetails1.TabIndex = 1;
            // 
            // add_Rooms1
            // 
            this.add_Rooms1.BackColor = System.Drawing.Color.White;
            this.add_Rooms1.Location = new System.Drawing.Point(-2, 1);
            this.add_Rooms1.Margin = new System.Windows.Forms.Padding(4);
            this.add_Rooms1.Name = "add_Rooms1";
            this.add_Rooms1.Size = new System.Drawing.Size(1468, 568);
            this.add_Rooms1.TabIndex = 0;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.White;
            this.userControl31.Location = new System.Drawing.Point(6, 7);
            this.userControl31.Margin = new System.Windows.Forms.Padding(4);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1468, 568);
            this.userControl31.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1088);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button LogOut_Button;
        private Guna.UI2.WinForms.Guna2Button Employees_button;
        private Guna.UI2.WinForms.Guna2Button Customer_Detail_button;
        private Guna.UI2.WinForms.Guna2Button CheckOut_Button;
        private Guna.UI2.WinForms.Guna2Button Customer_button;
        private Guna.UI2.WinForms.Guna2Button Add_button;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Panel moving_Panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Controls.Add_Rooms add_Rooms1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Controls.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private demo_project.User.UserControl1 userControl11;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private demo_project.User.UserControl2 userControl21;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private demo_project.User.UserControl3 userControl31;
    }
}