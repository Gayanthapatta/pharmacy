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
    public partial class AddUsersForm : Form
    {
        private DatabaseHandler myfunction;
        public AddUsersForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String role = comboBox1.Text;
            String name = textBox1.Text;
            String DOB = dateTimePicker1.Text;
            Int64 mobile=Int64.Parse(textBox3.Text);
            String email = textBox2.Text;
            String username = textBox4.Text;
            String pass = textBox5.Text;

            try
            {
                String query = "Insert into users(userRole,name,dob,mobile,email,username,pass)values('" + role + "','" + name + "','" + DOB + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                myfunction.setData(query,"User Insertion Complete");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Occured");
            }
            //Form4 fm = new Form4();
            //fm.Show();
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mars\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\pharmacysystem.mdf;Integrated Security=True
            myfunction = new DatabaseHandler();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            dateTimePicker1.Text = null;
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
