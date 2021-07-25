
namespace AnyMessAppWin
{
    partial class LoginUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserForm));
            this.forgetBtn = new System.Windows.Forms.Button();
            this.createAccountLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtnSignIn = new System.Windows.Forms.Button();
            this.panelSignInParent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // forgetBtn
            // 
            this.forgetBtn.BackColor = System.Drawing.Color.Transparent;
            this.forgetBtn.FlatAppearance.BorderSize = 0;
            this.forgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.forgetBtn.Location = new System.Drawing.Point(246, 450);
            this.forgetBtn.Name = "forgetBtn";
            this.forgetBtn.Size = new System.Drawing.Size(214, 30);
            this.forgetBtn.TabIndex = 60;
            this.forgetBtn.Text = "Forgot Password?";
            this.forgetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgetBtn.UseVisualStyleBackColor = false;
            this.forgetBtn.MouseEnter += new System.EventHandler(this.forgetBtn_MouseEnter);
            this.forgetBtn.MouseLeave += new System.EventHandler(this.forgetBtn_MouseLeave);
            // 
            // createAccountLogin
            // 
            this.createAccountLogin.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLogin.FlatAppearance.BorderSize = 0;
            this.createAccountLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountLogin.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.createAccountLogin.Location = new System.Drawing.Point(283, 600);
            this.createAccountLogin.Margin = new System.Windows.Forms.Padding(0);
            this.createAccountLogin.Name = "createAccountLogin";
            this.createAccountLogin.Size = new System.Drawing.Size(177, 28);
            this.createAccountLogin.TabIndex = 59;
            this.createAccountLogin.Text = "Create Account";
            this.createAccountLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createAccountLogin.UseVisualStyleBackColor = false;
            this.createAccountLogin.Click += new System.EventHandler(this.createAccountLogin_Click);
            this.createAccountLogin.MouseEnter += new System.EventHandler(this.createAccountLogin_MouseEnter);
            this.createAccountLogin.MouseLeave += new System.EventHandler(this.createAccountLogin_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label8.Location = new System.Drawing.Point(75, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Don\'t have the account?";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(41, 549);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(411, 48);
            this.signInBtn.TabIndex = 56;
            this.signInBtn.Text = "Sign in ";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            this.signInBtn.MouseEnter += new System.EventHandler(this.signInBtn_MouseEnter);
            this.signInBtn.MouseLeave += new System.EventHandler(this.signInBtn_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(44, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.passwordBox.Location = new System.Drawing.Point(44, 418);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(408, 29);
            this.passwordBox.TabIndex = 54;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.usernameText.Location = new System.Drawing.Point(44, 319);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(92, 20);
            this.usernameText.TabIndex = 53;
            this.usernameText.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.usernameBox.Location = new System.Drawing.Point(44, 342);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(408, 29);
            this.usernameBox.TabIndex = 52;
            this.usernameBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(43, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "Sign-in to continue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(38, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 58);
            this.label2.TabIndex = 50;
            this.label2.Text = "back,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 58);
            this.label1.TabIndex = 49;
            this.label1.Text = "Welcome";
            // 
            // exitBtnSignIn
            // 
            this.exitBtnSignIn.FlatAppearance.BorderSize = 0;
            this.exitBtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtnSignIn.Image")));
            this.exitBtnSignIn.Location = new System.Drawing.Point(445, 1);
            this.exitBtnSignIn.Name = "exitBtnSignIn";
            this.exitBtnSignIn.Size = new System.Drawing.Size(55, 29);
            this.exitBtnSignIn.TabIndex = 61;
            this.exitBtnSignIn.UseVisualStyleBackColor = true;
            this.exitBtnSignIn.Click += new System.EventHandler(this.exitBtnSignIn_Click);
            // 
            // panelSignInParent
            // 
            this.panelSignInParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignInParent.Location = new System.Drawing.Point(0, 0);
            this.panelSignInParent.Name = "panelSignInParent";
            this.panelSignInParent.Size = new System.Drawing.Size(504, 673);
            this.panelSignInParent.TabIndex = 62;
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(504, 673);
            this.Controls.Add(this.exitBtnSignIn);
            this.Controls.Add(this.forgetBtn);
            this.Controls.Add(this.createAccountLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSignInParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginUserForm";
            this.Text = "LoginUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgetBtn;
        private System.Windows.Forms.Button createAccountLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtnSignIn;
        private System.Windows.Forms.Panel panelSignInParent;
    }
}