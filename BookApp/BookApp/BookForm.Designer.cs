﻿
namespace BookApp
{
	partial class BookForm
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
			this.bookHeader = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.YearTextBox = new System.Windows.Forms.TextBox();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.CreateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bookHeader
			// 
			this.bookHeader.AutoSize = true;
			this.bookHeader.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bookHeader.Location = new System.Drawing.Point(235, 41);
			this.bookHeader.Name = "bookHeader";
			this.bookHeader.Size = new System.Drawing.Size(245, 67);
			this.bookHeader.TabIndex = 0;
			this.bookHeader.Text = "Book App";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(129, 247);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(211, 46);
			this.PasswordLabel.TabIndex = 18;
			this.PasswordLabel.Text = "Release Year:";
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(129, 150);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(91, 46);
			this.UsernameLabel.TabIndex = 17;
			this.UsernameLabel.Text = "Title:";
			// 
			// YearTextBox
			// 
			this.YearTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.YearTextBox.Location = new System.Drawing.Point(380, 240);
			this.YearTextBox.Name = "YearTextBox";
			this.YearTextBox.Size = new System.Drawing.Size(238, 56);
			this.YearTextBox.TabIndex = 16;
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleTextBox.Location = new System.Drawing.Point(380, 140);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(238, 56);
			this.TitleTextBox.TabIndex = 15;
			// 
			// CreateButton
			// 
			this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CreateButton.Location = new System.Drawing.Point(257, 339);
			this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(190, 73);
			this.CreateButton.TabIndex = 14;
			this.CreateButton.Text = "Create";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// BookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.YearTextBox);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.bookHeader);
			this.Name = "BookForm";
			this.Text = "Book";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label bookHeader;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox YearTextBox;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Button CreateButton;
	}
}