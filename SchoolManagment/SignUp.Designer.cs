namespace SchoolManagment
{
    partial class SignUp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.haveAccount = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(153, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // haveAccount
            // 
            this.haveAccount.AutoSize = true;
            this.haveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.haveAccount.Location = new System.Drawing.Point(97, 478);
            this.haveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(192, 17);
            this.haveAccount.TabIndex = 4;
            this.haveAccount.Text = "Already Have An Account";
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.backToLogin.Location = new System.Drawing.Point(113, 514);
            this.backToLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(156, 25);
            this.backToLogin.TabIndex = 5;
            this.backToLogin.Text = "Back to LOGIN";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTB.Location = new System.Drawing.Point(71, 117);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(245, 22);
            this.usernameTB.TabIndex = 6;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTB.Location = new System.Drawing.Point(71, 196);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(245, 22);
            this.passwordTB.TabIndex = 7;
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTB.Location = new System.Drawing.Point(71, 274);
            this.confirmPasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(245, 22);
            this.confirmPasswordTB.TabIndex = 8;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Checked = true;
            this.showPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showPassword.Location = new System.Drawing.Point(180, 324);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(142, 21);
            this.showPassword.TabIndex = 9;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerBtn.Location = new System.Drawing.Point(71, 378);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(263, 28);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.clearBtn.Location = new System.Drawing.Point(71, 428);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(263, 28);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 590);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.confirmPasswordTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.haveAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label haveAccount;
        private System.Windows.Forms.Label backToLogin;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}