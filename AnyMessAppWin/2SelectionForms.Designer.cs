
namespace AnyMessAppWin
{
    partial class _2SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2SignUpForm));
            this.SignUpBotton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parentPanelSignUp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SignUpBotton
            // 
            this.SignUpBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.SignUpBotton.FlatAppearance.BorderSize = 0;
            this.SignUpBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBotton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBotton.ForeColor = System.Drawing.Color.White;
            this.SignUpBotton.Location = new System.Drawing.Point(107, 474);
            this.SignUpBotton.Name = "SignUpBotton";
            this.SignUpBotton.Size = new System.Drawing.Size(291, 48);
            this.SignUpBotton.TabIndex = 14;
            this.SignUpBotton.Text = "Sign Up";
            this.SignUpBotton.UseVisualStyleBackColor = false;
            this.SignUpBotton.Click += new System.EventHandler(this.SignUpBotton_Click);
            this.SignUpBotton.MouseEnter += new System.EventHandler(this.SignUpBotton_MouseEnter);
            this.SignUpBotton.MouseLeave += new System.EventHandler(this.SignUpBotton_MouseLeave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(107, 406);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(291, 48);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(112, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "a housekeeping app";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(92, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 83);
            this.label1.TabIndex = 11;
            this.label1.Text = "AnyMess";
            // 
            // parentPanelSignUp
            // 
            this.parentPanelSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanelSignUp.Location = new System.Drawing.Point(0, 0);
            this.parentPanelSignUp.Name = "parentPanelSignUp";
            this.parentPanelSignUp.Size = new System.Drawing.Size(501, 673);
            this.parentPanelSignUp.TabIndex = 15;
            // 
            // _2SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(501, 673);
            this.Controls.Add(this.SignUpBotton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parentPanelSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_2SignUpForm";
            this.Text = "_2SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignUpBotton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel parentPanelSignUp;
    }
}