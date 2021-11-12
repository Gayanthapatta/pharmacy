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
    public partial class Form6 : Form
    {
        private function mf;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Properties.Settings.Default.UserID.ToString());
            getProfileData();
            
        }

        private void getProfileData()
        {
            var query = "select * from users where id = " + Properties.Settings.Default.UserID;
            mf = new function();
            try
            {
                DataSet ds = mf.getData(query);
                DataTable dt = ds.Tables[0];
                DataRow[] drs = dt.Select();
                if (drs.Length > 1)
                {
                    MessageBox.Show("Internal Error, Could not Identify Correct User");
                }
                else
                {
                    comboBox1.Text = drs[0].Field<String>("userRole");
                    textBox1.Text = drs[0].Field<String>("name");
                    dateTimePicker1.Value = Convert.ToDateTime(drs[0].Field<String>("dob"));
                    textBox2.Text = drs[0].Field<String>("mobile");
                    textBox3.Text = drs[0].Field<String>("email");
                    textBox4.Text = drs[0].Field<String>("pass");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqls = "update users set userRole = '"+comboBox1.Text+"',name = '"+textBox1.Text+"',dob = '"+dateTimePicker1.Text+"',mobile = '"+textBox2.Text+"',email = '"+textBox3.Text+"',pass = '"+textBox4.Text+"' where id = " + Properties.Settings.Default.UserID;
            try
            {
                mf.setData(sqls, "Profile Update Successfully Completed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                getProfileData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go back
            this.Close();
        }
    }
}
