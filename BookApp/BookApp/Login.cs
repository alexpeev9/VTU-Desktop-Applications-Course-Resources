using BookApp.DbContext;
using BookApp.Helpers;
using BookApp.Models;
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

namespace BookApp
{
    public partial class Login : Form
    {
		private readonly BookDbContext bookDbContext;
        public Login(BookDbContext bookDbContext)
        {
			this.bookDbContext = bookDbContext;
			InitializeComponent();
			this.PasswordTextBox.PasswordChar = '*';
		}

		private async void LoginButton_Click(object sender, EventArgs e)
        {
			string username = this.UsernameTextBox.Text;
			string password = this.PasswordTextBox.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Please, fill all inputs!");

				return;
			}

			User user = await bookDbContext.Users.SingleOrDefaultAsync(u => u.Username == username);

			if (user == null)
			{
				MessageBox.Show("This user doesn't exist!");
				return;
			}

			string hashedPassword = PasswordManager.HashPassword(password, user.Salt);

			if (hashedPassword != user.PasswordHash)
			{
				MessageBox.Show("Invalid Password!");
				return;
			}

			BookForm bookForm = new BookForm(bookDbContext, user.Id);
			bookForm.Show();
			this.Hide();
		}

		private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Register registerForm = new Register(bookDbContext);
			registerForm.Show();
			this.Hide();
		}
	}
}
