
namespace AnyMessAppWin.MarketServices
{
    partial class MarketHousekeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketHousekeeper));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pbHkService = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.postNowBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSkill = new System.Windows.Forms.TextBox();
            this.labelHkName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHkService)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post your profile to show in housekeeping list.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market your services";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 130);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.removeBtn);
            this.panel2.Controls.Add(this.browseBtn);
            this.panel2.Controls.Add(this.pbHkService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 253);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Upload Image";
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
            // pbHkService
            // 
            this.pbHkService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.pbHkService.Location = new System.Drawing.Point(30, 62);
            this.pbHkService.Name = "pbHkService";
            this.pbHkService.Size = new System.Drawing.Size(224, 172);
            this.pbHkService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHkService.TabIndex = 0;
            this.pbHkService.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.cancelBtn.Location = new System.Drawing.Point(272, 578);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(212, 35);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.postNowBtn.TabIndex = 9;
            this.postNowBtn.Text = "POST NOW!";
            this.postNowBtn.UseVisualStyleBackColor = false;
            this.postNowBtn.Click += new System.EventHandler(this.postNowBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(26, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Core Skill ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(26, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Housekeeper Name";
            // 
            // labelSkill
            // 
            this.labelSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelSkill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelSkill.Location = new System.Drawing.Point(30, 502);
            this.labelSkill.Multiline = true;
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(454, 36);
            this.labelSkill.TabIndex = 10;
            // 
            // labelHkName
            // 
            this.labelHkName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.labelHkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelHkName.Location = new System.Drawing.Point(30, 426);
            this.labelHkName.Multiline = true;
            this.labelHkName.Name = "labelHkName";
            this.labelHkName.Size = new System.Drawing.Size(454, 36);
            this.labelHkName.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 258);
            this.panel3.TabIndex = 13;
            // 
            // MarketHousekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(517, 641);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.postNowBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSkill);
            this.Controls.Add(this.labelHkName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MarketHousekeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market your service";
            this.Load += new System.EventHandler(this.MarketHousekeeper_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHkService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox pbHkService;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button postNowBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox labelSkill;
        private System.Windows.Forms.TextBox labelHkName;
        private System.Windows.Forms.Panel panel3;
    }
}