
namespace DailyTasksApplication
{
    partial class DailyTasks
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
            this.TitleInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextArea = new System.Windows.Forms.TextBox();
            this.TrueCheckBox = new System.Windows.Forms.CheckBox();
            this.FalseCheckBox = new System.Windows.Forms.CheckBox();
            this.DailyTasksView = new System.Windows.Forms.DataGridView();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DailyTasksView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleInput
            // 
            this.TitleInput.AutoSize = true;
            this.TitleInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleInput.Location = new System.Drawing.Point(27, 61);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(49, 28);
            this.TitleInput.TabIndex = 0;
            this.TitleInput.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "IsDone";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.Location = new System.Drawing.Point(164, 58);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(193, 34);
            this.TitleTextBox.TabIndex = 3;
            // 
            // DescriptionTextArea
            // 
            this.DescriptionTextArea.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextArea.Location = new System.Drawing.Point(164, 132);
            this.DescriptionTextArea.Multiline = true;
            this.DescriptionTextArea.Name = "DescriptionTextArea";
            this.DescriptionTextArea.Size = new System.Drawing.Size(423, 126);
            this.DescriptionTextArea.TabIndex = 4;
            // 
            // TrueCheckBox
            // 
            this.TrueCheckBox.AutoSize = true;
            this.TrueCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrueCheckBox.Location = new System.Drawing.Point(164, 303);
            this.TrueCheckBox.Name = "TrueCheckBox";
            this.TrueCheckBox.Size = new System.Drawing.Size(67, 29);
            this.TrueCheckBox.TabIndex = 5;
            this.TrueCheckBox.Text = "True";
            this.TrueCheckBox.UseVisualStyleBackColor = true;
            this.TrueCheckBox.CheckedChanged += new System.EventHandler(this.TrueCheckBox_CheckedChanged);
            // 
            // FalseCheckBox
            // 
            this.FalseCheckBox.AutoSize = true;
            this.FalseCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FalseCheckBox.Location = new System.Drawing.Point(268, 303);
            this.FalseCheckBox.Name = "FalseCheckBox";
            this.FalseCheckBox.Size = new System.Drawing.Size(72, 29);
            this.FalseCheckBox.TabIndex = 6;
            this.FalseCheckBox.Text = "False";
            this.FalseCheckBox.UseVisualStyleBackColor = true;
            this.FalseCheckBox.CheckedChanged += new System.EventHandler(this.FalseCheckBox_CheckedChanged);
            // 
            // DailyTasksView
            // 
            this.DailyTasksView.AllowUserToAddRows = false;
            this.DailyTasksView.AllowUserToDeleteRows = false;
            this.DailyTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DailyTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyTasksView.Location = new System.Drawing.Point(632, 61);
            this.DailyTasksView.Name = "DailyTasksView";
            this.DailyTasksView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DailyTasksView.RowTemplate.Height = 25;
            this.DailyTasksView.Size = new System.Drawing.Size(475, 320);
            this.DailyTasksView.TabIndex = 7;
            this.DailyTasksView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DailyTasksView_RowHeaderMouseClick);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Lime;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(27, 374);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(112, 41);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(173, 374);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 41);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(317, 374);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 41);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearFormButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFormButton.Location = new System.Drawing.Point(462, 374);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(125, 41);
            this.ClearFormButton.TabIndex = 11;
            this.ClearFormButton.Text = "Clear Form";
            this.ClearFormButton.UseVisualStyleBackColor = false;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // DailyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DailyTasksView);
            this.Controls.Add(this.FalseCheckBox);
            this.Controls.Add(this.TrueCheckBox);
            this.Controls.Add(this.DescriptionTextArea);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleInput);
            this.Name = "DailyTasks";
            this.Text = "DailyTasks Form";
            ((System.ComponentModel.ISupportInitialize)(this.DailyTasksView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextArea;
        private System.Windows.Forms.CheckBox TrueCheckBox;
        private System.Windows.Forms.CheckBox FalseCheckBox;
        private System.Windows.Forms.DataGridView DailyTasksView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearFormButton;
    }
}