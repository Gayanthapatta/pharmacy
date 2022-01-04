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
    public partial class ServiceInitialize : Form
    {
        private DatabaseHandler dbHandler;
        public ServiceInitialize()
        {
            InitializeComponent();
            dbHandler = new DatabaseHandler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "insert into services (service_name,service_description,service_cost,service_income) values ('"+textBox1.Text+"','"+textBox2.Text+"',"+Decimal.Parse(textBox3.Text)+","+Decimal.Parse(textBox4.Text)+")";
            try
            {
                dbHandler.setData(query,"Data insertion Success!");
            }catch(Exception ex)
            {
                MessageBox.Show("Incomplete insertion");
            }
        }
    }
}
