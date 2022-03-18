using DailyTasksApplication.Database;
using DailyTasksApplication.Database.Models;
using DailyTasksApplication.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTasksApplication
{
    public partial class Register : Form
    {
        private readonly DailyTasksDbContext dbContext;
        public Register(DailyTasksDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.PasswordInput.PasswordChar = '*';
            this.RepeatPasswordInput.PasswordChar = '*';
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = this.UsernameInput.Text;
            string password = this.PasswordInput.Text;
            string repeatPassword = this.RepeatPasswordInput.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repeatPassword))
            {
                MessageBox.Show("Please, fill all inputs!");

                return;
            }

            if(password != repeatPassword)
            {
                MessageBox.Show("Passwords must match!");

                return;
            }

            bool isUserExist = dbContext.Users.Any(u => u.Username == username);

            if(isUserExist)
            {
                MessageBox.Show("Username already exists!");

                return;
            }

            string salt = PasswordManager.GenerateSalt();
            string hashedPassword = PasswordManager.HashPassword(password, salt);

            User user = new User()
            {
                Username = username,
                PasswordHash = hashedPassword,
                Salt = salt
            };

            await this.dbContext.Users.AddAsync(user);
            await this.dbContext.SaveChangesAsync();

            DailyTasks dailyTasks = new DailyTasks(this.dbContext, user.Id);
            dailyTasks.Show();
            this.Hide();
        }

        private void LoginTextButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login(dbContext);
            loginForm.Show();
            this.Close();
        }
    }
}
