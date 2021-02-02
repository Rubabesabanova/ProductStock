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
                Password = this.txbRegisterPassword.Text
            };
            bool isValid= Validate(user);
            bool IsExist = ValidateEmail(user);
            if (!IsExist)
            {
                if (!isValid)
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
        static bool Validate(User user)
        {
            ValidationContext context = new ValidationContext(user);
            List<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage);
                    return false;
                }
            }
            return true;
        }
        static bool ValidateEmail(User user)
        {
            Type t = typeof(User);
            object[] attributes = t.GetCustomAttributes(false);
            foreach (EmailValidationAttribute attribute in attributes)
            {
                if (attribute.Emails.Contains(user.Email)) return false;
                else return true;
            }
            return false;
        }
    }
}
