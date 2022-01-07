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
    public partial class AdminstratorForm : Form
    {
        public AdminstratorForm()
        {
            InitializeComponent();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SignInForm fm =new SignInForm();
            fm.Show();
            Properties.Settings.Default.UserID = 0;
            Properties.Settings.Default.UserRole = null;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 fm = new Form2();
            //fm.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUsersForm fm = new AddUsersForm();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ViewUsersForm am = new ViewUsersForm();
            am.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileForm am = new ProfileForm();
            am.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PharmasistDashboardForm am = new PharmasistDashboardForm();
            am.Show();
            this.Hide();
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;
            Properties.Settings.Default.UserRole = null;
            SignInForm sf = new SignInForm();
            sf.Visible = true;
            this.Hide();
        }
    }
}
