using BookApp.DbContext;
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
	public partial class BookForm : Form
	{
		private readonly BookDbContext bookDbContext;
		private readonly int userId;
		private int bookId;
		public BookForm(BookDbContext bookDbContext, int userId)
		{
			this.bookDbContext = bookDbContext;
			this.userId = userId;
			InitializeComponent();
			DisplayForm();
			PopulateForm();
		}

		private void DisplayForm()
		{
			this.BookGridView.ColumnCount = 5;
			this.BookGridView.Columns[0].Name = "Id";
			this.BookGridView.Columns[1].Name = "Title";
			this.BookGridView.Columns[2].Name = "Release Year";
			this.BookGridView.Columns[3].Name = "Created At";
			this.BookGridView.Columns[4].Name = "Creator";
		}
		private void ClearForm()
		{
			this.TitleTextBox.Text = "";
			this.YearTextBox.Text = "";
		}
		private void PopulateForm()
		{
			this.BookGridView.Rows.Clear();
			List<Book> books = bookDbContext.Books.Include(b => b.User).ToList();
			foreach(var book in books)
			{
				string[] currentRow = { book.Id.ToString(), book.Title, book.ReleaseYear.ToString(), book.CreatedAt.ToString(), book.User.Username };
				this.BookGridView.Rows.Add(currentRow);
			}
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
			this.ClearForm();
			this.PopulateForm();
		}

		private void BookGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.ClearForm();
			int rowIndex = e.RowIndex;
			int id = int.Parse(this.BookGridView.Rows[rowIndex].Cells[0].Value.ToString());
			this.bookId = id;
			var currentBook = this.bookDbContext.Books.Find(id);
			this.TitleTextBox.Text = currentBook.Title;
			this.YearTextBox.Text = currentBook.ReleaseYear.ToString();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			var book = this.bookDbContext.Books.Find(bookId);
			book.Title = this.TitleTextBox.Text;
			book.ReleaseYear = int.Parse(this.YearTextBox.Text);
			this.bookDbContext.Update(book);
			this.bookDbContext.SaveChanges();
			this.ClearForm();
			this.PopulateForm();
		}
	}
}
