
namespace AnyMessAppWin.MarketServices
{
    partial class MarketAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketAgency));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAgencyService = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAgencyName = new System.Windows.Forms.TextBox();
            this.labelAddressPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postNowBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgencyService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market your agency ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post your agency to show in agency list.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.removeBtn);
            this.panel2.Controls.Add(this.browseBtn);
            this.panel2.Controls.Add(this.pbAgencyService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 253);
            this.panel2.TabIndex = 1;
            // 
            // pbAgencyService
            // 
            this.pbAgencyService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.pbAgencyService.Location = new System.Drawing.Point(30, 62);
            this.pbAgencyService.Name = "pbAgencyService";
            this.pbAgencyService.Size = new System.Drawing.Size(224, 172);
            this.pbAgencyService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgencyService.TabIndex = 0;
            this.pbAgencyService.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.browseBtn.Location = new System.Drawing.Point(279, 111);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(205, 35);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse Image";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.removeBtn.Location = new System.Drawing.Point(279, 152);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(205, 35);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove Image";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload Image";
            // 
            // labelAgencyName
            // 
            this.labelAgencyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelAgencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelAgencyName.Location = new System.Drawing.Point(30, 426);
            this.labelAgencyName.Multiline = true;
            this.labelAgencyName.Name = "labelAgencyName";
            this.labelAgencyName.Size = new System.Drawing.Size(454, 36);
            this.labelAgencyName.TabIndex = 2;
            // 
            // labelAddressPlace
            // 
            this.labelAddressPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelAddressPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelAddressPlace.Location = new System.Drawing.Point(30, 502);
            this.labelAddressPlace.Multiline = true;
            this.labelAddressPlace.Name = "labelAddressPlace";
            this.labelAddressPlace.Size = new System.Drawing.Size(454, 36);
            this.labelAddressPlace.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(26, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Agency Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(26, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Place";
            // 
            // postNowBtn
            // 
            this.postNowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.postNowBtn.FlatAppearance.BorderSize = 0;
            this.postNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postNowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.postNowBtn.Location = new System.Drawing.Point(30, 578);
            this.postNowBtn.Name = "postNowBtn";
            this.postNowBtn.Size = new System.Drawing.Size(224, 35);
            this.postNowBtn.TabIndex = 3;
            this.postNowBtn.Text = "POST NOW!";
            this.postNowBtn.UseVisualStyleBackColor = false;
            this.postNowBtn.Click += new System.EventHandler(this.postNowBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.cancelBtn.Location = new System.Drawing.Point(272, 578);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(212, 35);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 641);
            this.panel3.TabIndex = 6;
            // 
            // MarketAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(517, 641);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.postNowBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAddressPlace);
            this.Controls.Add(this.labelAgencyName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MarketAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market your agency";
            this.Load += new System.EventHandler(this.MarketAgency_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgencyService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbAgencyService;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox labelAgencyName;
        private System.Windows.Forms.TextBox labelAddressPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button postNowBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel3;
    }
}