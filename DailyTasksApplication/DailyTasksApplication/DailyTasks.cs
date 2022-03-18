using DailyTasksApplication.Database;
using DailyTasksApplication.Database.Models;
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

namespace DailyTasksApplication
{
    public partial class DailyTasks : Form
    {
        private readonly DailyTasksDbContext dbContext;
        private readonly int userId;
        private int taskId;
        public DailyTasks(DailyTasksDbContext dbContext, int userId)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.userId = userId;
            DisplayView();
            PopulateView();
            taskId = 0;
        }

        private void DisplayView()
        {
            this.TaskGridView.ColumnCount = 5;
            this.TaskGridView.Columns[0].Name = "Id";
            this.TaskGridView.Columns[1].Name = "Title";
            this.TaskGridView.Columns[2].Name = "IsDone";
            this.TaskGridView.Columns[3].Name = "Date";
            this.TaskGridView.Columns[4].Name = "Creator";
        }
        private void PopulateView()
        {
            this.TaskGridView.Rows.Clear();
            var tasks = this.dbContext.Tasks.Include(t => t.User).Select(t => new Database.Models.Task
            {
                Id = t.Id,
                Title = t.Title,
                IsDone = t.IsDone,
                CreatedAt = t.CreatedAt,
                User = new User
                {
                    Username = t.User.Username
                }
            }).ToList();
            foreach (var task in tasks)
            {
                string[] currentRow = { task.Id.ToString(), task.Title, task.IsDone.ToString(), task.CreatedAt.Date.ToString(), task.User.Username };
                this.TaskGridView.Rows.Add(currentRow);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var task = new Database.Models.Task();
            task.Title = this.TitleTextBox.Text;
            task.Description = this.DescriptionTextBox.Text;
            task.UserId = this.userId;
            if (this.TrueCheckBox.Checked)
            {
                task.IsDone = true;
            }
            else
            {
                task.IsDone = false;
            }
            this.dbContext.Tasks.Add(task);
            this.dbContext.SaveChanges();

            PopulateView();
            this.Clear();
        }

        private void Clear()
        {
            this.TitleTextBox.Text = "";
            this.DescriptionTextBox.Text = "";
            this.TrueCheckBox.Checked = false;
            this.FalseCheckBox.Checked = false;
            this.taskId = 0;
        }

        private void TrueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TrueCheckBox.Checked)
            {
                this.TrueCheckBox.Checked = true;
                if (this.FalseCheckBox.Checked)
                {
                    this.FalseCheckBox.Checked = false;
                }
            }
        }

        private void FalseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FalseCheckBox.Checked)
            {
                this.FalseCheckBox.Checked = true;
                if (this.TrueCheckBox.Checked)
                {
                    this.TrueCheckBox.Checked = false;
                }
            }
        }

        private void TaskGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Clear();
            int rowIndex = e.RowIndex;
            int id = int.Parse(this.TaskGridView.Rows[rowIndex].Cells[0].Value.ToString());
            var task = this.dbContext.Tasks.Find(id);

            this.taskId = task.Id;
            this.TitleTextBox.Text = task.Title;
            this.DescriptionTextBox.Text = task.Description;
            if (task.IsDone == true)
            {
                this.TrueCheckBox.Checked = true;
            }
            else
            {
                this.FalseCheckBox.Checked = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.taskId != 0)
            {
                var task = this.dbContext.Tasks.Find(this.taskId);
                task.Title = this.TitleTextBox.Text;
                task.Description = this.DescriptionTextBox.Text;
                if (this.TrueCheckBox.Checked)
                {
                    task.IsDone = true;
                }
                else
                {
                    task.IsDone = false;
                }
                this.dbContext.Tasks.Update(task);
                this.dbContext.SaveChanges();
                this.Clear();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this.dbContext);
            loginForm.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.taskId != 0)
            {
                var task = this.dbContext.Tasks.Find(taskId);
                this.dbContext.Remove(task);
                this.dbContext.SaveChanges();

                this.Clear();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
    }
}
