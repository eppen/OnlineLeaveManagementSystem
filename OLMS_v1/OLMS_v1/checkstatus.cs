﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLMS_v1
{
    public partial class checkstatus : Form
    {
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
    }
}
