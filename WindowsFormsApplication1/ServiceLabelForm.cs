using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ServiceLabelForm : UserControl
    {
        private int id;
        private String name, description;
        private decimal income, cost;
        private DatabaseHandler dbHandler;
        public ServiceLabelForm(int id,String name,String description,decimal income,decimal cost)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.description = description;
            this.income = income;
            this.cost = cost;
            dbHandler = new DatabaseHandler();
        }

        private void ServiceLabelForm_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            label2.Text = description;
            label3.Text = "Cost : " + cost;
            label4.Text = "Income : " + income;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete Entry
            String sqld = "delete from services where id = " + id;
            try
            {
                dbHandler.setDataWithoutMessage(sqld);
                MessageBox.Show("Service Details Deleted Successfully","Info");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update entry
        }
    }
}
