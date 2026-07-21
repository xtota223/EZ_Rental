namespace ARMSWinDesktopClient
{
    partial class deleteForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            searchTargetCreditCardNumberLabel = new Label();
            searchPromptLabel = new Label();
            titleLabel = new Label();
            panel2 = new Panel();
            deleteExitButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(searchTargetCreditCardNumberLabel);
            panel1.Controls.Add(searchPromptLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 122);
            panel1.TabIndex = 5;
            // 
            // searchTargetCreditCardNumberLabel
            // 
            searchTargetCreditCardNumberLabel.AutoSize = true;
            searchTargetCreditCardNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchTargetCreditCardNumberLabel.Location = new Point(26, 90);
            searchTargetCreditCardNumberLabel.Name = "searchTargetCreditCardNumberLabel";
            searchTargetCreditCardNumberLabel.Size = new Size(118, 15);
            searchTargetCreditCardNumberLabel.TabIndex = 3;
            searchTargetCreditCardNumberLabel.Text = "Credit Card Number";
            // 
            // searchPromptLabel
            // 
            searchPromptLabel.AutoSize = true;
            searchPromptLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            searchPromptLabel.Location = new Point(25, 55);
            searchPromptLabel.Name = "searchPromptLabel";
            searchPromptLabel.Size = new Size(230, 15);
            searchPromptLabel.TabIndex = 2;
            searchPromptLabel.Text = "Enter Credit Card Number & Click Delete:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(15, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(149, 21);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Credit Card Delete";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(deleteExitButton);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 50);
            panel2.TabIndex = 6;
            // 
            // deleteExitButton
            // 
            deleteExitButton.BackColor = Color.PeachPuff;
            deleteExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteExitButton.Location = new Point(198, 12);
            deleteExitButton.Name = "deleteExitButton";
            deleteExitButton.Size = new Size(75, 23);
            deleteExitButton.TabIndex = 3;
            deleteExitButton.Text = "Exit";
            deleteExitButton.UseVisualStyleBackColor = false;
            deleteExitButton.Click += deleteExitButton_Click;
            // 
            // deleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(315, 196);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "deleteForm";
            Text = "Credit Card Delete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label titleLabel;
        private Label searchPromptLabel;
        private Label searchTargetCreditCardNumberLabel;
        private Panel panel2;
        private Button deleteExitButton;
    }
}