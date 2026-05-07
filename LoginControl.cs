using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms02
{
    public partial class LoginControl : UserControl
    {
        public event Action? OpenRegister;
        public event Action<string, string>? OnLoginRequested;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegister?.Invoke();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            OnLoginRequested?.Invoke(email, password);
        }
    }
}
