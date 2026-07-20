using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSWinDesktopClient
{
    public partial class searchForm : Form
    {
        CreditCard objCreditCard;
        public searchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchResultsCityLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchResultsCardAvailableCreditTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchResultsSectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchResultsCardNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchCreditCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                objCreditCard = new CreditCard();
                bool found = objCreditCard.Load(searchTargetCreditCardNumberTextBox.Text.Trim());
                if (found == true)
                {
                    searchResultsCardNumberTextBox.Text = objCreditCard.CreditCardNumber;
                    searchResultsOwnerNameTextBox.Text = objCreditCard.CreditCardOwnerName;
                    searchResultsCardMerchantCompanyTextBox.Text = objCreditCard.CreditCardProcessingMerchantServiceCompanyName;
                    searchResultsCardNetworkCompanyTextBox.Text = objCreditCard.CreditCardNetworkCompanyName;
                    searchResultsCardIssuingBankTextBox.Text = objCreditCard.CreditCardIssuingBankName;
                    searchResultsCardMerchantBankTextBox.Text = objCreditCard.CreditCardCorporateMerchantBankName;
                    searchResultsExpirationDateTextBox.Text = objCreditCard.ExpDate.ToShortDateString();
                    searchResultsAddress1TextBox.Text = objCreditCard.AddressLine1;
                    searchResultsAddress2TextBox.Text = objCreditCard.AddressLine2;
                    searchResultsCityTextBox.Text = objCreditCard.City;
                    searchResultsStateTextBox.Text = objCreditCard.StateCode;
                    searchResultsZipCodeTextBox.Text = objCreditCard.ZipCode;
                    searchResultsCountryTextBox.Text = objCreditCard.Country;
                    searchResultsCardLimitTextBox.Text = objCreditCard.CreditCardLimit.ToString();
                    searchResultsCardAvailableCreditTextBox.Text = objCreditCard.CreditCardAvailableCredit.ToString();
                    searchResultsCardActivationStatusTextBox.Text = objCreditCard.CreditCardActivationStatus.ToString();
                }
                else
                {
                    MessageBox.Show("Credit Card record was not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in Search!");
            }
        }

        private void searchResultsCardMerchantCompayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchPrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCreditCard != null)
                {
                    objCreditCard.Print();
                    MessageBox.Show("Credit card information sent to the printer (Network_Printer.txt).",
                                    "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please search for a credit card first before printing.",
                                    "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in Print!");
            }
        }

        private void searchClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in clear!");
            }
        }


        private void ClearForm()
        {
            searchTargetCreditCardNumberTextBox.Text = "";
            searchResultsCardNumberTextBox.Text = "";
            searchResultsOwnerNameTextBox.Text = "";
            searchResultsCardMerchantCompanyTextBox.Text = "";
            searchResultsCardNetworkCompanyTextBox.Text = "";
            searchResultsCardIssuingBankTextBox.Text = "";
            searchResultsCardMerchantBankTextBox.Text = "";
            searchResultsExpirationDateTextBox.Text = "";
            searchResultsAddress1TextBox.Text = "";
            searchResultsAddress2TextBox.Text = "";
            searchResultsCityTextBox.Text = "";
            searchResultsStateTextBox.Text = "";
            searchResultsZipCodeTextBox.Text = "";
            searchResultsCountryTextBox.Text = "";
            searchResultsCardLimitTextBox.Text = "";
            searchResultsCardAvailableCreditTextBox.Text = "";
            searchResultsCardActivationStatusTextBox.Text = "";

            objCreditCard = null;
        }
    }
}
