namespace FavoriteListApp
{
    using System;
    using System.Windows.Forms;

    using FavoriteListApp.Database;
    public partial class HomeForm : Form
    {
        private readonly AppDbContext appDbContext;
        public HomeForm(AppDbContext appDbContext, String username)
        {
            InitializeComponent();
            this.appDbContext = appDbContext;
            this.GreetMessage.Text = $"Hello, {username}!";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(appDbContext);
            loginForm.Show();
            Hide();
        }
    }
}
