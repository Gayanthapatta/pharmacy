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
    public partial class MedicineLabelForm : UserControl
    {
        private int id;
        DatabaseHandler dbHandler;
        public MedicineLabelForm(DataRow dr)
        {
            InitializeComponent();
            dbHandler = new DatabaseHandler();
            id = dr.Field<int>("Id");
            label1.Text = dr.Field<String>("name");
            label2.Text = dr.Field<String>("description");
            label3.Text = dr.Field<String>("usage");
            label4.Text = dr.Field<String>("dosage");
            Unit.Text = dr.Field<String>("unit");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete medicine
            dbHandler.setData("delete from medicine_inventry where medicine_id = " + id);
            dbHandler.setData("delete from Medicines where Id = " + id, "Deleted Successful Please Refresh");
        }
    }
}
