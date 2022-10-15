using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SignInSignUPpage
{
    public partial class FormForgottenPassword : Form
    {
        public FormForgottenPassword()
        {
            InitializeComponent();
            label2.Text = "Please enter your email address to search \nfor your account.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FormLogin();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            FormVerificationPassword fr = new FormVerificationPassword();
            this.Hide();
            fr.Show();
        }

        private void FormForgottenPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblfocuson;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
