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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            label11.Text = signupform.fname;
            label12.Text = signupform.lname;
            label13.Text = signupform.email;
            label14.Text = signupform.mobile;
            label15.Text = signupform.dob;

            if (signupform.course)
            {
                label16.Text = "✓";
            }
            if (signupform.hostal)
            {
                label17.Text = "✓";
            }
            if (signupform.exam)
            {
                label18.Text = "✓";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
