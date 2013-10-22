using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLMS_v1
{
    public partial class optionpage : Form
    {
        public optionpage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            applicationform c = new applicationform();
            c.Show();
            Hide();
        }

        private void NewRegistration_Click(object sender, EventArgs e)
        {
            checkstatus c = new checkstatus();
            c.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage c = new homepage();
            c.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void optionpage_Load(object sender, EventArgs e)
        {

        }
    }
}
