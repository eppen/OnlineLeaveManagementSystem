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
        
    public partial class signup : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (uname.Text != "" & pword.Text != "" & name.Text != "" & u_id.Text != "" & desig.Text != "" & addr.Text != "" & mob.Text != "" & email.Text != "" )
            {
                com.Connection = con;
                com.CommandText = "insert into profile(uname,pword,name,u_id,desig,addr,mob,email) values ('" + uname.Text + "','" + pword.Text + "','" + name.Text + "','" + u_id.Text + "','" + desig.Text + "','" + addr.Text + "','" + mob.Text + "','" + email.Text + "')";
                com.ExecuteNonQuery();
                com.Dispose();
                MessageBox.Show("USER PROFILE MADE");
            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }

            login c = new login();
            c.Show();
            Hide();
        }

        private void signup_Load(object sender, EventArgs e)
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

        

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
