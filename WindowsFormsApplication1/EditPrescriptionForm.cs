using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditPrescriptionForm : Form
    {
        private int id;
        private DatabaseHandler dbHandler;
        public EditPrescriptionForm(int id)
        {
            InitializeComponent();
            this.id = id;
            dbHandler = new DatabaseHandler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditPrescriptionForm_Load(object sender, EventArgs e)
        {
            String load_query = "select * from prescriptions where id = " + id;
            DataSet dss = dbHandler.getData(load_query);
            DataRow[] drs = dss.Tables[0].Select();
            if(drs.Length == 1)
            {
                textBox1.Text = drs[0].Field<String>("name");
                textBox2.Text = drs[0].Field<String>("address");
                textBox3.Text = drs[0].Field<String>("mobile");
                dateTimePicker1.Value = drs[0].Field<DateTime>("date");
                comboBox1.Text = drs[0].Field<String>("status");
            }
            else
            {
                MessageBox.Show("Multiple Prescriptions Received!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String f_date = dateTimePicker1.Value.ToShortDateString();
            String f_name = textBox1.Text;
            String f_address = textBox2.Text;
            String f_mobile = textBox3.Text;
            String status = comboBox1.Text;

            String update_query = "Update prescriptions set name = '"+f_name+"' , address = '"+f_address+"' , mobile = '"+f_mobile+"', date = '"+f_date+"',status = '"+status+"' where id =  " + id;
            try
            {
                dbHandler.setData(update_query, "Prescription Update Success!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }
    }
}
