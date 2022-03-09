namespace DailyTasksApplication
{
    using System;
    using System.Windows.Forms;

    using DailyTasksApplication.Database;

    using Microsoft.EntityFrameworkCore;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            DailyTasksDbContext dbContext = new DailyTasksDbContext();
            dbContext.Database.Migrate();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(dbContext));
        }
    }
}
