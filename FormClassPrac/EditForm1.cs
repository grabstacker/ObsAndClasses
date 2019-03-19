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
    class EditForm1
    {
        TextBox _txtBox = new TextBox();
        public EditForm1()
        {
           
        }

        public void editForm(TextBox txtBox)
        {
            this._txtBox = txtBox;
            _txtBox.Text = "Hello";

            
        }

    }

}
