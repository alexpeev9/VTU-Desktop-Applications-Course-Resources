namespace FavoriteListApp
{
    using System;
    using System.Windows.Forms;

    using FavoriteListApp.Database;

    using Microsoft.EntityFrameworkCore;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Database.Migrate();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(appDbContext));
        }
    }
}
