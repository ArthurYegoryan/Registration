namespace Registration
{
    partial class SignInForm
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
            this.txtSignInPage = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSignInPage
            // 
            this.txtSignInPage.AutoSize = true;
            this.txtSignInPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSignInPage.Location = new System.Drawing.Point(152, 65);
            this.txtSignInPage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtSignInPage.Name = "txtSignInPage";
            this.txtSignInPage.Size = new System.Drawing.Size(117, 20);
            this.txtSignInPage.TabIndex = 0;
            this.txtSignInPage.Text = "Sign In Page!";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(79, 124);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(63, 13);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(171, 124);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(147, 20);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.Enter += new System.EventHandler(this.textBoxUserName_Enter);
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(87, 151);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(56, 13);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(171, 151);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(147, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(171, 194);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(47, 20);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 401);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtSignInPage);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSignInPage;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnter;
    }
}