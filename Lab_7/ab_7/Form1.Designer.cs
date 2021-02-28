namespace ab_7
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
            this.picture_view = new System.Windows.Forms.PictureBox();
            this.drives_combo = new System.Windows.Forms.ComboBox();
            this.files_folder = new System.Windows.Forms.ListBox();
            this.next_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Prev_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_view)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_view
            // 
            this.picture_view.Location = new System.Drawing.Point(292, 38);
            this.picture_view.Name = "picture_view";
            this.picture_view.Size = new System.Drawing.Size(405, 342);
            this.picture_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_view.TabIndex = 0;
            this.picture_view.TabStop = false;
            // 
            // drives_combo
            // 
            this.drives_combo.FormattingEnabled = true;
            this.drives_combo.Location = new System.Drawing.Point(43, 38);
            this.drives_combo.Name = "drives_combo";
            this.drives_combo.Size = new System.Drawing.Size(177, 21);
            this.drives_combo.TabIndex = 1;
            this.drives_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // files_folder
            // 
            this.files_folder.FormattingEnabled = true;
            this.files_folder.Location = new System.Drawing.Point(43, 87);
            this.files_folder.Name = "files_folder";
            this.files_folder.Size = new System.Drawing.Size(177, 316);
            this.files_folder.TabIndex = 2;
            this.files_folder.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(301, 401);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_method);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_method);
            // 
            // Prev_button
            // 
            this.Prev_button.Location = new System.Drawing.Point(382, 401);
            this.Prev_button.Name = "Prev_button";
            this.Prev_button.Size = new System.Drawing.Size(75, 23);
            this.Prev_button.TabIndex = 4;
            this.Prev_button.Text = "Prev";
            this.Prev_button.UseVisualStyleBackColor = true;
            this.Prev_button.Click += new System.EventHandler(this.prev_button_method);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(463, 401);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 23);
            this.play_button.TabIndex = 5;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_method);
            // 
            // pause_button
            // 
            this.pause_button.Location = new System.Drawing.Point(544, 401);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 23);
            this.pause_button.TabIndex = 6;
            this.pause_button.Text = "Pause";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_method);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.Prev_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.files_folder);
            this.Controls.Add(this.drives_combo);
            this.Controls.Add(this.picture_view);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_view;
        private System.Windows.Forms.ComboBox drives_combo;
        private System.Windows.Forms.ListBox files_folder;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Prev_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button pause_button;
    }
}

