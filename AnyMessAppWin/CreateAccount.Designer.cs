
namespace AnyMessAppWin
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.createAccBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.confirmpassBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.conPassLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameCreate = new System.Windows.Forms.TextBox();
            this.exitBtnCreate = new System.Windows.Forms.Button();
            this.panelCreateAccParent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // createAccBtn
            // 
            this.createAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.createAccBtn.FlatAppearance.BorderSize = 0;
            this.createAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccBtn.ForeColor = System.Drawing.Color.White;
            this.createAccBtn.Location = new System.Drawing.Point(41, 596);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(411, 48);
            this.createAccBtn.TabIndex = 32;
            this.createAccBtn.Text = "Create Account";
            this.createAccBtn.UseVisualStyleBackColor = false;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            this.createAccBtn.MouseEnter += new System.EventHandler(this.createAccBtn_MouseEnter);
            this.createAccBtn.MouseLeave += new System.EventHandler(this.createAccBtn_MouseLeave);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Control;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.emailBox.Location = new System.Drawing.Point(45, 352);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(411, 29);
            this.emailBox.TabIndex = 31;
            this.emailBox.TabStop = false;
            this.emailBox.Text = "Email";
            this.emailBox.Enter += new System.EventHandler(this.emailBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Create New Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 58);
            this.label1.TabIndex = 28;
            this.label1.Text = "Create Account";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameBox.Location = new System.Drawing.Point(45, 279);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(411, 29);
            this.usernameBox.TabIndex = 30;
            this.usernameBox.TabStop = false;
            this.usernameBox.Text = "Username";
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            // 
            // confirmpassBox
            // 
            this.confirmpassBox.BackColor = System.Drawing.SystemColors.Control;
            this.confirmpassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpassBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmpassBox.Location = new System.Drawing.Point(45, 493);
            this.confirmpassBox.Name = "confirmpassBox";
            this.confirmpassBox.Size = new System.Drawing.Size(411, 29);
            this.confirmpassBox.TabIndex = 34;
            this.confirmpassBox.TabStop = false;
            this.confirmpassBox.UseSystemPasswordChar = true;
            this.confirmpassBox.Enter += new System.EventHandler(this.confirmpassBox_Enter);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordBox.Location = new System.Drawing.Point(45, 422);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(411, 29);
            this.passwordBox.TabIndex = 33;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.passwordLabel.Location = new System.Drawing.Point(44, 399);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 20);
            this.passwordLabel.TabIndex = 35;
            this.passwordLabel.Text = "Password";
            // 
            // conPassLabel
            // 
            this.conPassLabel.AutoSize = true;
            this.conPassLabel.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.conPassLabel.Location = new System.Drawing.Point(44, 472);
            this.conPassLabel.Name = "conPassLabel";
            this.conPassLabel.Size = new System.Drawing.Size(158, 20);
            this.conPassLabel.TabIndex = 36;
            this.conPassLabel.Text = "Confirm Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.emailLabel.Location = new System.Drawing.Point(41, 328);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 20);
            this.emailLabel.TabIndex = 37;
            this.emailLabel.Text = "Email";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.usernameLabel.Location = new System.Drawing.Point(44, 256);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 20);
            this.usernameLabel.TabIndex = 38;
            this.usernameLabel.Text = "Username";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.nameLabel.Location = new System.Drawing.Point(44, 186);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(202, 20);
            this.nameLabel.TabIndex = 40;
            this.nameLabel.Text = "Name (Real First Name)";
            // 
            // firstNameCreate
            // 
            this.firstNameCreate.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameCreate.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameCreate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.firstNameCreate.Location = new System.Drawing.Point(45, 209);
            this.firstNameCreate.Name = "firstNameCreate";
            this.firstNameCreate.Size = new System.Drawing.Size(411, 29);
            this.firstNameCreate.TabIndex = 39;
            this.firstNameCreate.TabStop = false;
            this.firstNameCreate.Text = "First Name";
            this.firstNameCreate.Enter += new System.EventHandler(this.firstNameCreate_Enter);
            // 
            // exitBtnCreate
            // 
            this.exitBtnCreate.FlatAppearance.BorderSize = 0;
            this.exitBtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("exitBtnCreate.Image")));
            this.exitBtnCreate.Location = new System.Drawing.Point(445, 1);
            this.exitBtnCreate.Name = "exitBtnCreate";
            this.exitBtnCreate.Size = new System.Drawing.Size(55, 29);
            this.exitBtnCreate.TabIndex = 41;
            this.exitBtnCreate.UseVisualStyleBackColor = true;
            this.exitBtnCreate.Click += new System.EventHandler(this.exitBtnCreate_Click);
            // 
            // panelCreateAccParent
            // 
            this.panelCreateAccParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateAccParent.Location = new System.Drawing.Point(0, 0);
            this.panelCreateAccParent.Name = "panelCreateAccParent";
            this.panelCreateAccParent.Size = new System.Drawing.Size(504, 673);
            this.panelCreateAccParent.TabIndex = 42;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 673);
            this.Controls.Add(this.exitBtnCreate);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.firstNameCreate);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.conPassLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.confirmpassBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.panelCreateAccParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox confirmpassBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label conPassLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox firstNameCreate;
        private System.Windows.Forms.Button exitBtnCreate;
        private System.Windows.Forms.Panel panelCreateAccParent;
    }
}