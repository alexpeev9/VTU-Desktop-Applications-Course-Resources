namespace FavoriteListApp
{
    using System.Linq;
    using System.Windows.Forms;
    
    using FavoriteListApp.Database;
    using FavoriteListApp.Database.Models;
    using FavoriteListApp.Helpers;

    public partial class RegisterForm : Form
    {
        private readonly AppDbContext appDbContext;
        public RegisterForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            this.appDbContext = appDbContext;
            this.PasswordInput.PasswordChar = '*';
			this.RepeatPasswordInput.PasswordChar = '*';
		}

		private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm registerForm = new LoginForm(appDbContext);
            registerForm.Show();
            Hide();
        }

        private async void RegisterButton_Click(object sender, System.EventArgs e)
        {
			string username = this.UsernameInput.Text;
			string password = this.PasswordInput.Text;
			string repeatPassword = this.RepeatPasswordInput.Text;

			if (string.IsNullOrWhiteSpace(username)
				|| string.IsNullOrWhiteSpace(password)
				|| string.IsNullOrWhiteSpace(repeatPassword))
			{
				MessageBox.Show("Please, fill all inputs!");

				return;
			}

			if (password != repeatPassword)
			{
				MessageBox.Show("Passwords must match!");

				return;
			}

			bool isUserExist = appDbContext.Users
				.Any(u => u.Username == username);

			if (isUserExist)
			{
				MessageBox.Show("Username is already taken!");

				return;
			}

			string salt = PasswordManager.GenerateSalt();
			string hashedPassword = PasswordManager.HashPassword(password, salt);

			User user = new User()
			{
				Username = username,
				PasswordHash = hashedPassword,
				Salt = salt,
			};

			await this.appDbContext.Users.AddAsync(user);
			await this.appDbContext.SaveChangesAsync();

			LoginForm loginForm = new LoginForm(appDbContext);
			loginForm.Show();
			Hide();
		}

    }
}
