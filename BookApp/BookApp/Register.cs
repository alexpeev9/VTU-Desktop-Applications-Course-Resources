using BookApp.DbContext;
using BookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
	public partial class Register : Form
	{
		private readonly BookDbContext bookDbContext;
        public Register(BookDbContext bookDbContext)
        {
            InitializeComponent();
			this.bookDbContext = bookDbContext;
			this.PasswordTextBox.PasswordChar = '*';
			this.RepeatPaswordTextBox.PasswordChar = '*';
        }

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			string username = this.UsernameTextBox.Text;
			string password = this.PasswordTextBox.Text;
			string repeatPassword = this.RepeatPaswordTextBox.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repeatPassword))
			{
				MessageBox.Show("Please fill all inputs.");
				return;
			}

			if(password != repeatPassword)
			{
				MessageBox.Show("Password do not match!");
				return;
			}
			User user = new User();
			user.Username = username;
			user.PasswordHash = password;
			user.Salt = "Today";
			this.bookDbContext.Users.Add(user);
			this.bookDbContext.SaveChanges();
            Login loginForm = new Login();
            loginForm.Show();
            Hide();
        }
    }
}
