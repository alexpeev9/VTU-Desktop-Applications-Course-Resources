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
	public partial class BookForm : Form
	{
		private readonly BookDbContext bookDbContext;
		private readonly int userId;
		public BookForm(BookDbContext bookDbContext, int userId)
		{
			this.bookDbContext = bookDbContext;
			this.userId = userId;
			InitializeComponent();
		}

		private async void CreateButton_Click(object sender, EventArgs e)
		{
			string title = this.TitleTextBox.Text;
			string releaseYear = this.YearTextBox.Text;

			if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(releaseYear))
			{
				MessageBox.Show("Please, fill all inputs!");

				return;
			}

			Book book = new Book();
			book.Title = title;
			book.ReleaseYear = int.Parse(releaseYear);
			book.UserId = userId;

			await this.bookDbContext.Books.AddAsync(book);
			await this.bookDbContext.SaveChangesAsync();
		}
	}
}
