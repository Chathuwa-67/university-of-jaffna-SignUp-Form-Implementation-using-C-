using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UoJApp
{
    public partial class signupform : Form
    {
        public static string fname;
        public static string lname;
        public static string email;
        public static string mobile;
        public static string dob;
        public static bool course;
        public static bool hostal;
        public static bool exam;
        public signupform()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                course= true;
                label7.Text = "Check Your mail !";
            }
            else
            {
                course= false;
                label7.Text = "****";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                exam = true;
                label8.Text = "Charges may apply";
            }
            else
            {
                exam = false;
                label8.Text = "****";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                hostal = true;
                label9.Text = "Charges may apply";
            }
            else
            {
                hostal = false;
                label9.Text = "****";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirmation c1= new Confirmation();
            fname=textBox1.Text;
            lname = textBox3.Text;
            email = textBox2.Text;
            mobile = textBox4.Text;
            dob = dateTimePicker1.Value.ToShortDateString();
            this.Hide();
            c1.Show();
        }
    }
}
