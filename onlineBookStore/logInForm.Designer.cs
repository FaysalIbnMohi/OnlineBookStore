namespace onlineBookStore
{
    partial class logInForm
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
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(107, 63);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(138, 20);
            this.userNameTxt.TabIndex = 0;
            this.userNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Blue;
            this.loginBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.loginBtn.Location = new System.Drawing.Point(107, 180);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 34);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "LogIn";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(107, 127);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = 'X';
            this.PasswordTxt.Size = new System.Drawing.Size(138, 20);
            this.PasswordTxt.TabIndex = 2;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLbl.Location = new System.Drawing.Point(104, 35);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(42, 13);
            this.userNameLbl.TabIndex = 3;
            this.userNameLbl.Text = "Email*";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLbl.Location = new System.Drawing.Point(108, 111);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(66, 13);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password*";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(107, 240);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 23);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 315);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNameTxt);
            this.Name = "logInForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button btnSignUp;
    }
}

