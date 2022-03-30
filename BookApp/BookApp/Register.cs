using BookApp.DbContext;
using BookApp.Helpers;
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

		private async void RegisterButton_Click(object sender, EventArgs e)
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

			string salt = PasswordManager.GenerateSalt();
			string hashedPassword = PasswordManager.HashPassword(password, salt);

			User user = new User()
			{
				Username = username,
				PasswordHash = hashedPassword,
				Salt = salt
			};

			await this.bookDbContext.Users.AddAsync(user);
			await this.bookDbContext.SaveChangesAsync();

			Login loginForm = new Login(bookDbContext);
            loginForm.Show();
            Hide();
        }
    }
}
