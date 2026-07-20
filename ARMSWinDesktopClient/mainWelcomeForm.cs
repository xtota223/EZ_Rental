namespace ARMSWinDesktopClient
{
    public partial class mainWelcomeForm : Form
    {
        public mainWelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void erpButton_Click(object sender, EventArgs e)
        {
            erpSystemForm objERP = new erpSystemForm();
            this.Hide();
            objERP.ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
