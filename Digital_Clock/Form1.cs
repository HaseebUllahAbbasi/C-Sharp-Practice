using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tick_event(object sender, EventArgs e)
        {
            Time_label.Text = DateTime.Now.ToString("HH:mm");
            Day.Text = DateTime.Now.ToString("dddd");
            Seconds.Text = DateTime.Now.ToString("ss");
            Date.Text = DateTime.Now.ToString("dd - MM - yyyy");
        }
    }
}
