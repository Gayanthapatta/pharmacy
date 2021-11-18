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
    public partial class ViewPrescriptionsForm : Form
    {
        DatabaseHandler dbHandler;
        private int id;
        public ViewPrescriptionsForm(int id)
        {
            InitializeComponent();
            this.id = id;
            dbHandler = new DatabaseHandler();
        }

        private void ViewPrescriptionsForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Quantity");
            listView1.Columns.Add("Price");
            String docRef = "select * from prescriptions where Id = "+id;
            String mediRef = "select pres_med.*,Medicines.name from pres_med,Medicines where Medicines.Id = pres_med.medicine_id and prescription_id = " + id;
            try
            {
                DataSet ds1 = dbHandler.getData(docRef);
                DataSet ds2 = dbHandler.getData(mediRef);

                DataRow[] dr1 = ds1.Tables[0].Select();
                DataRow[] dr2 = ds2.Tables[0].Select();

                if(dr1.Length > 0)
                {
                    label2.Text = dr1[0].Field<String>("name");
                    label3.Text = dr1[0].Field<String>("address");
                    label4.Text = dr1[0].Field<String>("mobile");
                    label5.Text = dr1[0].Field<DateTime>("date").ToString();
                    label6.Text = dr1[0].Field<String>("status");
                    MessageBox.Show(dr2.Length.ToString());
                    foreach(DataRow dr in dr2)
                    {
                        listView1.Items.Add(new ListViewItem(new String[] { dr.Field<int>("id").ToString(), dr.Field<String>("name"), dr.Field<String>("quantity"), dr.Field<String>("price") }));
                    }
                }
                else
                {
                    MessageBox.Show("Could not find correct document,"+dr1.Length, "Info");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
