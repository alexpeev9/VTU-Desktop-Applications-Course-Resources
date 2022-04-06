using CarFormAppSecondGroup.Database;
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
	public partial class HomeForm : Form
	{
		private readonly CarDbContext dbContext;
		private string username;
		private Guid id;
		public HomeForm(CarDbContext dbContext, Guid id, string username)
		{
			this.dbContext = dbContext;
			InitializeComponent();
			this.username = username;
			this.id = id;
			this.GreetingMessage.Text = $"Hello, {username}!"; 
		}

		private void LogoutButton_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm(dbContext);
			loginForm.Show();
			this.username = "";
			this.Hide();
		}
	}
}
