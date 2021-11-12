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
    public partial class Form5 : Form
    {
        function fn = new function();
        String query;

        public Form5()
        {
            InitializeComponent();
        }

        private void addDataToDataGrid()
        {
            try
            {
                query = "select * from users";
                DataSet ds = fn.getData(query);
                bindingSource1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            addDataToDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDataToDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
