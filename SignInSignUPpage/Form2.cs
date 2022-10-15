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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FormLogin();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
