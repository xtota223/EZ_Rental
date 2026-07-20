using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ARMSWinDesktopClient
{
    public partial class creditCardMSForm : Form
    {
        public creditCardMSForm()
        {
            InitializeComponent();
        }

        private void serarchButton_Click(object sender, EventArgs e)
        {
            searchForm objSearch = new searchForm();
            this.Hide();
            objSearch.ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
