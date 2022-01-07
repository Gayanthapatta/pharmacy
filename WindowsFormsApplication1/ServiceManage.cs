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
    public partial class ServiceManage : Form
    {
        private DatabaseHandler dbHandler;
        public ServiceManage()
        {
            InitializeComponent();
        }

        private void ServiceManage_Load(object sender, EventArgs e)
        {
            dbHandler = new DatabaseHandler();
            load_page_data();
        }

        private void load_page_data()
        {
            panel2.Controls.Clear();
            String sql_quer = "select * from services";
            DataSet ds = dbHandler.getData(sql_quer);
            DataRow[] drs = ds.Tables[0].Select();
            foreach (DataRow dr in drs)
            {
                ServiceLabelForm slf = new ServiceLabelForm(dr.Field<int>("id"), dr.Field<String>("service_name"), dr.Field<String>("service_description"), dr.Field<decimal>("service_income"), dr.Field<decimal>("service_cost"));
                slf.Dock = DockStyle.Top;
                panel2.Controls.Add(slf);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_page_data();
        }
    }
}
