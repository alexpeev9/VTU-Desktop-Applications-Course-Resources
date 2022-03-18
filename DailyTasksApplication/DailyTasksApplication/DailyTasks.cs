using DailyTasksApplication.Database;
using DailyTasksApplication.Database.Models;
using DailyTasksApplication.Helpers;
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
        private int temporaryTaskId;
        public DailyTasks(DailyTasksDbContext dbContext, int userId)
        {
            InitializeComponent();
            this.temporaryTaskId = 0;
            this.dbContext = dbContext;
            this.userId = userId;
            DisplayViewRows();
            PopulateView();
        }

        private void DisplayViewRows()
        {
            this.DailyTasksView.ColumnCount = 5;
            this.DailyTasksView.Columns[0].Name = "Title";
            this.DailyTasksView.Columns[1].Name = "IsDone";
            this.DailyTasksView.Columns[2].Name = "Date";
            this.DailyTasksView.Columns[2].Name = "Creator";
            this.DailyTasksView.Columns[4].Name = "Id";

        }
        private void PopulateView()
        {
            DailyTasksView.Rows.Clear();
            var tasks = this.dbContext.Tasks.Include(t => t.User).Select( t => new Database.Models.Task { 
                                                                             Id = t.Id,
                                                                             Title = t.Title,
                                                                             Description = t.Description,
                                                                             IsDone = t.IsDone,
                                                                             CreatedAt = t.CreatedAt,
                                                                             User = new User
                                                                             {
                                                                                 Username = t.User.Username
                                                                             }
                                                                        }).ToList();
            foreach (var task in tasks)
            {
                string[] currentRow = { task.Title, task.IsDone.ToString(), task.CreatedAt.Date.ToString() , task.User.Username, task.Id.ToString() };
                this.DailyTasksView.Rows.Add(currentRow);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var task = new Database.Models.Task();
            task.Title = this.TitleTextBox.Text;
            task.Description = this.DescriptionTextArea.Text;
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
            this.ClearForm();
            this.PopulateView();
        }
        private void ClearForm()
        {
            this.TitleTextBox.Text = "";
            this.DescriptionTextArea.Text = "";
            this.TrueCheckBox.Checked = false;
            this.FalseCheckBox.Checked = false;

            this.temporaryTaskId = 0;
        }
        private void DailyTasksView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ClearForm();
            int rowIndex = e.RowIndex;
            string textId = this.DailyTasksView.Rows[rowIndex].Cells[4].Value.ToString();
            int id = int.Parse(textId);
            this.temporaryTaskId = id;
            var task = this.dbContext.Tasks.Find(id);
            this.TitleTextBox.Text = task.Title;
            this.DescriptionTextArea.Text = task.Description;
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
            if (temporaryTaskId != 0)
            {
                var taskDb = this.dbContext.Tasks.Find(this.temporaryTaskId);
                taskDb.Title = this.TitleTextBox.Text;
                taskDb.Description = this.DescriptionTextArea.Text;
                if(this.TrueCheckBox.Checked)
                {
                    taskDb.IsDone = true;
                }
                else
                {
                    taskDb.IsDone = false;
                }
                this.dbContext.Tasks.Update(taskDb);
                this.dbContext.SaveChanges();
                this.ClearForm();
                this.PopulateView();
            }
            else
            {
                MessageBox.Show("No Task was Selected.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.temporaryTaskId == 0)
            {
                MessageBox.Show("Please Select a Task");
            }
            else
            {
                var task = this.dbContext.Tasks.Find(this.temporaryTaskId);
                this.dbContext.Tasks.Remove(task);
                this.dbContext.SaveChanges();
                this.PopulateView();
            }
            ClearForm();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void TrueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TrueCheckBox.Checked == true)
            {
                this.TrueCheckBox.Checked = true;
                if(this.FalseCheckBox.Checked == true)
                {
                    this.FalseCheckBox.Checked = false;
                }
            }
        }

        private void FalseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // False
            if (this.FalseCheckBox.Checked == true)
            {
                this.FalseCheckBox.Checked = true;
                if(this.TrueCheckBox.Checked == true)
                {
                    this.TrueCheckBox.Checked = false;
                }
            }
        }
    }
}
