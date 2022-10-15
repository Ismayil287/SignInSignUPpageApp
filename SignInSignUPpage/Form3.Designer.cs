namespace SignInSignUPpage
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmailOrNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxBirthDay = new System.Windows.Forms.ComboBox();
            this.cmbBoxBirthMonth = new System.Windows.Forms.ComboBox();
            this.cmbBoxBirthYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBoxMale = new System.Windows.Forms.CheckBox();
            this.chkBoxFemale = new System.Windows.Forms.CheckBox();
            this.chkBoxOther = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.linklblBackToLogin = new System.Windows.Forms.LinkLabel();
            this.surnamemust = new System.Windows.Forms.TextBox();
            this.usernamemust = new System.Windows.Forms.TextBox();
            this.emailmust = new System.Windows.Forms.TextBox();
            this.passwordmust = new System.Windows.Forms.TextBox();
            this.lbllFocusOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register and Join Us.";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.Location = new System.Drawing.Point(12, 91);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 44);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Tag = "";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.ForeColor = System.Drawing.Color.Silver;
            this.txtSurname.Location = new System.Drawing.Point(243, 91);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(221, 44);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            this.txtSurname.Enter += new System.EventHandler(this.txtSurname_Enter);
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // txtEmailOrNumber
            // 
            this.txtEmailOrNumber.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailOrNumber.ForeColor = System.Drawing.Color.Silver;
            this.txtEmailOrNumber.Location = new System.Drawing.Point(12, 146);
            this.txtEmailOrNumber.Multiline = true;
            this.txtEmailOrNumber.Name = "txtEmailOrNumber";
            this.txtEmailOrNumber.Size = new System.Drawing.Size(452, 44);
            this.txtEmailOrNumber.TabIndex = 4;
            this.txtEmailOrNumber.Enter += new System.EventHandler(this.txtEmailOrNumber_Enter);
            this.txtEmailOrNumber.Leave += new System.EventHandler(this.txtEmailOrNumber_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(12, 203);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(452, 44);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth Date";
            // 
            // cmbBoxBirthDay
            // 
            this.cmbBoxBirthDay.FormattingEnabled = true;
            this.cmbBoxBirthDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbBoxBirthDay.Location = new System.Drawing.Point(12, 292);
            this.cmbBoxBirthDay.Name = "cmbBoxBirthDay";
            this.cmbBoxBirthDay.Size = new System.Drawing.Size(126, 23);
            this.cmbBoxBirthDay.TabIndex = 7;
            // 
            // cmbBoxBirthMonth
            // 
            this.cmbBoxBirthMonth.FormattingEnabled = true;
            this.cmbBoxBirthMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbBoxBirthMonth.Location = new System.Drawing.Point(176, 292);
            this.cmbBoxBirthMonth.Name = "cmbBoxBirthMonth";
            this.cmbBoxBirthMonth.Size = new System.Drawing.Size(126, 23);
            this.cmbBoxBirthMonth.TabIndex = 8;
            // 
            // cmbBoxBirthYear
            // 
            this.cmbBoxBirthYear.FormattingEnabled = true;
            this.cmbBoxBirthYear.Location = new System.Drawing.Point(338, 292);
            this.cmbBoxBirthYear.Name = "cmbBoxBirthYear";
            this.cmbBoxBirthYear.Size = new System.Drawing.Size(126, 23);
            this.cmbBoxBirthYear.TabIndex = 9;
            this.cmbBoxBirthYear.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBirthYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // chkBoxMale
            // 
            this.chkBoxMale.AutoSize = true;
            this.chkBoxMale.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxMale.Location = new System.Drawing.Point(18, 363);
            this.chkBoxMale.Name = "chkBoxMale";
            this.chkBoxMale.Size = new System.Drawing.Size(57, 21);
            this.chkBoxMale.TabIndex = 11;
            this.chkBoxMale.Text = "Male";
            this.chkBoxMale.UseVisualStyleBackColor = true;
            this.chkBoxMale.CheckedChanged += new System.EventHandler(this.chkBoxMale_CheckedChanged);
            // 
            // chkBoxFemale
            // 
            this.chkBoxFemale.AutoSize = true;
            this.chkBoxFemale.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxFemale.Location = new System.Drawing.Point(176, 363);
            this.chkBoxFemale.Name = "chkBoxFemale";
            this.chkBoxFemale.Size = new System.Drawing.Size(75, 21);
            this.chkBoxFemale.TabIndex = 12;
            this.chkBoxFemale.Text = "Female";
            this.chkBoxFemale.UseVisualStyleBackColor = true;
            this.chkBoxFemale.CheckedChanged += new System.EventHandler(this.chkBoxFemale_CheckedChanged);
            // 
            // chkBoxOther
            // 
            this.chkBoxOther.AutoSize = true;
            this.chkBoxOther.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBoxOther.Location = new System.Drawing.Point(338, 363);
            this.chkBoxOther.Name = "chkBoxOther";
            this.chkBoxOther.Size = new System.Drawing.Size(67, 21);
            this.chkBoxOther.TabIndex = 13;
            this.chkBoxOther.Text = "Other";
            this.chkBoxOther.UseVisualStyleBackColor = true;
            this.chkBoxOther.CheckedChanged += new System.EventHandler(this.chkBoxOther_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Teal;
            this.btnSignUp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignUp.Location = new System.Drawing.Point(125, 401);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(206, 55);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // linklblBackToLogin
            // 
            this.linklblBackToLogin.ActiveLinkColor = System.Drawing.Color.Red;
            this.linklblBackToLogin.AutoSize = true;
            this.linklblBackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.linklblBackToLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblBackToLogin.ForeColor = System.Drawing.Color.Black;
            this.linklblBackToLogin.LinkColor = System.Drawing.Color.Navy;
            this.linklblBackToLogin.Location = new System.Drawing.Point(47, 473);
            this.linklblBackToLogin.Name = "linklblBackToLogin";
            this.linklblBackToLogin.Size = new System.Drawing.Size(374, 18);
            this.linklblBackToLogin.TabIndex = 15;
            this.linklblBackToLogin.TabStop = true;
            this.linklblBackToLogin.Text = "Would you like to return to the Login Page ?";
            this.linklblBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBackToLogin_LinkClicked);
            // 
            // surnamemust
            // 
            this.surnamemust.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnamemust.Location = new System.Drawing.Point(420, 91);
            this.surnamemust.Multiline = true;
            this.surnamemust.Name = "surnamemust";
            this.surnamemust.Size = new System.Drawing.Size(44, 44);
            this.surnamemust.TabIndex = 16;
            // 
            // usernamemust
            // 
            this.usernamemust.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernamemust.Location = new System.Drawing.Point(187, 91);
            this.usernamemust.Multiline = true;
            this.usernamemust.Name = "usernamemust";
            this.usernamemust.Size = new System.Drawing.Size(44, 44);
            this.usernamemust.TabIndex = 17;
            this.usernamemust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailmust
            // 
            this.emailmust.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailmust.Location = new System.Drawing.Point(420, 146);
            this.emailmust.Multiline = true;
            this.emailmust.Name = "emailmust";
            this.emailmust.Size = new System.Drawing.Size(44, 44);
            this.emailmust.TabIndex = 18;
            // 
            // passwordmust
            // 
            this.passwordmust.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordmust.Location = new System.Drawing.Point(420, 203);
            this.passwordmust.Multiline = true;
            this.passwordmust.Name = "passwordmust";
            this.passwordmust.Size = new System.Drawing.Size(44, 44);
            this.passwordmust.TabIndex = 19;
            // 
            // lbllFocusOn
            // 
            this.lbllFocusOn.AutoSize = true;
            this.lbllFocusOn.Location = new System.Drawing.Point(325, 25);
            this.lbllFocusOn.Name = "lbllFocusOn";
            this.lbllFocusOn.Size = new System.Drawing.Size(0, 15);
            this.lbllFocusOn.TabIndex = 20;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(476, 500);
            this.Controls.Add(this.lbllFocusOn);
            this.Controls.Add(this.passwordmust);
            this.Controls.Add(this.emailmust);
            this.Controls.Add(this.usernamemust);
            this.Controls.Add(this.surnamemust);
            this.Controls.Add(this.linklblBackToLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.chkBoxOther);
            this.Controls.Add(this.chkBoxFemale);
            this.Controls.Add(this.chkBoxMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxBirthYear);
            this.Controls.Add(this.cmbBoxBirthMonth);
            this.Controls.Add(this.cmbBoxBirthDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmailOrNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtSurname;
        private TextBox txtEmailOrNumber;
        private TextBox txtPassword;
        private Label label3;
        private ComboBox cmbBoxBirthDay;
        private ComboBox cmbBoxBirthMonth;
        private ComboBox cmbBoxBirthYear;
        private Label label4;
        private CheckBox chkBoxMale;
        private CheckBox chkBoxFemale;
        private CheckBox chkBoxOther;
        private Button btnSignUp;
        private LinkLabel linklblBackToLogin;
        private TextBox surnamemust;
        private TextBox usernamemust;
        private TextBox emailmust;
        private TextBox passwordmust;
        private Label lbllFocusOn;
    }
}