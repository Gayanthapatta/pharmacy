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
    public partial class Form12 : Form
    {
        DatabaseHandler fnc;
        public Form12()
        {
            InitializeComponent();
            fnc = new DatabaseHandler();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void refreshForm()
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox2.Text != "" && textBox3.Text != "")
            {
                int user = Properties.Settings.Default.UserID;
                Decimal amount = -Decimal.Parse(textBox2.Text);
                Decimal price = Decimal.Parse(textBox3.Text);
                int medicine_id = int.Parse(comboBox2.SelectedValue.ToString());

                String sql_string = "insert into medicine_inventry(medicine_id,changed_amount,price,[user]) values("+medicine_id+",'"+amount+"','"+price+"',"+user+")";
                try
                {
                    fnc.setData(sql_string, "Sold Success!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                refreshForm();
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            String medicine_query = "select id,name from medicines";
            fnc = new DatabaseHandler();
            DataSet ds = fnc.getData(medicine_query);
            DataTable dtt = ds.Tables[0];
            comboBox2.Items.Clear();
            comboBox2.DataSource = dtt;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";

        }
    }
}
