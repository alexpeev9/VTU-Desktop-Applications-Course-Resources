
namespace CarFormAppSecondGroup
{
	partial class HomeForm
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
			this.GreetingMessage = new System.Windows.Forms.Label();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GreetingMessage
			// 
			this.GreetingMessage.AutoSize = true;
			this.GreetingMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GreetingMessage.Location = new System.Drawing.Point(615, 27);
			this.GreetingMessage.Name = "GreetingMessage";
			this.GreetingMessage.Size = new System.Drawing.Size(184, 46);
			this.GreetingMessage.TabIndex = 0;
			this.GreetingMessage.Text = "Hello User!";
			// 
			// LogoutButton
			// 
			this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LogoutButton.Location = new System.Drawing.Point(833, 20);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(150, 58);
			this.LogoutButton.TabIndex = 1;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 544);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.GreetingMessage);
			this.Name = "HomeForm";
			this.Text = "HomeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label GreetingMessage;
		private System.Windows.Forms.Button LogoutButton;
	}
}