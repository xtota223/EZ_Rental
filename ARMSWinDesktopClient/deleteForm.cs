using ARMSDALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARMSWinDesktopClient
{
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cardNumber = textBox1.Text;

                if (string.IsNullOrWhiteSpace(cardNumber))
                {
                    MessageBox.Show("Please enter a credit card number.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;

                var dao = new CreditCardDAO();
                bool success = dao.deleteRecordByID(cardNumber);

                if (success)
                    MessageBox.Show("Record deleted successfully.");
                else
                    MessageBox.Show("No matching record was found.");
            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while deleting the record.");
            }
        }

        private void deleteExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
