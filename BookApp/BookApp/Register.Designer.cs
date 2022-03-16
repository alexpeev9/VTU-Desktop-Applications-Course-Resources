
namespace BookApp
{
    partial class Register
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
			this.RegisterButton = new System.Windows.Forms.Button();
			this.RegisterLabel = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.RepeatPasswordLabel = new System.Windows.Forms.Label();
			this.RepeatPaswordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(322, 474);
			this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(190, 73);
			this.RegisterButton.TabIndex = 1;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// RegisterLabel
			// 
			this.RegisterLabel.AutoSize = true;
			this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterLabel.Location = new System.Drawing.Point(300, 47);
			this.RegisterLabel.Name = "RegisterLabel";
			this.RegisterLabel.Size = new System.Drawing.Size(275, 89);
			this.RegisterLabel.TabIndex = 2;
			this.RegisterLabel.Text = "Register";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(423, 194);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(238, 56);
			this.UsernameTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(423, 294);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(238, 56);
			this.PasswordTextBox.TabIndex = 4;
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(172, 204);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(186, 46);
			this.UsernameLabel.TabIndex = 5;
			this.UsernameLabel.Text = "Username: ";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(172, 301);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(167, 46);
			this.PasswordLabel.TabIndex = 6;
			this.PasswordLabel.Text = "Password:";
			// 
			// RepeatPasswordLabel
			// 
			this.RepeatPasswordLabel.AutoSize = true;
			this.RepeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RepeatPasswordLabel.Location = new System.Drawing.Point(172, 389);
			this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
			this.RepeatPasswordLabel.Size = new System.Drawing.Size(218, 46);
			this.RepeatPasswordLabel.TabIndex = 8;
			this.RepeatPasswordLabel.Text = "Re-Password:";
			// 
			// RepeatPaswordTextBox
			// 
			this.RepeatPaswordTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RepeatPaswordTextBox.Location = new System.Drawing.Point(423, 379);
			this.RepeatPaswordTextBox.Name = "RepeatPaswordTextBox";
			this.RepeatPaswordTextBox.Size = new System.Drawing.Size(238, 56);
			this.RepeatPaswordTextBox.TabIndex = 7;
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 600);
			this.Controls.Add(this.RepeatPasswordLabel);
			this.Controls.Add(this.RepeatPaswordTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.RegisterLabel);
			this.Controls.Add(this.RegisterButton);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Register";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Label RegisterLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label RepeatPasswordLabel;
		private System.Windows.Forms.TextBox RepeatPaswordTextBox;
	}
}