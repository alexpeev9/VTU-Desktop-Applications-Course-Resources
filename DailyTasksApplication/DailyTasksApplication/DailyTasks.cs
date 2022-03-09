using DailyTasksApplication.Database;
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
        public DailyTasks(DailyTasksDbContext dbContext, int userId)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.userId = userId;
        }
    }
}
