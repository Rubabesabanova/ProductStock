﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.Controls
{
    public partial class LoginControl : Form
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        private void llblLoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterControl registerControl = new RegisterControl(this);
            registerControl.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool IsExist = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                var users = context.Users.ToList();
                foreach (User user in users)
                {
                    if (user.Email == this.txbLoginEmail.Text && user.Password == this.txbLoginPassword.Text)
                    {
                        MessageBox.Show("Successfully Logined!");
                        EntryControl.CurrentUser = user;
                        EntryControl entryControl = new EntryControl(this);
                        entryControl.ShowDialog();
                        IsExist = true;
                        break;
                    }
                }
                if (!IsExist)
                {
                    MessageBox.Show("Email or password is wrong! Please try again!");
                }
            }
               
        }

        
    }
}
