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
    public partial class AddPrescriptionForm : Form
    {
        private List<ItemObject> medicineItems;
        private DatabaseHandler fnc;
        private List<returnObj> robj;
        public AddPrescriptionForm()
        {
            InitializeComponent();
            medicineItems = new List<ItemObject>();
            fnc = new DatabaseHandler();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uid = Properties.Settings.Default.UserID;
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && medicineItems.Count != 0) {
                String query = "insert into prescriptions(name,address,mobile,date,[user],status) output INSERTED.Id values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "'," + uid + ",'Peiding')";
                try
                {
                    int id = fnc.InsertWithIdentity(query);
                    //prescription added
                    foreach(ItemObject item in medicineItems)
                    {
                        String query2 = "insert into pres_med (medicine_id,prescription_id,quantity,price) values (" + item.itemID + "," + id + "," + item.quantity + "," + item.price + ")";
                        fnc.setData(query2);
                    }
                    MessageBox.Show("Successfully Created Prescription", "info");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add Item button
            returnObj oo = (returnObj)comboBox1.SelectedValue;
            //MessageBox.Show(oo.name);

            ItemObject iobj = new ItemObject();
            iobj.itemID = oo.itemID;
            iobj.itemName = oo.name;
            iobj.quantity = Decimal.Parse(textBox4.Text);
            iobj.price = Decimal.Parse(textBox5.Text);
            medicineItems.Add(iobj);
            listView1.Items.Clear();
            foreach (ItemObject medicine in medicineItems)
            {
                listView1.Items.Add(new ListViewItem(new String[] { medicine.itemID.ToString(), medicine.itemName, medicine.price.ToString(), medicine.quantity.ToString() }));
            }
            MessageBox.Show("Item Added!");
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            String sqlstr = "select id,name from Medicines";
            medicineItems = new List<ItemObject>();
            robj = new List<returnObj>();
            try
            {
                DataSet dss = fnc.getData(sqlstr);
                DataRow[] dr = dss.Tables[0].Select();
                for(int i = 0; i < dr.Length; i++)
                {
                    returnObj ro = new returnObj();
                    ro.itemID = dr[i].Field<int>("id");
                    ro.name = dr[i].Field<String>("name");

                    robj.Add(ro);
                }
                comboBox1.Items.Clear();
                comboBox1.DataSource = robj;
                comboBox1.DisplayMember = "name";

                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Quantity");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class returnObj
    {
        public int itemID { get; set; }
        public String name { get; set; }
    }
    public class ItemObject
    {
        public int itemID { get; set; }
        public String itemName { get; set; }
        public decimal quantity { get; set; }
        public decimal price { get; set; }
    }
}
