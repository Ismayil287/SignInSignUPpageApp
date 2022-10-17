namespace SignInSignUPpage
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            btnHidePassword.Visible = false;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == UserInfo.userName && txtPassword.Text == UserInfo.passWord)
            {
                this.Hide();
                var form2 = new FormWelcome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else if (!(txtUserName.Text == UserInfo.userName))
            {
                MessageBox.Show("Username is incorrect!");
            }
            else
            {
                MessageBox.Show("Password is incorrect!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear(); 

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new FormSignUp();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void linklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form4 = new FormForgottenPassword();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPassword.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnHidePassword.Visible = true;
            btnShowPassword.Visible = false;
            if (txtPassword.PasswordChar == '*')
            {
                btnShowPassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}