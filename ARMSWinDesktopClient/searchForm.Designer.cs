namespace ARMSWinDesktopClient
{
    partial class searchForm
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
            searchPromptLabel = new Label();
            searchTargetCreditCardNumberLabel = new Label();
            searchSectionPanel = new Panel();
            searchCreditCardButton = new Button();
            searchTargetCreditCardNumberTextBox = new TextBox();
            searchResultsSectionPanel = new Panel();
            searchResultsCardActivationStatusTextBox = new TextBox();
            searchResultsCardActivationStatusLabel = new Label();
            searchResultsCardAvailableCreditTextBox = new TextBox();
            searchResultsCardAvailableCreditLabel = new Label();
            searchResultsCardLimitTextBox = new TextBox();
            searchResultsCardLimitLabel = new Label();
            searchResultsCountryTextBox = new TextBox();
            searchResultsCountryLabel = new Label();
            searchResultsZipCodeTextBox = new TextBox();
            searchResultsZipCodeLabel = new Label();
            searchResultsStateTextBox = new TextBox();
            searchResultsStateLabel = new Label();
            searchResultsCityTextBox = new TextBox();
            searchResultsCityLabel = new Label();
            searchResultsAddress2TextBox = new TextBox();
            searchResultsAddress2Label = new Label();
            searchResultsAddress1TextBox = new TextBox();
            searchResultsAddres1Label = new Label();
            searchResultsExpirationDateTextBox = new TextBox();
            searchResultsExpirationDateLabel = new Label();
            searchResultsCardMerchantBankTextBox = new TextBox();
            searchResultsCardMerchantBankLabel = new Label();
            searchResultsCardIssuingBankTextBox = new TextBox();
            searchResultsCardIssuingBankLabel = new Label();
            searchResultsCardNetworkCompanyTextBox = new TextBox();
            searchResultsCardNetworkCompanyLabel = new Label();
            searchResultsCardMerchantCompanyTextBox = new TextBox();
            searchResultsCardMerchantCompanyLabel = new Label();
            searchResultsOwnerNameTextBox = new TextBox();
            searchResultsOwnerNameLabel = new Label();
            searchResultsCardNumberTextBox = new TextBox();
            searchResultsCardNumberLabel = new Label();
            searchResultsSectionTitleLabel = new Label();
            searchPrintSectionPanel = new Panel();
            searchPrintButton = new Button();
            searchPrintPromptLabel = new Label();
            searchClearExitSectionPanel = new Panel();
            searchExitButton = new Button();
            searchClearButton = new Button();
            searchSectionPanel.SuspendLayout();
            searchResultsSectionPanel.SuspendLayout();
            searchPrintSectionPanel.SuspendLayout();
            searchClearExitSectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(24, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(150, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Credit Card Search";
            titleLabel.Click += label1_Click;
            // 
            // searchPromptLabel
            // 
            searchPromptLabel.AutoSize = true;
            searchPromptLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            searchPromptLabel.Location = new Point(35, 62);
            searchPromptLabel.Name = "searchPromptLabel";
            searchPromptLabel.Size = new Size(231, 15);
            searchPromptLabel.TabIndex = 1;
            searchPromptLabel.Text = "Enter Credit Card Number & Click Search:";
            // 
            // searchTargetCreditCardNumberLabel
            // 
            searchTargetCreditCardNumberLabel.AutoSize = true;
            searchTargetCreditCardNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchTargetCreditCardNumberLabel.Location = new Point(35, 92);
            searchTargetCreditCardNumberLabel.Name = "searchTargetCreditCardNumberLabel";
            searchTargetCreditCardNumberLabel.Size = new Size(118, 15);
            searchTargetCreditCardNumberLabel.TabIndex = 2;
            searchTargetCreditCardNumberLabel.Text = "Credit Card Number";
            // 
            // searchSectionPanel
            // 
            searchSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchSectionPanel.Controls.Add(searchCreditCardButton);
            searchSectionPanel.Controls.Add(searchTargetCreditCardNumberTextBox);
            searchSectionPanel.Location = new Point(12, 12);
            searchSectionPanel.Name = "searchSectionPanel";
            searchSectionPanel.Size = new Size(489, 108);
            searchSectionPanel.TabIndex = 3;
            // 
            // searchCreditCardButton
            // 
            searchCreditCardButton.BackColor = Color.PeachPuff;
            searchCreditCardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchCreditCardButton.Location = new Point(359, 75);
            searchCreditCardButton.Name = "searchCreditCardButton";
            searchCreditCardButton.Size = new Size(75, 23);
            searchCreditCardButton.TabIndex = 2;
            searchCreditCardButton.Text = "Search";
            searchCreditCardButton.UseVisualStyleBackColor = false;
            searchCreditCardButton.Click += searchCreditCardButton_Click;
            // 
            // searchTargetCreditCardNumberTextBox
            // 
            searchTargetCreditCardNumberTextBox.Location = new Point(146, 75);
            searchTargetCreditCardNumberTextBox.Name = "searchTargetCreditCardNumberTextBox";
            searchTargetCreditCardNumberTextBox.Size = new Size(196, 23);
            searchTargetCreditCardNumberTextBox.TabIndex = 1;
            // 
            // searchResultsSectionPanel
            // 
            searchResultsSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchResultsSectionPanel.Controls.Add(searchResultsCardActivationStatusTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardActivationStatusLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardAvailableCreditTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardAvailableCreditLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardLimitTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardLimitLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCountryTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCountryLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsZipCodeTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsZipCodeLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsStateTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsStateLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCityTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCityLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsAddress2TextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsAddress2Label);
            searchResultsSectionPanel.Controls.Add(searchResultsAddress1TextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsAddres1Label);
            searchResultsSectionPanel.Controls.Add(searchResultsExpirationDateTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsExpirationDateLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardMerchantBankTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardMerchantBankLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardIssuingBankTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardIssuingBankLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardNetworkCompanyTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardNetworkCompanyLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardMerchantCompanyTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardMerchantCompanyLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsOwnerNameTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsOwnerNameLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsCardNumberTextBox);
            searchResultsSectionPanel.Controls.Add(searchResultsCardNumberLabel);
            searchResultsSectionPanel.Controls.Add(searchResultsSectionTitleLabel);
            searchResultsSectionPanel.Location = new Point(12, 126);
            searchResultsSectionPanel.Name = "searchResultsSectionPanel";
            searchResultsSectionPanel.Size = new Size(296, 464);
            searchResultsSectionPanel.TabIndex = 4;
            searchResultsSectionPanel.Paint += searchResultsSectionPanel_Paint;
            // 
            // searchResultsCardActivationStatusTextBox
            // 
            searchResultsCardActivationStatusTextBox.Location = new Point(174, 425);
            searchResultsCardActivationStatusTextBox.Name = "searchResultsCardActivationStatusTextBox";
            searchResultsCardActivationStatusTextBox.ReadOnly = true;
            searchResultsCardActivationStatusTextBox.Size = new Size(117, 23);
            searchResultsCardActivationStatusTextBox.TabIndex = 18;
            // 
            // searchResultsCardActivationStatusLabel
            // 
            searchResultsCardActivationStatusLabel.AutoSize = true;
            searchResultsCardActivationStatusLabel.Location = new Point(22, 433);
            searchResultsCardActivationStatusLabel.Name = "searchResultsCardActivationStatusLabel";
            searchResultsCardActivationStatusLabel.Size = new Size(124, 15);
            searchResultsCardActivationStatusLabel.TabIndex = 18;
            searchResultsCardActivationStatusLabel.Text = "Card Activation Status";
            // 
            // searchResultsCardAvailableCreditTextBox
            // 
            searchResultsCardAvailableCreditTextBox.Location = new Point(174, 400);
            searchResultsCardAvailableCreditTextBox.Name = "searchResultsCardAvailableCreditTextBox";
            searchResultsCardAvailableCreditTextBox.ReadOnly = true;
            searchResultsCardAvailableCreditTextBox.Size = new Size(117, 23);
            searchResultsCardAvailableCreditTextBox.TabIndex = 17;
            searchResultsCardAvailableCreditTextBox.TextChanged += searchResultsCardAvailableCreditTextBox_TextChanged;
            // 
            // searchResultsCardAvailableCreditLabel
            // 
            searchResultsCardAvailableCreditLabel.AutoSize = true;
            searchResultsCardAvailableCreditLabel.Location = new Point(22, 408);
            searchResultsCardAvailableCreditLabel.Name = "searchResultsCardAvailableCreditLabel";
            searchResultsCardAvailableCreditLabel.Size = new Size(118, 15);
            searchResultsCardAvailableCreditLabel.TabIndex = 17;
            searchResultsCardAvailableCreditLabel.Text = "Card Available Credit";
            // 
            // searchResultsCardLimitTextBox
            // 
            searchResultsCardLimitTextBox.Location = new Point(174, 375);
            searchResultsCardLimitTextBox.Name = "searchResultsCardLimitTextBox";
            searchResultsCardLimitTextBox.ReadOnly = true;
            searchResultsCardLimitTextBox.Size = new Size(117, 23);
            searchResultsCardLimitTextBox.TabIndex = 16;
            // 
            // searchResultsCardLimitLabel
            // 
            searchResultsCardLimitLabel.AutoSize = true;
            searchResultsCardLimitLabel.Location = new Point(22, 383);
            searchResultsCardLimitLabel.Name = "searchResultsCardLimitLabel";
            searchResultsCardLimitLabel.Size = new Size(62, 15);
            searchResultsCardLimitLabel.TabIndex = 16;
            searchResultsCardLimitLabel.Text = "Card Limit";
            // 
            // searchResultsCountryTextBox
            // 
            searchResultsCountryTextBox.Location = new Point(174, 350);
            searchResultsCountryTextBox.Name = "searchResultsCountryTextBox";
            searchResultsCountryTextBox.ReadOnly = true;
            searchResultsCountryTextBox.Size = new Size(117, 23);
            searchResultsCountryTextBox.TabIndex = 15;
            // 
            // searchResultsCountryLabel
            // 
            searchResultsCountryLabel.AutoSize = true;
            searchResultsCountryLabel.Location = new Point(22, 358);
            searchResultsCountryLabel.Name = "searchResultsCountryLabel";
            searchResultsCountryLabel.Size = new Size(50, 15);
            searchResultsCountryLabel.TabIndex = 15;
            searchResultsCountryLabel.Text = "Country";
            // 
            // searchResultsZipCodeTextBox
            // 
            searchResultsZipCodeTextBox.Location = new Point(174, 325);
            searchResultsZipCodeTextBox.Name = "searchResultsZipCodeTextBox";
            searchResultsZipCodeTextBox.ReadOnly = true;
            searchResultsZipCodeTextBox.Size = new Size(117, 23);
            searchResultsZipCodeTextBox.TabIndex = 14;
            // 
            // searchResultsZipCodeLabel
            // 
            searchResultsZipCodeLabel.AutoSize = true;
            searchResultsZipCodeLabel.Location = new Point(22, 333);
            searchResultsZipCodeLabel.Name = "searchResultsZipCodeLabel";
            searchResultsZipCodeLabel.Size = new Size(55, 15);
            searchResultsZipCodeLabel.TabIndex = 14;
            searchResultsZipCodeLabel.Text = "Zip Code";
            // 
            // searchResultsStateTextBox
            // 
            searchResultsStateTextBox.Location = new Point(174, 300);
            searchResultsStateTextBox.Name = "searchResultsStateTextBox";
            searchResultsStateTextBox.ReadOnly = true;
            searchResultsStateTextBox.Size = new Size(117, 23);
            searchResultsStateTextBox.TabIndex = 13;
            // 
            // searchResultsStateLabel
            // 
            searchResultsStateLabel.AutoSize = true;
            searchResultsStateLabel.Location = new Point(22, 308);
            searchResultsStateLabel.Name = "searchResultsStateLabel";
            searchResultsStateLabel.Size = new Size(33, 15);
            searchResultsStateLabel.TabIndex = 12;
            searchResultsStateLabel.Text = "State";
            // 
            // searchResultsCityTextBox
            // 
            searchResultsCityTextBox.Location = new Point(174, 275);
            searchResultsCityTextBox.Name = "searchResultsCityTextBox";
            searchResultsCityTextBox.ReadOnly = true;
            searchResultsCityTextBox.Size = new Size(117, 23);
            searchResultsCityTextBox.TabIndex = 12;
            // 
            // searchResultsCityLabel
            // 
            searchResultsCityLabel.AutoSize = true;
            searchResultsCityLabel.Location = new Point(22, 283);
            searchResultsCityLabel.Name = "searchResultsCityLabel";
            searchResultsCityLabel.Size = new Size(28, 15);
            searchResultsCityLabel.TabIndex = 12;
            searchResultsCityLabel.Text = "City";
            searchResultsCityLabel.Click += searchResultsCityLabel_Click;
            // 
            // searchResultsAddress2TextBox
            // 
            searchResultsAddress2TextBox.Location = new Point(174, 250);
            searchResultsAddress2TextBox.Name = "searchResultsAddress2TextBox";
            searchResultsAddress2TextBox.ReadOnly = true;
            searchResultsAddress2TextBox.Size = new Size(117, 23);
            searchResultsAddress2TextBox.TabIndex = 11;
            // 
            // searchResultsAddress2Label
            // 
            searchResultsAddress2Label.AutoSize = true;
            searchResultsAddress2Label.Location = new Point(22, 258);
            searchResultsAddress2Label.Name = "searchResultsAddress2Label";
            searchResultsAddress2Label.Size = new Size(83, 15);
            searchResultsAddress2Label.TabIndex = 11;
            searchResultsAddress2Label.Text = "Address Line 2";
            // 
            // searchResultsAddress1TextBox
            // 
            searchResultsAddress1TextBox.Location = new Point(174, 225);
            searchResultsAddress1TextBox.Name = "searchResultsAddress1TextBox";
            searchResultsAddress1TextBox.ReadOnly = true;
            searchResultsAddress1TextBox.Size = new Size(117, 23);
            searchResultsAddress1TextBox.TabIndex = 10;
            // 
            // searchResultsAddres1Label
            // 
            searchResultsAddres1Label.AutoSize = true;
            searchResultsAddres1Label.Location = new Point(22, 233);
            searchResultsAddres1Label.Name = "searchResultsAddres1Label";
            searchResultsAddres1Label.Size = new Size(83, 15);
            searchResultsAddres1Label.TabIndex = 10;
            searchResultsAddres1Label.Text = "Address Line 1";
            // 
            // searchResultsExpirationDateTextBox
            // 
            searchResultsExpirationDateTextBox.Location = new Point(174, 200);
            searchResultsExpirationDateTextBox.Name = "searchResultsExpirationDateTextBox";
            searchResultsExpirationDateTextBox.ReadOnly = true;
            searchResultsExpirationDateTextBox.Size = new Size(117, 23);
            searchResultsExpirationDateTextBox.TabIndex = 9;
            // 
            // searchResultsExpirationDateLabel
            // 
            searchResultsExpirationDateLabel.AutoSize = true;
            searchResultsExpirationDateLabel.Location = new Point(22, 208);
            searchResultsExpirationDateLabel.Name = "searchResultsExpirationDateLabel";
            searchResultsExpirationDateLabel.Size = new Size(86, 15);
            searchResultsExpirationDateLabel.TabIndex = 9;
            searchResultsExpirationDateLabel.Text = "Expiration Date";
            // 
            // searchResultsCardMerchantBankTextBox
            // 
            searchResultsCardMerchantBankTextBox.Location = new Point(174, 175);
            searchResultsCardMerchantBankTextBox.Name = "searchResultsCardMerchantBankTextBox";
            searchResultsCardMerchantBankTextBox.ReadOnly = true;
            searchResultsCardMerchantBankTextBox.Size = new Size(117, 23);
            searchResultsCardMerchantBankTextBox.TabIndex = 8;
            // 
            // searchResultsCardMerchantBankLabel
            // 
            searchResultsCardMerchantBankLabel.AutoSize = true;
            searchResultsCardMerchantBankLabel.Location = new Point(22, 183);
            searchResultsCardMerchantBankLabel.Name = "searchResultsCardMerchantBankLabel";
            searchResultsCardMerchantBankLabel.Size = new Size(115, 15);
            searchResultsCardMerchantBankLabel.TabIndex = 8;
            searchResultsCardMerchantBankLabel.Text = "Card Merchant Bank";
            // 
            // searchResultsCardIssuingBankTextBox
            // 
            searchResultsCardIssuingBankTextBox.Location = new Point(174, 150);
            searchResultsCardIssuingBankTextBox.Name = "searchResultsCardIssuingBankTextBox";
            searchResultsCardIssuingBankTextBox.ReadOnly = true;
            searchResultsCardIssuingBankTextBox.Size = new Size(117, 23);
            searchResultsCardIssuingBankTextBox.TabIndex = 7;
            // 
            // searchResultsCardIssuingBankLabel
            // 
            searchResultsCardIssuingBankLabel.AutoSize = true;
            searchResultsCardIssuingBankLabel.Location = new Point(22, 158);
            searchResultsCardIssuingBankLabel.Name = "searchResultsCardIssuingBankLabel";
            searchResultsCardIssuingBankLabel.Size = new Size(101, 15);
            searchResultsCardIssuingBankLabel.TabIndex = 7;
            searchResultsCardIssuingBankLabel.Text = "Card Issuing Bank";
            // 
            // searchResultsCardNetworkCompanyTextBox
            // 
            searchResultsCardNetworkCompanyTextBox.Location = new Point(174, 125);
            searchResultsCardNetworkCompanyTextBox.Name = "searchResultsCardNetworkCompanyTextBox";
            searchResultsCardNetworkCompanyTextBox.ReadOnly = true;
            searchResultsCardNetworkCompanyTextBox.Size = new Size(117, 23);
            searchResultsCardNetworkCompanyTextBox.TabIndex = 6;
            // 
            // searchResultsCardNetworkCompanyLabel
            // 
            searchResultsCardNetworkCompanyLabel.AutoSize = true;
            searchResultsCardNetworkCompanyLabel.Location = new Point(22, 133);
            searchResultsCardNetworkCompanyLabel.Name = "searchResultsCardNetworkCompanyLabel";
            searchResultsCardNetworkCompanyLabel.Size = new Size(135, 15);
            searchResultsCardNetworkCompanyLabel.TabIndex = 6;
            searchResultsCardNetworkCompanyLabel.Text = "Card Network Company";
            // 
            // searchResultsCardMerchantCompanyTextBox
            // 
            searchResultsCardMerchantCompanyTextBox.Location = new Point(174, 100);
            searchResultsCardMerchantCompanyTextBox.Name = "searchResultsCardMerchantCompanyTextBox";
            searchResultsCardMerchantCompanyTextBox.ReadOnly = true;
            searchResultsCardMerchantCompanyTextBox.Size = new Size(117, 23);
            searchResultsCardMerchantCompanyTextBox.TabIndex = 5;
            searchResultsCardMerchantCompanyTextBox.TextChanged += searchResultsCardMerchantCompayTextBox_TextChanged;
            // 
            // searchResultsCardMerchantCompanyLabel
            // 
            searchResultsCardMerchantCompanyLabel.AutoSize = true;
            searchResultsCardMerchantCompanyLabel.Location = new Point(22, 108);
            searchResultsCardMerchantCompanyLabel.Name = "searchResultsCardMerchantCompanyLabel";
            searchResultsCardMerchantCompanyLabel.Size = new Size(141, 15);
            searchResultsCardMerchantCompanyLabel.TabIndex = 5;
            searchResultsCardMerchantCompanyLabel.Text = "Card Merchant Company";
            // 
            // searchResultsOwnerNameTextBox
            // 
            searchResultsOwnerNameTextBox.Location = new Point(174, 75);
            searchResultsOwnerNameTextBox.Name = "searchResultsOwnerNameTextBox";
            searchResultsOwnerNameTextBox.ReadOnly = true;
            searchResultsOwnerNameTextBox.Size = new Size(117, 23);
            searchResultsOwnerNameTextBox.TabIndex = 4;
            // 
            // searchResultsOwnerNameLabel
            // 
            searchResultsOwnerNameLabel.AutoSize = true;
            searchResultsOwnerNameLabel.Location = new Point(22, 83);
            searchResultsOwnerNameLabel.Name = "searchResultsOwnerNameLabel";
            searchResultsOwnerNameLabel.Size = new Size(105, 15);
            searchResultsOwnerNameLabel.TabIndex = 4;
            searchResultsOwnerNameLabel.Text = "Card Owner Name";
            // 
            // searchResultsCardNumberTextBox
            // 
            searchResultsCardNumberTextBox.Location = new Point(174, 50);
            searchResultsCardNumberTextBox.Name = "searchResultsCardNumberTextBox";
            searchResultsCardNumberTextBox.ReadOnly = true;
            searchResultsCardNumberTextBox.Size = new Size(117, 23);
            searchResultsCardNumberTextBox.TabIndex = 3;
            searchResultsCardNumberTextBox.TextChanged += searchResultsCardNumberTextBox_TextChanged;
            // 
            // searchResultsCardNumberLabel
            // 
            searchResultsCardNumberLabel.AutoSize = true;
            searchResultsCardNumberLabel.Location = new Point(22, 58);
            searchResultsCardNumberLabel.Name = "searchResultsCardNumberLabel";
            searchResultsCardNumberLabel.Size = new Size(114, 15);
            searchResultsCardNumberLabel.TabIndex = 1;
            searchResultsCardNumberLabel.Text = "Credit Card Number";
            // 
            // searchResultsSectionTitleLabel
            // 
            searchResultsSectionTitleLabel.AutoSize = true;
            searchResultsSectionTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            searchResultsSectionTitleLabel.Location = new Point(11, 24);
            searchResultsSectionTitleLabel.Name = "searchResultsSectionTitleLabel";
            searchResultsSectionTitleLabel.Size = new Size(144, 15);
            searchResultsSectionTitleLabel.TabIndex = 0;
            searchResultsSectionTitleLabel.Text = "Credit Card Information";
            // 
            // searchPrintSectionPanel
            // 
            searchPrintSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchPrintSectionPanel.Controls.Add(searchPrintButton);
            searchPrintSectionPanel.Controls.Add(searchPrintPromptLabel);
            searchPrintSectionPanel.Location = new Point(314, 126);
            searchPrintSectionPanel.Name = "searchPrintSectionPanel";
            searchPrintSectionPanel.Size = new Size(187, 464);
            searchPrintSectionPanel.TabIndex = 5;
            // 
            // searchPrintButton
            // 
            searchPrintButton.BackColor = Color.PeachPuff;
            searchPrintButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchPrintButton.Location = new Point(57, 50);
            searchPrintButton.Name = "searchPrintButton";
            searchPrintButton.Size = new Size(75, 23);
            searchPrintButton.TabIndex = 19;
            searchPrintButton.Text = "Print";
            searchPrintButton.UseVisualStyleBackColor = false;
            searchPrintButton.Click += searchPrintButton_Click;
            // 
            // searchPrintPromptLabel
            // 
            searchPrintPromptLabel.AutoSize = true;
            searchPrintPromptLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            searchPrintPromptLabel.Location = new Point(3, 24);
            searchPrintPromptLabel.Name = "searchPrintPromptLabel";
            searchPrintPromptLabel.Size = new Size(179, 15);
            searchPrintPromptLabel.TabIndex = 0;
            searchPrintPromptLabel.Text = "Print Credit Card Information:";
            // 
            // searchClearExitSectionPanel
            // 
            searchClearExitSectionPanel.BorderStyle = BorderStyle.FixedSingle;
            searchClearExitSectionPanel.Controls.Add(searchExitButton);
            searchClearExitSectionPanel.Controls.Add(searchClearButton);
            searchClearExitSectionPanel.Location = new Point(12, 596);
            searchClearExitSectionPanel.Name = "searchClearExitSectionPanel";
            searchClearExitSectionPanel.Size = new Size(489, 48);
            searchClearExitSectionPanel.TabIndex = 6;
            // 
            // searchExitButton
            // 
            searchExitButton.BackColor = Color.PeachPuff;
            searchExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchExitButton.Location = new Point(397, 12);
            searchExitButton.Name = "searchExitButton";
            searchExitButton.Size = new Size(75, 23);
            searchExitButton.TabIndex = 21;
            searchExitButton.Text = "Exit";
            searchExitButton.UseVisualStyleBackColor = false;
            searchExitButton.Click += searchExitButton_Click;
            // 
            // searchClearButton
            // 
            searchClearButton.BackColor = Color.PeachPuff;
            searchClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchClearButton.Location = new Point(30, 12);
            searchClearButton.Name = "searchClearButton";
            searchClearButton.Size = new Size(75, 23);
            searchClearButton.TabIndex = 20;
            searchClearButton.Text = "Clear";
            searchClearButton.UseVisualStyleBackColor = false;
            searchClearButton.Click += searchClearButton_Click;
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(514, 651);
            Controls.Add(searchClearExitSectionPanel);
            Controls.Add(searchPrintSectionPanel);
            Controls.Add(searchResultsSectionPanel);
            Controls.Add(searchTargetCreditCardNumberLabel);
            Controls.Add(searchPromptLabel);
            Controls.Add(titleLabel);
            Controls.Add(searchSectionPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "searchForm";
            Text = "Credit Card Search";
            searchSectionPanel.ResumeLayout(false);
            searchSectionPanel.PerformLayout();
            searchResultsSectionPanel.ResumeLayout(false);
            searchResultsSectionPanel.PerformLayout();
            searchPrintSectionPanel.ResumeLayout(false);
            searchPrintSectionPanel.PerformLayout();
            searchClearExitSectionPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label searchPromptLabel;
        private Label searchTargetCreditCardNumberLabel;
        private Panel searchSectionPanel;
        private TextBox searchTargetCreditCardNumberTextBox;
        private Button searchCreditCardButton;
        private Panel searchResultsSectionPanel;
        private Label searchResultsSectionTitleLabel;
        private Label searchResultsCardNumberLabel;
        private Label searchResultsOwnerNameLabel;
        private TextBox searchResultsCardNumberTextBox;
        private TextBox searchResultsCardNetworkCompanyTextBox;
        private Label searchResultsCardNetworkCompanyLabel;
        private TextBox searchResultsCardMerchantCompanyTextBox;
        private Label searchResultsCardMerchantCompanyLabel;
        private TextBox searchResultsOwnerNameTextBox;
        private Label searchResultsExpirationDateLabel;
        private TextBox searchResultsCardMerchantBankTextBox;
        private Label searchResultsCardMerchantBankLabel;
        private TextBox searchResultsCardIssuingBankTextBox;
        private Label searchResultsCardIssuingBankLabel;
        private TextBox searchResultsAddress2TextBox;
        private Label searchResultsAddress2Label;
        private TextBox searchResultsAddress1TextBox;
        private Label searchResultsAddres1Label;
        private TextBox searchResultsExpirationDateTextBox;
        private Label searchResultsStateLabel;
        private TextBox searchResultsCityTextBox;
        private Label searchResultsCityLabel;
        private Label searchResultsZipCodeLabel;
        private TextBox searchResultsStateTextBox;
        private TextBox searchResultsCardLimitTextBox;
        private Label searchResultsCardLimitLabel;
        private TextBox searchResultsCountryTextBox;
        private Label searchResultsCountryLabel;
        private TextBox searchResultsZipCodeTextBox;
        private Label searchResultsCardActivationStatusLabel;
        private TextBox searchResultsCardAvailableCreditTextBox;
        private Label searchResultsCardAvailableCreditLabel;
        private TextBox searchResultsCardActivationStatusTextBox;
        private Panel searchPrintSectionPanel;
        private Label searchPrintPromptLabel;
        private Button searchPrintButton;
        private Panel searchClearExitSectionPanel;
        private Button searchExitButton;
        private Button searchClearButton;
    }
}