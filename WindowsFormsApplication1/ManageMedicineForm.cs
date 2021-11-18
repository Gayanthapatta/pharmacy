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
    public partial class ManageMedicineForm : Form
    {
        DatabaseHandler fns;
        public ManageMedicineForm()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            fns = new DatabaseHandler();
            String sqls = "Select * from Medicines";
            try
            {
                int topMargin = 10;
                panel1.Controls.Clear();
                DataSet ds = fns.getData(sqls);
                DataTable dt = ds.Tables[0];
                DataRow[] drs = dt.Select();
                for(int i = 0; i < drs.Length; i++)
                {
                    MedicineLabelForm uc1 = new MedicineLabelForm(drs[i]);
                    panel1.Controls.Add(uc1);
                    uc1.Top = topMargin;
                    topMargin = (uc1.Top + uc1.Height + 10);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqls = "Select * from Medicines";
            try
            {
                int topMargin = 10;
                panel1.Controls.Clear();
                DataSet ds = fns.getData(sqls);
                DataTable dt = ds.Tables[0];
                DataRow[] drs = dt.Select();
                for (int i = 0; i < drs.Length; i++)
                {
                    MedicineLabelForm uc1 = new MedicineLabelForm(drs[i]);
                    panel1.Controls.Add(uc1);
                    uc1.Top = topMargin;
                    topMargin = (uc1.Top + uc1.Height + 10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
