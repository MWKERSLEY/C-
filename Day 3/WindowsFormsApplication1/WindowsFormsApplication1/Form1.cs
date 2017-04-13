using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void requestGreeting_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;//get the entered name
            DateTime today = DateTime.Now.Date;//create today's date
            TimeSpan ageDays = today - DOBSelector.Value;//get the date selected
            int years = ((int)ageDays.TotalDays) / 365;//get the number of years since birth
            int day = DOBSelector.Value.Day;//get the day value of the DOB
            string month = DOBSelector.Value.ToString("MMMM");//get the month as a word

            message.Text = "Hello, " + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";//change the name of the label
        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
