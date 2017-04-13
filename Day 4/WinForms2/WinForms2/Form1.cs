using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class Form1 : Form
    {
        int timeLeft = 10;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;


        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (q1r2.Checked)
            {
                check1.ForeColor = Color.Green;
                check1.Text = "\u00fc";
                q1Correct = true;
            }
            else
            {
                check1.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (q2r3.Checked)
            {
                check2.ForeColor = Color.Red;
                check2.Text = "\u00fb";
                q2Correct = false;
            }
            else
            {
                check2.Text = "";
            }
        }

        private void q1r1_CheckedChanged(object sender, EventArgs e)
        {
            if (q1r1.Checked)
            {
                check1.ForeColor = Color.Red;
                check1.Text = "\u00fb";
                q1Correct = false;
            }
            else
            {
                check1.Text = "";
            }
        }

        private void q1r3_CheckedChanged(object sender, EventArgs e)
        {
            if (q1r3.Checked)
            {
                check1.ForeColor = Color.Red;
                check1.Text = "\u00fb";
                q1Correct = false;
            }
            else
            {
                check1.Text = "";
            }
        }

        private void q2r1_CheckedChanged(object sender, EventArgs e)
        {
            if (q2r1.Checked)
            {
                check2.ForeColor = Color.Red;
                check2.Text = "\u00fb";
                q2Correct = false;
            }
            else
            {
                check2.Text = "";
            }
        }

        private void q2r2_CheckedChanged(object sender, EventArgs e)
        {
            if (q2r2.Checked)
            {
                check2.ForeColor = Color.Green;
                check2.Text = "\u00fc";
                q2Correct = true;
            }
            else
            {
                check2.Text = "";
            }
        }

        private void q3r1_CheckedChanged(object sender, EventArgs e)
        {
            if (q3r1.Checked)
            {
                check3.ForeColor = Color.Red;
                check3.Text = "\u00fb";
                q3Correct = false;
            }
            else
            {
                check3.Text = "";
            }
        }

        private void q3r2_CheckedChanged(object sender, EventArgs e)
        {
            if (q3r2.Checked)
            {
                check3.ForeColor = Color.Red;
                check3.Text = "\u00fb";
                q3Correct = false;
            }
            else
            {
                check3.Text = "";
            }
        }

        private void q3r3_CheckedChanged(object sender, EventArgs e)
        {
            if (q3r3.Checked)
            {
                check3.ForeColor = Color.Green;
                check3.Text = "\u00fc";
                q3Correct = true;
            }
            else
            {
                check3.Text = "";
            }
        }

        private void check2_Click(object sender, EventArgs e)
        {

        }

        private void check3_Click(object sender, EventArgs e)
        {

        }

        private void check1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got all the questions right.", "Amazing...");
            } else if (timeLeft>0)
            {
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                MessageBox.Show("You ran out of time.", "Sorry");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            buttonStart.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
