using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARMSWinDesktopClient
{
    public partial class erpSystemForm : Form
    {
        public erpSystemForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            creditCardMSForm objCreditCardPortal = new creditCardMSForm();
            this.Hide();
            objCreditCardPortal.ShowDialog();
            this.Show();
        }
    }
}
