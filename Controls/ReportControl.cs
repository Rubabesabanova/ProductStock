using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.Models;

namespace ProductStock.Controls
{
    public partial class ReportControl : Form
    {
        public static User CurrentUser { get; set; }
        public ReportControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;


        public ReportControl(Form form) : this()
        {
            _loginControl = form;
        }
    }
}
