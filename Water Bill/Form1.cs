namespace Water_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPass.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name !", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Focus();
            }

            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter password !", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Focus();
            }

            else
            {
                if (name == "Hoang Ngoc Anh" && pass == "Hoangna2003@")
                {
                    Form2 MainForm = new Form2();
                    MainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Your name or password is incorrect", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check_comform = MessageBox.Show("Do you want to exit ?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check_comform == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Continue...", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }
    }
}
