using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            disable_the_components();
            DriveInfo[] drives = DriveInfo.GetDrives(); 
            foreach(DriveInfo drive in drives)
            {
                if (drive.IsReady)
                    drives_combo.Items.Add(drive.Name);   
            }
            //comboBox1.Items.AddRange();
        }

        private void disable_the_components()
        {
            pause_button.Enabled = false;
            next_button.Enabled = false;
            play_button.Enabled = false;
            Prev_button.Enabled = false;
            picture_view.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            files_folder.Items.Clear();
            picture_view.Image = null;
           // Text = comboBox1.SelectedItem.ToString();
           
           DirectoryInfo directoryInfo = new DirectoryInfo(drives_combo.SelectedItem.ToString()); 
           foreach(DirectoryInfo directory in directoryInfo.GetDirectories())
           {
                File_Directory obj_dir = new File_Directory(directory.Name,directory.FullName);
                files_folder.Items.Add(obj_dir);
           }
           foreach (FileInfo file in directoryInfo.GetFiles("*.png"))
           {
                File_Directory obj_dir = new File_Directory(file.Name, file.FullName);
                files_folder.Items.Add(obj_dir);
           }
            if((directoryInfo.GetFiles("*.png")).Length==0)
            {
                disable_the_components();
            }






        }
        File_Directory[] array_of_object;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            DirectoryInfo directoryInfo = new DirectoryInfo(((File_Directory)files_folder.SelectedItem).fullName);
            if (!directoryInfo.Exists)
                return;
            FileInfo[] files  = directoryInfo.GetFiles("*.png");
             array_of_object = new File_Directory[files.Length];
            int i = 0; 
            foreach (FileInfo file in files)
            {
                array_of_object[i++] = new File_Directory(file.Name,file.FullName);
            }
            Populate(array_of_object, ((File_Directory)files_folder.SelectedItem).fullName);

        
        }
        string[] Paths;
        int index;
        private bool forward;

        private void Populate(File_Directory[] dir__1,string path)
        {
            index = 0;
            int local_index = 0;
            files_folder.Items.Clear();
            Paths = new string[dir__1.Length];
            foreach(File_Directory dir in dir__1)
            {
                Paths[local_index++] = dir.fullName;
                files_folder.Items.Add(dir);
            }
            DirectoryInfo directoryInfo_1 = new DirectoryInfo(path);
            foreach (DirectoryInfo obj in directoryInfo_1.GetDirectories())
            {
                File_Directory directory = new File_Directory(obj.Name, obj.FullName);
                files_folder.Items.Add(directory);
            }
            if(Paths.Length>0)
            {
                picture_view.ImageLocation = Paths[0];
                enable_components();
            }
            else
            {
                picture_view.ImageLocation = null;
                disable_the_components();
            }
        }

        private void enable_components()
        {

            pause_button.Enabled = true;
            next_button.Enabled = true;
            play_button.Enabled = true;
            Prev_button.Enabled = true;
        }

        private void next_button_method(object sender, EventArgs e)
        {
            if(array_of_object.Length>0)
            picture_view.ImageLocation = Paths[(index++) % array_of_object.Length];
            forward = true;
        }

        private void prev_button_method(object sender, EventArgs e)
        {
            if (index >= 1)
                picture_view.ImageLocation = Paths[(index--) % array_of_object.Length];
            else
            {
                index = array_of_object.Length - 1;
                picture_view.ImageLocation = Paths[index];

            }
            forward = false;
        }

        private void timer_method(object sender, EventArgs e)
        {
            if(forward)
            {
                if (array_of_object.Length > 0)
                    picture_view.ImageLocation = Paths[(index++) % array_of_object.Length];
            }
            else
            {
                if (index >= 1)
                    picture_view.ImageLocation = Paths[(index--) % array_of_object.Length];
                else
                {
                    index = array_of_object.Length - 1;
                    picture_view.ImageLocation = Paths[index];

                }
            }
            
        }

        private void pause_button_method(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void play_button_method(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
