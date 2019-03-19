using System;
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
    public partial class Form2 : Form
    {
        EditForm1 edit = new EditForm1();
        TextBox _txtBox1;
        public Form2(TextBox txtbox1)
        {
            InitializeComponent();
            _txtBox1 = txtbox1;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            edit.editForm(_txtBox1);
        }
    }
}
