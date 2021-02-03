using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DAL;
using ProductStock.DbContexts;
using ProductStock.Enums;
using ProductStock.Models;
using ProductStock.Validations;

namespace ProductStock.Controls
{
    public partial class RegisterControl : Form
    {
        public RegisterControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;

        public RegisterControl(Form form) : this()
        {
            _loginControl = form;
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = this.txbRegisterName.Text,
                Surname = this.txbRegisterSurname.Text,
                Email = this.txbRegisterEmail.Text,
                Password = this.txbRegisterPassword.Text,
                Phone = this.txbRegisterPhone.Text,
                Type = (int) UserTypeEnum.User,
            };
            bool isValid= ValidationOperation<User>.ValidateOperation(user);
            bool IsUnique = EmailValidation.IsUniqueEmail(user);
            if (IsUnique)
            {
                if (isValid)
                {
                    UserDAL userDAL = new UserDAL();
                    userDAL.Add(user);
                    MessageBox.Show("Successfully Registered!");

                }
            }
            else
            {
                MessageBox.Show("The email is already used.");
            }
            this.Close();
            

        }

        private void llblRegisterLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginControl loginControl = new LoginControl();
            loginControl.ShowDialog();
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            UserDAL userDAL = new UserDAL();
            userDAL.Show();
        }

       
    }

    
}
