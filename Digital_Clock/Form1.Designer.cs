namespace Digital_Clock
{
    partial class Form1
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
            this.Time_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Seconds = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Day = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Time_label
            // 
            this.Time_label.BackColor = System.Drawing.Color.Transparent;
            this.Time_label.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.ForeColor = System.Drawing.Color.White;
            this.Time_label.Location = new System.Drawing.Point(137, 113);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(105, 56);
            this.Time_label.TabIndex = 0;
            this.Time_label.Text = " Time";
            // 
            // Seconds
            // 
            this.Seconds.BackColor = System.Drawing.Color.Transparent;
            this.Seconds.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.ForeColor = System.Drawing.Color.White;
            this.Seconds.Location = new System.Drawing.Point(523, 113);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(84, 30);
            this.Seconds.TabIndex = 1;
            this.Seconds.Text = " Seconds";
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.Color.Transparent;
            this.Day.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.Color.White;
            this.Day.Location = new System.Drawing.Point(523, 277);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(43, 30);
            this.Day.TabIndex = 2;
            this.Day.Text = "Day";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(203, 277);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(72, 43);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.tick_event);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Time_label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Time_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Seconds;
        private Guna.UI2.WinForms.Guna2HtmlLabel Day;
        private Guna.UI2.WinForms.Guna2HtmlLabel Date;
        private System.Windows.Forms.Timer timer1;
    }
}

