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
    public partial class checkstatus : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        string str;

        public checkstatus()
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1285; Password=User123; Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                    MessageBox.Show("Connection Success");
                    
                    if (ano.Text != "")
                    {
                        com.Connection = con;
                        com.CommandText = "select status from leave where ano='" + ano.Text + "' ";
                        str = Convert.ToString(com.ExecuteScalar());
                        com.Dispose();
                        MessageBox.Show("Your Leave Application status is : " + (str));

                    }
                    else
                    {
                        MessageBox.Show("Plzzz insert application no ");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }

            
        }

        private void ano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
