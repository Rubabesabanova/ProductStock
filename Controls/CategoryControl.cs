using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Controls
{
    public partial class CategoryControl : Form
    {
        public CategoryControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;


        public CategoryControl(Form form) : this()
        {
            _loginControl = form;
        }
    }
}
