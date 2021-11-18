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
    public partial class ManagePrescriptionsForm : Form
    {
        private DatabaseHandler func;
        public ManagePrescriptionsForm()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            func = new DatabaseHandler();
            loadPageData();
        }

        private void loadPageData()
        {
            var sqlstr = "select * from prescriptions";
            try
            {
                DataSet dss = func.getData(sqlstr);
                DataRow[] dr = dss.Tables[0].Select();
                panel2.Controls.Clear();
                foreach (DataRow mdr in dr)
                {
                    PrescriptionLabelForm uc2 = new PrescriptionLabelForm(mdr.Field<int>("id"),mdr.Field<String>("name"), mdr.Field<String>("address"), mdr.Field<DateTime>("date").ToString(), mdr.Field<String>("mobile"));
                    uc2.Dock = DockStyle.Top;
                    panel2.Controls.Add(uc2);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadPageData();
        }
    }
}
