namespace ARMSWinDesktopClient
{
    partial class mainWelcomeForm
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
            titleLabel = new Label();
            posButton = new Button();
            erpButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(170, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(125, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "EZRental POS System";
            // 
            // posButton
            // 
            posButton.Location = new Point(84, 60);
            posButton.Name = "posButton";
            posButton.Size = new Size(293, 23);
            posButton.TabIndex = 1;
            posButton.Text = "Rental Point-of-Sales";
            posButton.UseVisualStyleBackColor = true;
            // 
            // erpButton
            // 
            erpButton.Location = new Point(84, 105);
            erpButton.Name = "erpButton";
            erpButton.Size = new Size(293, 23);
            erpButton.TabIndex = 2;
            erpButton.Text = "Enterprise Resource Planning (ERP) System Portal";
            erpButton.UseVisualStyleBackColor = true;
            erpButton.Click += erpButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(151, 150);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(163, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit Application";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // mainWelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(465, 195);
            Controls.Add(exitButton);
            Controls.Add(erpButton);
            Controls.Add(posButton);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "mainWelcomeForm";
            Text = "EZRental POS System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button posButton;
        private Button erpButton;
        private Button exitButton;
    }
}
