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
    public partial class welcom : Form
    {
        public welcom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signupform s1 = new signupform();
            s1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
