namespace Registration
{
    partial class SignUpForm
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegPage = new System.Windows.Forms.Label();
            this.buttonHaveAccount = new System.Windows.Forms.Button();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.checkBoxConfPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(180, 187);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxUserName.MaxLength = 50;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(142, 20);
            this.textBoxUserName.TabIndex = 8;
            this.textBoxUserName.Enter += new System.EventHandler(this.textBoxUserName_Enter);
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(180, 213);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(142, 20);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(108, 190);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(60, 13);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "UserName:";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(111, 215);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(56, 13);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Password:";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(180, 269);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(61, 23);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "Submit";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(107, 72);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(57, 13);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "FirstName:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(180, 72);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(169, 20);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(108, 99);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(58, 13);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Text = "LastName:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(180, 99);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(169, 20);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(129, 125);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(180, 125);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AutoSize = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(72, 239);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.txtConfirmPassword.TabIndex = 11;
            this.txtConfirmPassword.Text = "Confirm Password:";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(180, 239);
            this.textBoxConfirmPass.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxConfirmPass.MaxLength = 50;
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(142, 20);
            this.textBoxConfirmPass.TabIndex = 12;
            this.textBoxConfirmPass.UseSystemPasswordChar = true;
            this.textBoxConfirmPass.Enter += new System.EventHandler(this.textBoxConfirmPass_Enter);
            this.textBoxConfirmPass.Leave += new System.EventHandler(this.textBoxConfirmPass_Leave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(74, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 4);
            this.panel1.TabIndex = 16;
            // 
            // txtRegPage
            // 
            this.txtRegPage.AutoSize = true;
            this.txtRegPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRegPage.Location = new System.Drawing.Point(137, 22);
            this.txtRegPage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtRegPage.Name = "txtRegPage";
            this.txtRegPage.Size = new System.Drawing.Size(157, 20);
            this.txtRegPage.TabIndex = 17;
            this.txtRegPage.Text = "Registration page!";
            // 
            // buttonHaveAccount
            // 
            this.buttonHaveAccount.Location = new System.Drawing.Point(231, 315);
            this.buttonHaveAccount.Margin = new System.Windows.Forms.Padding(1);
            this.buttonHaveAccount.Name = "buttonHaveAccount";
            this.buttonHaveAccount.Size = new System.Drawing.Size(172, 25);
            this.buttonHaveAccount.TabIndex = 14;
            this.buttonHaveAccount.Text = "I already have an account!";
            this.buttonHaveAccount.UseVisualStyleBackColor = true;
            this.buttonHaveAccount.Click += new System.EventHandler(this.buttonHavingAccount_Click);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(327, 216);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPass.TabIndex = 18;
            this.checkBoxPass.Text = "Show";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // checkBoxConfPass
            // 
            this.checkBoxConfPass.AutoSize = true;
            this.checkBoxConfPass.Location = new System.Drawing.Point(327, 241);
            this.checkBoxConfPass.Name = "checkBoxConfPass";
            this.checkBoxConfPass.Size = new System.Drawing.Size(53, 17);
            this.checkBoxConfPass.TabIndex = 19;
            this.checkBoxConfPass.Text = "Show";
            this.checkBoxConfPass.UseVisualStyleBackColor = true;
            this.checkBoxConfPass.CheckedChanged += new System.EventHandler(this.checkBoxConfPass_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 352);
            this.Controls.Add(this.checkBoxConfPass);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.buttonHaveAccount);
            this.Controls.Add(this.txtRegPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SignUpForm";
            this.Text = "SignUp Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label txtLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label txtConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtRegPage;
        private System.Windows.Forms.Button buttonHaveAccount;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.CheckBox checkBoxConfPass;
    }
}

