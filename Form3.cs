﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOMANDA_A
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float sum = ;
            Form4 f4 = new KOMANDA_A.Form4();
            f4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new KOMANDA_A.Form4();
            f4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new KOMANDA_A.Form4();
            f4.Show();
            Hide();
        }

        /*private void button4_Click(object sender, EventArgs e)
        {

        }*/

    }
}
