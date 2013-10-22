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
    public partial class applicationform : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        Int32 count;

        public applicationform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            optionpage c = new optionpage();
            c.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & u_id.Text != "" & desig.Text != "" & sdate.Text != "" & edate.Text != "" & reason.Text != "")
            {
                count = count + 1;
                status.Text = "Pending";
                com.Connection = con;
                com.CommandText = "insert into leave(ano,name,u_id,desig,sdate,edate,reason,status) values ('" + count + "','" + name.Text + "','" + u_id.Text + "','" + desig.Text + "','" + sdate.Text + "','" + edate.Text + "','" + reason.Text + "','" + status.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("YOUR LEAVE APPLICATION HAS BEEN SUBMITTED");
                MessageBox.Show("Your Leave Application No is : " + (count));

                homepage c = new homepage();
                c.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }

        }

        private void applicationform_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1285; Password=User123; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("Connection Success");
                      com.Connection = con;
                      com.CommandText = "select max(ano) from leave";
                      count = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
