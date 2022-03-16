
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
			this.RegisterButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RegisterButton
			// 
			this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.Location = new System.Drawing.Point(346, 465);
			this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(190, 73);
			this.RegisterButton.TabIndex = 0;
			this.RegisterButton.Text = "Login";
			this.RegisterButton.UseVisualStyleBackColor = true;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 600);
			this.Controls.Add(this.RegisterButton);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
    }
}

