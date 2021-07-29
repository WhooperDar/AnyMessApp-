
namespace AnyMessAppWin
{
    partial class HomeTabPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTabPanel));
            this.labelSaying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtnHk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.homeExitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshBtnAgency = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSaying
            // 
            this.labelSaying.AutoSize = true;
            this.labelSaying.Font = new System.Drawing.Font("Montserrat Black", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelSaying.Location = new System.Drawing.Point(32, 68);
            this.labelSaying.Name = "labelSaying";
            this.labelSaying.Size = new System.Drawing.Size(309, 54);
            this.labelSaying.TabIndex = 1;
            this.labelSaying.Text = "Hi UserName,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(27, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "Available Housekeepers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtnHk);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 259);
            this.panel1.TabIndex = 12;
            // 
            // refreshBtnHk
            // 
            this.refreshBtnHk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.refreshBtnHk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.refreshBtnHk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtnHk.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtnHk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.refreshBtnHk.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtnHk.Image")));
            this.refreshBtnHk.Location = new System.Drawing.Point(492, 13);
            this.refreshBtnHk.Name = "refreshBtnHk";
            this.refreshBtnHk.Size = new System.Drawing.Size(37, 32);
            this.refreshBtnHk.TabIndex = 16;
            this.refreshBtnHk.UseVisualStyleBackColor = false;
            this.refreshBtnHk.Click += new System.EventHandler(this.refreshBtnHk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(773, 181);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.labelSaying);
            this.panel2.Controls.Add(this.homeExitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 261);
            this.panel2.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(741, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(76, 82);
            this.panel7.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AnyMessAppWin.Properties.Resources.home_orage;
            this.pictureBox5.Location = new System.Drawing.Point(4, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // homeExitBtn
            // 
            this.homeExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.homeExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeExitBtn.Image")));
            this.homeExitBtn.Location = new System.Drawing.Point(12, 12);
            this.homeExitBtn.Name = "homeExitBtn";
            this.homeExitBtn.Size = new System.Drawing.Size(28, 36);
            this.homeExitBtn.TabIndex = 0;
            this.homeExitBtn.UseVisualStyleBackColor = true;
            this.homeExitBtn.Click += new System.EventHandler(this.homeExitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(28, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 47);
            this.label3.TabIndex = 14;
            this.label3.Text = "Available Agency";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(41, 582);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(773, 181);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // refreshBtnAgency
            // 
            this.refreshBtnAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.refreshBtnAgency.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.refreshBtnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtnAgency.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtnAgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.refreshBtnAgency.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtnAgency.Image")));
            this.refreshBtnAgency.Location = new System.Drawing.Point(370, 539);
            this.refreshBtnAgency.Name = "refreshBtnAgency";
            this.refreshBtnAgency.Size = new System.Drawing.Size(37, 32);
            this.refreshBtnAgency.TabIndex = 17;
            this.refreshBtnAgency.UseVisualStyleBackColor = false;
            this.refreshBtnAgency.Click += new System.EventHandler(this.refreshBtnAgency_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Welcome to AnyMess ";
            // 
            // HomeTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(846, 784);
            this.Controls.Add(this.refreshBtnAgency);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeTabPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeTab";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeExitBtn;
        private System.Windows.Forms.Label labelSaying;
        private System.Windows.Forms.Button LaundryBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button refreshBtnHk;
        private System.Windows.Forms.Button refreshBtnAgency;
        private System.Windows.Forms.Label label4;
    }
}