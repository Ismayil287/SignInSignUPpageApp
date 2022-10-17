namespace SignInSignUPpage
{
    partial class FormCaptcha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaptcha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkboxamnotrobot = new System.Windows.Forms.CheckBox();
            this.lblRandomText = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEnteredText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chkboxamnotrobot
            // 
            this.chkboxamnotrobot.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkboxamnotrobot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkboxamnotrobot.Location = new System.Drawing.Point(50, 396);
            this.chkboxamnotrobot.Name = "chkboxamnotrobot";
            this.chkboxamnotrobot.Size = new System.Drawing.Size(45, 35);
            this.chkboxamnotrobot.TabIndex = 1;
            this.chkboxamnotrobot.UseVisualStyleBackColor = true;
            this.chkboxamnotrobot.CheckedChanged += new System.EventHandler(this.chkboxamnotrobot_CheckedChanged);
            // 
            // lblRandomText
            // 
            this.lblRandomText.AutoSize = true;
            this.lblRandomText.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomText.Location = new System.Drawing.Point(162, 79);
            this.lblRandomText.Name = "lblRandomText";
            this.lblRandomText.Size = new System.Drawing.Size(0, 44);
            this.lblRandomText.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(32, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 57);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(299, 268);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(157, 57);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEnteredText
            // 
            this.txtEnteredText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnteredText.Location = new System.Drawing.Point(32, 194);
            this.txtEnteredText.Multiline = true;
            this.txtEnteredText.Name = "txtEnteredText";
            this.txtEnteredText.Size = new System.Drawing.Size(424, 48);
            this.txtEnteredText.TabIndex = 5;
            // 
            // FormCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 501);
            this.Controls.Add(this.txtEnteredText);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRandomText);
            this.Controls.Add(this.chkboxamnotrobot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCaptcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.FormCaptcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox chkboxamnotrobot;
        private Label lblRandomText;
        private Button btnReset;
        private Button btnConfirm;
        private TextBox txtEnteredText;
    }
}