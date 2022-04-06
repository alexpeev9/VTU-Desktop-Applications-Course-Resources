using CarFormAppSecondGroup.Database;
using CarFormAppSecondGroup.Database.Model;
using CarFormAppSecondGroup.Helpers;
using Microsoft.EntityFrameworkCore;
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
	public partial class LoginForm : Form
	{
		private readonly CarDbContext dbContext;
		public LoginForm(CarDbContext dbContext)
		{
			InitializeComponent();
			this.PasswordBox.PasswordChar = '*';
			this.dbContext = dbContext;
		}

		private async void LoginButton_Click(object sender, EventArgs e)
		{
			var username = UsernameBox.Text;
			var password = PasswordBox.Text;
			if (string.IsNullOrWhiteSpace(username) || 
				string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Please fill all inputs");
				return;
			}


			User user = await dbContext.Users.SingleOrDefaultAsync(u => u.Username == username);
			if(user == null)
			{
				MessageBox.Show("User doesn't exist");
				return;
			}
			string hashedPassword = PasswordManager.HashPassword(password, user.Salt);
			
			UsernameBox.Text = "";
			PasswordBox.Text = "";

			if (user.PasswordHash != hashedPassword)
			{
				MessageBox.Show("Passwords don't match!");
				return;
			}
			HomeForm homeForm = new HomeForm(dbContext, user.Id, user.Username);
			homeForm.Show();
			this.Hide();
		}

		private void RegisterRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegisterForm registerForm = new RegisterForm(dbContext);
			registerForm.Show();
			this.Hide();
		}
	}
}
