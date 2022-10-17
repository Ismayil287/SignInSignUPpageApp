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
    public partial class FormCaptcha : Form
    {
        public FormCaptcha()
        {
            InitializeComponent();
        }

        private void FormCaptcha_Load(object sender, EventArgs e)
        {

        }
        
        
        private void chkboxamnotrobot_CheckedChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(6, 8);
            string captcha = "";
            int result = 0;
            do
            {
                int chr = r.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    result++;
                    if (result == n)
                        break;
                }
            }
            while (true);
            lblRandomText.Text = captcha;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lblRandomText.Text == txtEnteredText.Text)
            {
                MessageBox.Show("Entered Capctha Is True");
                FormLogin f = new FormLogin();
                this.Hide();
                f.Show();
            }
            else if (txtEnteredText.Text == "")
            {
                MessageBox.Show("Please Enter Captcha ");
                Random r = new Random();
                int n = r.Next(6, 8);
                string captcha = "";
                int result = 0;
                do
                {
                    int chr = r.Next(48, 123);
                    if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                    {
                        captcha = captcha + (char)chr;
                        result++;
                        if (result == n)
                            break;
                    }
                }
                while (true);
                lblRandomText.Text = captcha;
            }
            else
            {
                MessageBox.Show("Error!! Entered Capctha Is Incorrect");
                Random r = new Random();
                int n = r.Next(6, 8);
                string captcha = "";
                int result = 0;
                do
                {
                    int chr = r.Next(48, 123);
                    if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                    {
                        captcha = captcha + (char)chr;
                        result++;
                        if (result == n)
                            break;
                    }
                }
                while (true);
                lblRandomText.Text = captcha;
                txtEnteredText.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(6, 8);
            string captcha = "";
            int result = 0;
            do
            {
                int chr = r.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    result++;
                    if (result == n)
                        break;
                }
            }
            while (true);
            lblRandomText.Text = captcha;
            txtEnteredText.Clear();
        }
    }
}
