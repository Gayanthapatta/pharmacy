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
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm =new Form1();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 am = new Form5();
            am.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 am = new Form6();
            am.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 am = new Form7();
            am.Show();
            this.Hide();
        }
    }
}
