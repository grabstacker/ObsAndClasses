﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClassPrac
{
    
    public partial class Form1 : Form
    {

        Form2 form2;
        
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this.txtBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
