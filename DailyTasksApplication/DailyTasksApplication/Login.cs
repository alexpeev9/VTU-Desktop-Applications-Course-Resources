namespace DailyTasksApplication
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using DailyTasksApplication.Database;
    using DailyTasksApplication.Database.Models;
    using DailyTasksApplication.Helpers;
    using Microsoft.EntityFrameworkCore;

    public partial class Login : Form
    {
        private readonly DailyTasksDbContext dbContext;
        public Login(DailyTasksDbContext dbContext)
        {
            InitializeComponent();
            this.PasswordInput.PasswordChar = '*';
            this.dbContext = dbContext;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.UsernameInput.Text;
            string password = this.PasswordInput.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please, fill all inputs!");

                return;
            }

            User user = await dbContext.Users.SingleOrDefaultAsync(u => u.Username == username);

            if(user == null)
            {
                MessageBox.Show("This user doesn't exist!");
                return;
            }

            string hashedPassword = PasswordManager.HashPassword(password, user.Salt);

            if(hashedPassword != user.PasswordHash)
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            DailyTasks dailyTasksForm = new DailyTasks(dbContext, user.Id);
            dailyTasksForm.Show();
            this.Hide();
        }

        private void RegisterTextButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register(dbContext);
            registerForm.Show();
            this.Hide();
        }
    }
}
