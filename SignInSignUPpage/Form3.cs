using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SignInSignUPpage
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            cmbBoxBirthDay.SelectedIndex = 5;
            cmbBoxBirthMonth.SelectedIndex = 6;
            for (int i = 2004; i > 1950; i--)
            {
                cmbBoxBirthYear.Items.Add(i);
            }
            cmbBoxBirthYear.SelectedIndex = 9;

            txtFirstName.Text = "Username";
            txtSurname.Text = "Surname";
            txtPassword.Text = "Password";
            txtEmailOrNumber.Text = "Email";

        }

        private void cmbBoxBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linklblBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Hide();
            form.Show();
            
        }

        private void chkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxFemale.Checked = false;
            chkBoxOther.Checked = false;
        }

        private void chkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxMale.Checked = false;
            chkBoxOther.Checked = false;
        }

        private void chkBoxOther_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxMale.Checked = false;
            chkBoxFemale.Checked = false;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Username")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                txtFirstName.Text = "Username";
                txtFirstName.ForeColor = Color.Silver;
                usernamemust.Text = "*";
                usernamemust.ForeColor = Color.Red;
            }
            else if(txtFirstName.Text.Length > 0)
            {
                usernamemust.Text = "";
            }
        }

        private void txtSurname_Enter(object sender, EventArgs e)
        {
            if (txtSurname.Text == "Surname")
            {
                txtSurname.Text = "";
                txtSurname.ForeColor = Color.Black;
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Surname";
                txtSurname.ForeColor = Color.Silver;
                surnamemust.Text = "*";
                surnamemust.ForeColor = Color.Red;
            }
            else if( txtSurname.Text.Length > 0)
            {
                surnamemust.Text = "";
            }
        }

        private void txtEmailOrNumber_Enter(object sender, EventArgs e)
        {
            if (txtEmailOrNumber.Text == "Email")
            {
                txtEmailOrNumber.Text = "";
                txtEmailOrNumber.ForeColor = Color.Black;
            }
        }

        private void txtEmailOrNumber_Leave(object sender, EventArgs e)
        {
            if (txtEmailOrNumber.Text == "")
            {
                txtEmailOrNumber.Text = "Email";
                txtEmailOrNumber.ForeColor = Color.Silver;
                emailmust.Text = "*";
                emailmust.ForeColor = Color.Red;
            }
            else if (txtEmailOrNumber.Text.Length > 0)
            {
                emailmust.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                passwordmust.Text = "*";
                passwordmust.ForeColor = Color.Red;
            }
            else if(txtPassword.Text.Length > 0)
            {
                passwordmust.Text = "";
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbllFocusOn;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            if(txtFirstName.Text == "Username" || txtSurname.Text == "Surname" || txtEmailOrNumber.Text == "Number" || txtPassword.Text == "Password")
            {
                MessageBox.Show(" All field have to filled", "Errorr!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                FormLogin form1 = new FormLogin();
                this.Hide();
                form1.Show();
            }

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
