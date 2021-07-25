
namespace AnyMessAppWin
{
    partial class AgencyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyList));
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.agencyListExitBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency List";
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
            // agencyListExitBtn
            // 
            this.agencyListExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agencyListExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.agencyListExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("agencyListExitBtn.Image")));
            this.agencyListExitBtn.Location = new System.Drawing.Point(35, 14);
            this.agencyListExitBtn.Name = "agencyListExitBtn";
            this.agencyListExitBtn.Size = new System.Drawing.Size(112, 36);
            this.agencyListExitBtn.TabIndex = 16;
            this.agencyListExitBtn.UseVisualStyleBackColor = true;
            this.agencyListExitBtn.Click += new System.EventHandler(this.agencyListExitBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // AgencyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(846, 858);
            this.Controls.Add(this.agencyListExitBtn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgencyList";
            this.Text = "AgencyList";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button agencyListExitBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}