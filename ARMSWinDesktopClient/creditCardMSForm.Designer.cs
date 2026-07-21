namespace ARMSWinDesktopClient
{
    partial class creditCardMSForm
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
            titleLabel = new Label();
            searchButton = new Button();
            registrationButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            listButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(65, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(226, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Credit Card Management System portal";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(100, 50);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Credit Card Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += serarchButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(100, 95);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(150, 23);
            registrationButton.TabIndex = 2;
            registrationButton.Text = "Credit Card Registration";
            registrationButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(100, 140);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(150, 23);
            updateButton.TabIndex = 3;
            updateButton.Text = "Credit Card Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(100, 185);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Credit Card Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // listButton
            // 
            listButton.Location = new Point(100, 230);
            listButton.Name = "listButton";
            listButton.Size = new Size(150, 23);
            listButton.TabIndex = 5;
            listButton.Text = "Credit Card List";
            listButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(145, 280);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(70, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // creditCardMSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(360, 325);
            Controls.Add(exitButton);
            Controls.Add(listButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(registrationButton);
            Controls.Add(searchButton);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "creditCardMSForm";
            Text = "Credit Card Management System Portal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button searchButton;
        private Button registrationButton;
        private Button updateButton;
        private Button deleteButton;
        private Button listButton;
        private Button exitButton;
    }
}