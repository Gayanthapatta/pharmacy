using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kemla-vs\WindowsFormsApplication1\Database1-g.mdf;Integrated Security=True";
            //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mars\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\pharmacysystem.mdf;Integrated Security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();//initialize connection
            SqlCommand cmd = new SqlCommand();//initialize command
            cmd.Connection = con;//introduce connection
            cmd.CommandText = query;//set query as command text
            SqlDataAdapter sda = new SqlDataAdapter(cmd);//introduce adapter for defined command
            DataSet ds = new DataSet();//initialize data set
            sda.Fill(ds);//fill data set from datas
            return ds;//retuen data set
        }

        public void setData(String query,String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();//open connection
            cmd.CommandText = query;
            var dt = cmd.ExecuteNonQuery();
            Console.WriteLine(dt);
            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
