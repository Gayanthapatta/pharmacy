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
    public partial class BuyMedicineForm : Form
    {
        DatabaseHandler fnc;
        public BuyMedicineForm()
        {
            InitializeComponent();
            fnc = new DatabaseHandler();
        }

        private void refresh()
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user = Properties.Settings.Default.UserID;
            Decimal amount = Decimal.Parse(textBox2.Text);
            Decimal price = Decimal.Parse(textBox3.Text);
            int medicine_id = int.Parse(comboBox1.SelectedValue.ToString());

            String sql_string = "insert into medicine_inventry(medicine_id,changed_amount,price,[user]) values(" + medicine_id + ",'" + amount + "','" + price + "'," + user + ")";
            try
            {
                fnc.setData(sql_string, "Sold Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
