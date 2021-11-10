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
    public partial class Form9 : Form
    {
        private function myfunc;
        public Form9()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Refresh
            CleanForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert button
            String sqls = "insert into Medicines (name,description,dosage,usage,unit) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+comboBox2.Text+"')";
            myfunc.setData(sqls, "New Medicine initilized Success!");
            CleanForm();
        }

        private void CleanForm()
        {
            textBox1.Text = "";//Name
            textBox2.Text = "";//description
            textBox4.Text = "";//dosage
            textBox5.Text = "";//usage
            comboBox2.Text = "";//unit
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            myfunc = new function();
        }
    }
}
