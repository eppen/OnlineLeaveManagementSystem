using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OLMS_v1
{
    public partial class checkleave : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int64 count0;

        public checkleave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            com.Connection = con;
           // string p="Pending";

            com.CommandText = "select *  from leave where status='Pending' ";
          /*  Int32 ANO = Convert.ToInt32(com.Execute());
            com.CommandText = "select name  from leave where status='pending'";
            string NAME = Convert.ToString(com.ExecuteScalar());
            com.CommandText = "select sdate  from leave where status='pending'";
            string SDATE = Convert.ToString(com.ExecuteScalar());
            com.CommandText = "select edate  from leave where status='pending'";
            string EDATE = Convert.ToString(com.ExecuteScalar());
            com.CommandText = "select reason  from leave where status='pending'";
            string REASON = Convert.ToString(com.ExecuteScalar());
           
*/
             dr = com.ExecuteReader();
             dr.Read();
             //while (dr.Read())
             //{
                 //MessageBox.Show("u r in");
                  count0 = Convert.ToInt32(dr[0].ToString());
                 string count1 = Convert.ToString(dr.GetString(1));
                 string count4 = Convert.ToString(dr.GetString(4));
                 string count5 = Convert.ToString(dr.GetString(5));
                 string count6 = Convert.ToString(dr.GetString(6));
                 MessageBox.Show("\nApplication No: " + (count0) + "\nName: " + (count1) + "\nStart date: " + (count4) + "\nEnd date: " + (count5) + "\nReason: " + (count6));
             //}
             dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminlogin c = new adminlogin();
            c.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("\nagain no: " + (count0));
            com.CommandText = "update leave set status='Approved' where ano='"+count0+"' ";
            com.ExecuteNonQuery();
           // com.Dispose();
            MessageBox.Show("THE LEAVE APPLICATION HAS BEEN APPROVED");                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            com.CommandText = "update leave set status='Rejected' where ano='" + count0 + "' ";
            com.ExecuteNonQuery();
           // com.Dispose();
            MessageBox.Show("THE LEAVE APPLICATION HAS BEEN REJECTED");    
        }

        private void checkleave_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1285; Password=User123; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}
