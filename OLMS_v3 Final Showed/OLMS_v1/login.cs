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
    public partial class login : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void submit_Click(object sender, EventArgs e)
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

            
            com.Connection = con;
            com.CommandText = "select pword  from profile where uname='"+ uname.Text+"' ";
            string pwd = Convert.ToString (com.ExecuteScalar());

            bool result=pwd.Equals(pword.Text,StringComparison.Ordinal);

            if (result)
            {
                optionpage c = new optionpage();
                c.Show();
                Hide();
            }
            else
            {
                uname.Text = "";
                pword.Text = "";
                MessageBox.Show("Invalid Credentials");
            }

        }
    }
}
