namespace SignInSignUPpage
{
    partial class FormVerificationPassword
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTryLoginAgain = new System.Windows.Forms.Button();
            this.lblFocusOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(11, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 65);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "We have e-mailed your password reset link!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lavender;
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(25, 166);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 61);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Check your e-mail and try login again.";
            // 
            // btnTryLoginAgain
            // 
            this.btnTryLoginAgain.BackColor = System.Drawing.Color.Green;
            this.btnTryLoginAgain.Font = new System.Drawing.Font("Nirmala UI", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTryLoginAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTryLoginAgain.Location = new System.Drawing.Point(69, 251);
            this.btnTryLoginAgain.Name = "btnTryLoginAgain";
            this.btnTryLoginAgain.Size = new System.Drawing.Size(215, 54);
            this.btnTryLoginAgain.TabIndex = 3;
            this.btnTryLoginAgain.Text = "Try Again";
            this.btnTryLoginAgain.UseVisualStyleBackColor = false;
            this.btnTryLoginAgain.Click += new System.EventHandler(this.btnTryLoginAgain_Click);
            // 
            // lblFocusOn
            // 
            this.lblFocusOn.AutoSize = true;
            this.lblFocusOn.BackColor = System.Drawing.Color.Transparent;
            this.lblFocusOn.Location = new System.Drawing.Point(304, 278);
            this.lblFocusOn.Name = "lblFocusOn";
            this.lblFocusOn.Size = new System.Drawing.Size(0, 15);
            this.lblFocusOn.TabIndex = 4;
            // 
            // FormVerificationPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(355, 325);
            this.Controls.Add(this.lblFocusOn);
            this.Controls.Add(this.btnTryLoginAgain);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormVerificationPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Verification";
            this.Load += new System.EventHandler(this.FormVerificationPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnTryLoginAgain;
        private Label lblFocusOn;
    }
}