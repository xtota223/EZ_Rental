namespace ARMSWinDesktopClient
{
    partial class erpSystemForm
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
            creditCardButton = new Button();
            vehicleInventoryTransportationMaintananceMSButton = new Button();
            crmMSButton = new Button();
            hrMSButton = new Button();
            financeOperationsMSButton = new Button();
            marketingMSButton = new Button();
            customerFieldServiceMSButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(125, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(280, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Enterprise Resource Planning (ERP) System Portal";
            // 
            // creditCardButton
            // 
            creditCardButton.Location = new Point(20, 60);
            creditCardButton.Name = "creditCardButton";
            creditCardButton.Size = new Size(490, 23);
            creditCardButton.TabIndex = 1;
            creditCardButton.Text = "Credit Card Management System";
            creditCardButton.UseVisualStyleBackColor = true;
            creditCardButton.Click += creditCardButton_Click;
            // 
            // vehicleInventoryTransportationMaintananceMSButton
            // 
            vehicleInventoryTransportationMaintananceMSButton.Location = new Point(20, 105);
            vehicleInventoryTransportationMaintananceMSButton.Name = "vehicleInventoryTransportationMaintananceMSButton";
            vehicleInventoryTransportationMaintananceMSButton.Size = new Size(490, 23);
            vehicleInventoryTransportationMaintananceMSButton.TabIndex = 2;
            vehicleInventoryTransportationMaintananceMSButton.Text = "Vehicle Inventory,  Transportation & Maintenance Management System (Coming Soon)";
            vehicleInventoryTransportationMaintananceMSButton.UseVisualStyleBackColor = true;
            // 
            // crmMSButton
            // 
            crmMSButton.Location = new Point(20, 150);
            crmMSButton.Name = "crmMSButton";
            crmMSButton.Size = new Size(490, 23);
            crmMSButton.TabIndex = 3;
            crmMSButton.Text = "Customer Relationship Management (CRM) System (Coming Soon)";
            crmMSButton.UseVisualStyleBackColor = true;
            // 
            // hrMSButton
            // 
            hrMSButton.Location = new Point(20, 195);
            hrMSButton.Name = "hrMSButton";
            hrMSButton.Size = new Size(490, 23);
            hrMSButton.TabIndex = 4;
            hrMSButton.Text = "Human Resource Management System (Coming Soon)";
            hrMSButton.UseVisualStyleBackColor = true;
            // 
            // financeOperationsMSButton
            // 
            financeOperationsMSButton.Location = new Point(20, 240);
            financeOperationsMSButton.Name = "financeOperationsMSButton";
            financeOperationsMSButton.Size = new Size(490, 23);
            financeOperationsMSButton.TabIndex = 5;
            financeOperationsMSButton.Text = "Finance & Operations Management System (Coming Soon)";
            financeOperationsMSButton.UseVisualStyleBackColor = true;
            // 
            // marketingMSButton
            // 
            marketingMSButton.Location = new Point(20, 285);
            marketingMSButton.Name = "marketingMSButton";
            marketingMSButton.Size = new Size(490, 23);
            marketingMSButton.TabIndex = 6;
            marketingMSButton.Text = "Marketing Management System (Coming Soon)";
            marketingMSButton.UseVisualStyleBackColor = true;
            // 
            // customerFieldServiceMSButton
            // 
            customerFieldServiceMSButton.Location = new Point(20, 330);
            customerFieldServiceMSButton.Name = "customerFieldServiceMSButton";
            customerFieldServiceMSButton.Size = new Size(490, 23);
            customerFieldServiceMSButton.TabIndex = 7;
            customerFieldServiceMSButton.Text = "Customer Field Service Management System (Coming Soon)";
            customerFieldServiceMSButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(230, 375);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(70, 23);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // erpSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(530, 420);
            Controls.Add(exitButton);
            Controls.Add(customerFieldServiceMSButton);
            Controls.Add(marketingMSButton);
            Controls.Add(financeOperationsMSButton);
            Controls.Add(hrMSButton);
            Controls.Add(crmMSButton);
            Controls.Add(vehicleInventoryTransportationMaintananceMSButton);
            Controls.Add(creditCardButton);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "erpSystemForm";
            Text = "Enterprise Resource Planning (ERP) System Portal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button creditCardButton;
        private Button vehicleInventoryTransportationMaintananceMSButton;
        private Button crmMSButton;
        private Button hrMSButton;
        private Button financeOperationsMSButton;
        private Button marketingMSButton;
        private Button customerFieldServiceMSButton;
        private Button exitButton;
    }
}