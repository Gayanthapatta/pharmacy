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
    public partial class UserControl1 : UserControl
    {
        public UserControl1(DataRow dr)
        {
            InitializeComponent();
            label1.Text = dr.Field<String>("name");
            label2.Text = dr.Field<String>("description");
            label3.Text = dr.Field<String>("usage");
            label4.Text = dr.Field<String>("dosage");
            Unit.Text = dr.Field<String>("unit");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
