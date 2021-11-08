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
        private function my_func;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            my_func = new function();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (textUserName.Text != "" && textPassword.Text != "")
            {
                try
                {
                    String uname = textUserName.Text;
                    String password = textPassword.Text;
                    String sql_query = "select * from [users] where CONVERT(VARCHAR,username)= '"+uname+"' and CONVERT(VARCHAR,pass) = '"+password+"'";
                    //select * from users where username = Nimal' and pass = 'ldsghihsg'
                    DataSet ds = my_func.getData(sql_query);
                    if(ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("User Not Found","Error!");
                    }else
                    {
                        Adminstrator am = new Adminstrator();
                        am.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Occured!");
                }
            }
            else
            {
                MessageBox.Show("Username or password field is/are empty", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
    

