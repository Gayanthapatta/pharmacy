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
    public partial class PrescriptionLabelForm : UserControl
    {
        String name, address, date, mobile;
        DatabaseHandler dhndl;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlStr = "delete from pres_med where prescription_id = " + id;
                dhndl.setDataWithoutMessage(sqlStr);
                var second_deletion = "delete from prescriptions where id = " + id;
                dhndl.setData(second_deletion,"Deletion Successfull\nplease refresh your form");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Occured");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Info", "You can't change medicines in prescription", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //Show select dialog box
                EditPrescriptionForm epf = new EditPrescriptionForm(id);
                epf.Show();
            }
            else
            {
                MessageBox.Show("You can't Edit this prescription");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //View Complete Prescriptions form open
            ViewPrescriptionsForm vpf = new ViewPrescriptionsForm(id);
            vpf.Show();
        }

        int id;
        public PrescriptionLabelForm(int id,String name,String address,String date,String mobile)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.address = address;
            this.date = date;
            this.mobile = mobile;
        }

        private void PrescriptionLabelForm_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            label3.Text = address;
            label2.Text = date;
            label4.Text = mobile;
            dhndl = new DatabaseHandler();
        }
    }
}
