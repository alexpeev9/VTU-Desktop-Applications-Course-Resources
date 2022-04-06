
namespace CarFormAppSecondGroup
{
	partial class RegisterForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.Username = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.LoginRedirect = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(309, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "Register";
			// 
			// UsernameBox
			// 
			this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameBox.Location = new System.Drawing.Point(345, 187);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(251, 63);
			this.UsernameBox.TabIndex = 1;
			// 
			// PasswordBox
			// 
			this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordBox.Location = new System.Drawing.Point(345, 289);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new System.Drawing.Size(251, 63);
			this.PasswordBox.TabIndex = 2;
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Username.Location = new System.Drawing.Point(71, 182);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(249, 67);
			this.Username.TabIndex = 3;
			this.Username.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(87, 284);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 67);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 378);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(308, 67);
			this.label3.TabIndex = 6;
			this.label3.Text = "Re-Password";
			// 
			// RepeatPasswordBox
			// 
			this.RepeatPasswordBox.AcceptsReturn = true;
			this.RepeatPasswordBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RepeatPasswordBox.Location = new System.Drawing.Point(345, 394);
			this.RepeatPasswordBox.Name = "RepeatPasswordBox";
			this.RepeatPasswordBox.Size = new System.Drawing.Size(251, 63);
			this.RepeatPasswordBox.TabIndex = 5;
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(263, 495);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(217, 65);
			this.RegisterButton.TabIndex = 7;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// LoginRedirect
			// 
			this.LoginRedirect.AutoSize = true;
			this.LoginRedirect.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LoginRedirect.Location = new System.Drawing.Point(120, 590);
			this.LoginRedirect.Name = "LoginRedirect";
			this.LoginRedirect.Size = new System.Drawing.Size(506, 57);
			this.LoginRedirect.TabIndex = 17;
			this.LoginRedirect.TabStop = true;
			this.LoginRedirect.Text = "If you are registered login";
			this.LoginRedirect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginRedirect_LinkClicked);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 674);
			this.Controls.Add(this.LoginRedirect);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RepeatPasswordBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.UsernameBox);
			this.Controls.Add(this.label1);
			this.Name = "RegisterForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox RepeatPasswordBox;
		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.LinkLabel LoginRedirect;
	}
}

