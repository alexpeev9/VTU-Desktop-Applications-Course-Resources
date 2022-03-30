
namespace BookApp
{
    partial class Login
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
			this.LoginButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.RegisterLabel = new System.Windows.Forms.Label();
			this.RegisterLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LoginButton.Location = new System.Drawing.Point(328, 379);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(190, 73);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(200, 287);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(167, 46);
			this.PasswordLabel.TabIndex = 13;
			this.PasswordLabel.Text = "Password:";
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(200, 190);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(186, 46);
			this.UsernameLabel.TabIndex = 12;
			this.UsernameLabel.Text = "Username: ";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(451, 280);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(238, 56);
			this.PasswordTextBox.TabIndex = 11;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(451, 180);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(238, 56);
			this.UsernameTextBox.TabIndex = 10;
			// 
			// RegisterLabel
			// 
			this.RegisterLabel.AutoSize = true;
			this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterLabel.Location = new System.Drawing.Point(328, 33);
			this.RegisterLabel.Name = "RegisterLabel";
			this.RegisterLabel.Size = new System.Drawing.Size(202, 89);
			this.RegisterLabel.TabIndex = 9;
			this.RegisterLabel.Text = "Login";
			// 
			// RegisterLink
			// 
			this.RegisterLink.AutoSize = true;
			this.RegisterLink.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterLink.Location = new System.Drawing.Point(154, 512);
			this.RegisterLink.Name = "RegisterLink";
			this.RegisterLink.Size = new System.Drawing.Size(580, 46);
			this.RegisterLink.TabIndex = 14;
			this.RegisterLink.TabStop = true;
			this.RegisterLink.Text = "If you don\'t have an acc, register here";
			this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 600);
			this.Controls.Add(this.RegisterLink);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.RegisterLabel);
			this.Controls.Add(this.LoginButton);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label RegisterLabel;
		private System.Windows.Forms.LinkLabel RegisterLink;
	}
}

