
namespace CarFormAppSecondGroup
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoginButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RegisterRedirect = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LoginButton.Location = new System.Drawing.Point(264, 403);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(217, 65);
			this.LoginButton.TabIndex = 15;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(92, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 67);
			this.label2.TabIndex = 12;
			this.label2.Text = "Password";
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Username.Location = new System.Drawing.Point(76, 185);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(249, 67);
			this.Username.TabIndex = 11;
			this.Username.Text = "Username";
			// 
			// PasswordBox
			// 
			this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordBox.Location = new System.Drawing.Point(350, 292);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new System.Drawing.Size(251, 63);
			this.PasswordBox.TabIndex = 10;
			// 
			// UsernameBox
			// 
			this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameBox.Location = new System.Drawing.Point(350, 190);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(251, 63);
			this.UsernameBox.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(314, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 67);
			this.label1.TabIndex = 8;
			this.label1.Text = "Login";
			// 
			// RegisterRedirect
			// 
			this.RegisterRedirect.AutoSize = true;
			this.RegisterRedirect.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterRedirect.Location = new System.Drawing.Point(63, 528);
			this.RegisterRedirect.Name = "RegisterRedirect";
			this.RegisterRedirect.Size = new System.Drawing.Size(707, 57);
			this.RegisterRedirect.TabIndex = 16;
			this.RegisterRedirect.TabStop = true;
			this.RegisterRedirect.Text = "If you don\'t have an account register";
			this.RegisterRedirect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterRedirect_LinkClicked);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 625);
			this.Controls.Add(this.RegisterRedirect);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.UsernameBox);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel RegisterRedirect;
	}
}