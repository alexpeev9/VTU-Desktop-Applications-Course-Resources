using CarFormAppSecondGroup.Database;
using CarFormAppSecondGroup.Database.Model;
using CarFormAppSecondGroup.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFormAppSecondGroup
{
	public partial class RegisterForm : Form
	{
		private readonly CarDbContext dbContext;
		public RegisterForm(CarDbContext dbContext)
		{
			this.dbContext = dbContext;
			InitializeComponent();
			this.RepeatPasswordBox.PasswordChar = '*';
			this.PasswordBox.PasswordChar = '*';
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			var username = UsernameBox.Text;
			var password = PasswordBox.Text;
			var repeatPassword = RepeatPasswordBox.Text;

			if (string.IsNullOrWhiteSpace(username) ||
				string.IsNullOrWhiteSpace(password) ||
				string.IsNullOrWhiteSpace(repeatPassword))
			{
				MessageBox.Show("Please fill all inputs");
				return;
			}


			UsernameBox.Text = "";
			PasswordBox.Text = "";
			RepeatPasswordBox.Text = "";

			if (password != repeatPassword)
			{
			    MessageBox.Show("Passwords don't match");
				return;
			}
			User user = new User();
			user.Username = username;
			var salt = PasswordManager.GenerateSalt();
			user.Salt = salt;
			user.PasswordHash = PasswordManager.HashPassword(password, salt);
			this.dbContext.Users.Add(user);
			this.dbContext.SaveChanges();
			MessageBox.Show("Great Success!");
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			this.Hide();
		}

		private void LoginRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			this.Hide();
		}
	}
}
