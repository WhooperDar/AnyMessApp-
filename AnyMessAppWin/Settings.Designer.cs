﻿
namespace AnyMessAppWin
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelParentSettings = new System.Windows.Forms.Panel();
            this.settingAccount = new System.Windows.Forms.Button();
            this.exitSettingBtn = new System.Windows.Forms.Button();
            this.settingAboutUs = new System.Windows.Forms.Button();
            this.settingNotif = new System.Windows.Forms.Button();
            this.settingSupport = new System.Windows.Forms.Button();
            this.settingAppearance = new System.Windows.Forms.Button();
            this.settingSecurity = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(72)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(329, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 96);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.settingAboutUs);
            this.panel2.Controls.Add(this.exitSettingBtn);
            this.panel2.Controls.Add(this.settingNotif);
            this.panel2.Controls.Add(this.settingSupport);
            this.panel2.Controls.Add(this.settingAppearance);
            this.panel2.Controls.Add(this.settingSecurity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 858);
            this.panel2.TabIndex = 9;
            // 
            // panelParentSettings
            // 
            this.panelParentSettings.BackColor = System.Drawing.Color.White;
            this.panelParentSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParentSettings.Location = new System.Drawing.Point(329, 96);
            this.panelParentSettings.Name = "panelParentSettings";
            this.panelParentSettings.Size = new System.Drawing.Size(517, 762);
            this.panelParentSettings.TabIndex = 10;
            // 
            // settingAccount
            // 
            this.settingAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingAccount.FlatAppearance.BorderSize = 0;
            this.settingAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingAccount.Image = ((System.Drawing.Image)(resources.GetObject("settingAccount.Image")));
            this.settingAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAccount.Location = new System.Drawing.Point(42, 220);
            this.settingAccount.Name = "settingAccount";
            this.settingAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingAccount.Size = new System.Drawing.Size(235, 51);
            this.settingAccount.TabIndex = 2;
            this.settingAccount.Text = "  Account";
            this.settingAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingAccount.UseVisualStyleBackColor = false;
            this.settingAccount.MouseEnter += new System.EventHandler(this.settingAccount_MouseEnter);
            this.settingAccount.MouseLeave += new System.EventHandler(this.settingAccount_MouseLeave);
            // 
            // exitSettingBtn
            // 
            this.exitSettingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.exitSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitSettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitSettingBtn.Image")));
            this.exitSettingBtn.Location = new System.Drawing.Point(35, 14);
            this.exitSettingBtn.Name = "exitSettingBtn";
            this.exitSettingBtn.Size = new System.Drawing.Size(112, 36);
            this.exitSettingBtn.TabIndex = 1;
            this.exitSettingBtn.UseVisualStyleBackColor = true;
            this.exitSettingBtn.Click += new System.EventHandler(this.exitSettingBtn_Click);
            this.exitSettingBtn.MouseEnter += new System.EventHandler(this.exitSettingBtn_MouseEnter);
            this.exitSettingBtn.MouseLeave += new System.EventHandler(this.exitSettingBtn_MouseLeave);
            // 
            // settingAboutUs
            // 
            this.settingAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingAboutUs.FlatAppearance.BorderSize = 0;
            this.settingAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("settingAboutUs.Image")));
            this.settingAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAboutUs.Location = new System.Drawing.Point(42, 568);
            this.settingAboutUs.Name = "settingAboutUs";
            this.settingAboutUs.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingAboutUs.Size = new System.Drawing.Size(235, 51);
            this.settingAboutUs.TabIndex = 7;
            this.settingAboutUs.Text = "           About Us";
            this.settingAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAboutUs.UseVisualStyleBackColor = false;
            this.settingAboutUs.MouseEnter += new System.EventHandler(this.settingAboutUs_MouseEnter);
            this.settingAboutUs.MouseLeave += new System.EventHandler(this.settingAboutUs_MouseLeave);
            // 
            // settingNotif
            // 
            this.settingNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingNotif.FlatAppearance.BorderSize = 0;
            this.settingNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingNotif.Image = ((System.Drawing.Image)(resources.GetObject("settingNotif.Image")));
            this.settingNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingNotif.Location = new System.Drawing.Point(42, 291);
            this.settingNotif.Name = "settingNotif";
            this.settingNotif.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingNotif.Size = new System.Drawing.Size(235, 51);
            this.settingNotif.TabIndex = 3;
            this.settingNotif.Text = "           Notification";
            this.settingNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingNotif.UseVisualStyleBackColor = false;
            this.settingNotif.MouseEnter += new System.EventHandler(this.settingNotif_MouseEnter);
            this.settingNotif.MouseLeave += new System.EventHandler(this.settingNotif_MouseLeave);
            // 
            // settingSupport
            // 
            this.settingSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingSupport.FlatAppearance.BorderSize = 0;
            this.settingSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingSupport.Image = ((System.Drawing.Image)(resources.GetObject("settingSupport.Image")));
            this.settingSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingSupport.Location = new System.Drawing.Point(42, 499);
            this.settingSupport.Name = "settingSupport";
            this.settingSupport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingSupport.Size = new System.Drawing.Size(235, 51);
            this.settingSupport.TabIndex = 6;
            this.settingSupport.Text = "           Help and Support";
            this.settingSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingSupport.UseVisualStyleBackColor = false;
            this.settingSupport.MouseEnter += new System.EventHandler(this.settingSupport_MouseEnter);
            this.settingSupport.MouseLeave += new System.EventHandler(this.settingSupport_MouseLeave);
            // 
            // settingAppearance
            // 
            this.settingAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingAppearance.FlatAppearance.BorderSize = 0;
            this.settingAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingAppearance.Image = ((System.Drawing.Image)(resources.GetObject("settingAppearance.Image")));
            this.settingAppearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAppearance.Location = new System.Drawing.Point(42, 362);
            this.settingAppearance.Name = "settingAppearance";
            this.settingAppearance.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingAppearance.Size = new System.Drawing.Size(235, 51);
            this.settingAppearance.TabIndex = 4;
            this.settingAppearance.Text = "           Appearance";
            this.settingAppearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingAppearance.UseVisualStyleBackColor = false;
            this.settingAppearance.MouseEnter += new System.EventHandler(this.settingAppearance_MouseEnter);
            this.settingAppearance.MouseLeave += new System.EventHandler(this.settingAppearance_MouseLeave);
            // 
            // settingSecurity
            // 
            this.settingSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.settingSecurity.FlatAppearance.BorderSize = 0;
            this.settingSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.settingSecurity.Image = ((System.Drawing.Image)(resources.GetObject("settingSecurity.Image")));
            this.settingSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingSecurity.Location = new System.Drawing.Point(42, 431);
            this.settingSecurity.Name = "settingSecurity";
            this.settingSecurity.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingSecurity.Size = new System.Drawing.Size(235, 51);
            this.settingSecurity.TabIndex = 5;
            this.settingSecurity.Text = "           Security";
            this.settingSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingSecurity.UseVisualStyleBackColor = false;
            this.settingSecurity.Click += new System.EventHandler(this.settingSecurity_Click);
            this.settingSecurity.MouseEnter += new System.EventHandler(this.settingSecurity_MouseEnter);
            this.settingSecurity.MouseLeave += new System.EventHandler(this.settingSecurity_MouseLeave);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 858);
            this.Controls.Add(this.panelParentSettings);
            this.Controls.Add(this.settingAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitSettingBtn;
        private System.Windows.Forms.Button settingAccount;
        private System.Windows.Forms.Button settingNotif;
        private System.Windows.Forms.Button settingAppearance;
        private System.Windows.Forms.Button settingSecurity;
        private System.Windows.Forms.Button settingSupport;
        private System.Windows.Forms.Button settingAboutUs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelParentSettings;
    }
}