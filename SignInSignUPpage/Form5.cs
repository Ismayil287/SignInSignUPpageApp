using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUPpage
{
    public partial class FormVerificationPassword : Form
    {
        public FormVerificationPassword()
        {
            InitializeComponent();
        }

        private void btnTryLoginAgain_Click(object sender, EventArgs e)
        {
            FormLogin fr = new FormLogin();
            this.Hide();
            fr.Show();
        }

        private void FormVerificationPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblFocusOn;
        }
    }
}
