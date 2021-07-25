
namespace AnyMessAppWin
{
    partial class ProfileSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSection));
            this.panelProfileParent = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.homeExitBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfileParent
            // 
            this.panelProfileParent.Location = new System.Drawing.Point(35, 99);
            this.panelProfileParent.Name = "panelProfileParent";
            this.panelProfileParent.Size = new System.Drawing.Size(774, 747);
            this.panelProfileParent.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(741, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(76, 82);
            this.panel7.TabIndex = 15;
            // 
            // homeExitBtn
            // 
            this.homeExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.homeExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeExitBtn.Image")));
            this.homeExitBtn.Location = new System.Drawing.Point(35, 14);
            this.homeExitBtn.Name = "homeExitBtn";
            this.homeExitBtn.Size = new System.Drawing.Size(112, 36);
            this.homeExitBtn.TabIndex = 1;
            this.homeExitBtn.UseVisualStyleBackColor = true;
            this.homeExitBtn.Click += new System.EventHandler(this.homeExitBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // ProfileSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 858);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.homeExitBtn);
            this.Controls.Add(this.panelProfileParent);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileSection";
            this.Text = "ProfileSection";
            this.Load += new System.EventHandler(this.ProfileSection_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button homeExitBtn;
        private System.Windows.Forms.Panel panelProfileParent;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}