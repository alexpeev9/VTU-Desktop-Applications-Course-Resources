namespace FavoriteListApp
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    
    using Database;
    using Database.Models;
    using Helpers;
    using Microsoft.EntityFrameworkCore;

    public partial class LoginForm : Form
    {
        private readonly AppDbContext appDbContext;
        public LoginForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            this.appDbContext = appDbContext;
            this.PasswordBox.PasswordChar = '*';
        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(appDbContext);
            registerForm.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.UsernameInput.Text;
            string password = this.PasswordBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please, fill all inputs!");

                return;
            }

            User user = appDbContext.Users
                .SingleOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("This user doesn't exist!");

                return;
            }

            string hashedPassword = PasswordManager.HashPassword(password, user.Salt);

            if (hashedPassword != user.PasswordHash)
            {
                MessageBox.Show("Incorrect credentials!");

                return;
            }

            HomeForm calculatorForm = new HomeForm(this.appDbContext, user.Username);
            calculatorForm.Show();
            Hide();
        }
    }
}
