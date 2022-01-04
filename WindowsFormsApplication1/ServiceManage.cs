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
            String sql_quer = "select * from services";
            DataSet ds = dbHandler.getData(sql_quer);
            DataRow[] drs = ds.Tables[0].Select();
            foreach(DataRow dr in drs)
            {
                //ServiceLabelForm slf = new ServiceLabelForm();
                //slf.Dock = DockStyle.Top;
                //panel2.Controls.Add(slf);
            }
        }
    }
}
