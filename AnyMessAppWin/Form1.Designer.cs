
namespace AnyMessAppWin
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxBottom = new System.Windows.Forms.Label();
            this.textBoxTop = new System.Windows.Forms.Label();
            this.slidePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parentPanelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getStartedBtn = new System.Windows.Forms.Button();
            this.toForm = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).BeginInit();
            this.parentPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxBottom);
            this.panel1.Controls.Add(this.textBoxTop);
            this.panel1.Controls.Add(this.slidePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 673);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 670);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 29);
            this.panel2.TabIndex = 7;
            // 
            // textBoxBottom
            // 
            this.textBoxBottom.AutoSize = true;
            this.textBoxBottom.Font = new System.Drawing.Font("Montserrat ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(72)))));
            this.textBoxBottom.Location = new System.Drawing.Point(61, 564);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.Size = new System.Drawing.Size(302, 33);
            this.textBoxBottom.TabIndex = 6;
            this.textBoxBottom.Text = "Hire a Launderer Now!";
            this.textBoxBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTop
            // 
            this.textBoxTop.AutoSize = true;
            this.textBoxTop.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTop.ForeColor = System.Drawing.Color.White;
            this.textBoxTop.Location = new System.Drawing.Point(60, 525);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.Size = new System.Drawing.Size(352, 27);
            this.textBoxTop.TabIndex = 2;
            this.textBoxTop.Text = "You don\'t have time for laundry?";
            this.textBoxTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // slidePictureBox
            // 
            this.slidePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("slidePictureBox.Image")));
            this.slidePictureBox.Location = new System.Drawing.Point(65, 90);
            this.slidePictureBox.Name = "slidePictureBox";
            this.slidePictureBox.Size = new System.Drawing.Size(630, 414);
            this.slidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePictureBox.TabIndex = 5;
            this.slidePictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parentPanelLogin
            // 
            this.parentPanelLogin.Controls.Add(this.label4);
            this.parentPanelLogin.Controls.Add(this.label1);
            this.parentPanelLogin.Controls.Add(this.label3);
            this.parentPanelLogin.Controls.Add(this.label2);
            this.parentPanelLogin.Controls.Add(this.getStartedBtn);
            this.parentPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanelLogin.Location = new System.Drawing.Point(761, 0);
            this.parentPanelLogin.Name = "parentPanelLogin";
            this.parentPanelLogin.Size = new System.Drawing.Size(501, 673);
            this.parentPanelLogin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(124, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "or a job in housekeeping?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(92, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 83);
            this.label1.TabIndex = 13;
            this.label1.Text = "AnyMess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(73, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Looking for a housekeeping services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(116, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "a housekeeping app";
            // 
            // getStartedBtn
            // 
            this.getStartedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.getStartedBtn.FlatAppearance.BorderSize = 0;
            this.getStartedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getStartedBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedBtn.ForeColor = System.Drawing.Color.White;
            this.getStartedBtn.Location = new System.Drawing.Point(89, 508);
            this.getStartedBtn.Name = "getStartedBtn";
            this.getStartedBtn.Size = new System.Drawing.Size(332, 48);
            this.getStartedBtn.TabIndex = 15;
            this.getStartedBtn.Text = "Get Started";
            this.getStartedBtn.UseVisualStyleBackColor = false;
            this.getStartedBtn.Click += new System.EventHandler(this.getStartedBtn_Click);
            this.getStartedBtn.MouseEnter += new System.EventHandler(this.getStartedBtn_MouseEnter);
            this.getStartedBtn.MouseLeave += new System.EventHandler(this.getStartedBtn_MouseLeave);
            // 
            // toForm
            // 
            this.toForm.Enabled = true;
            this.toForm.Tick += new System.EventHandler(this.toForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.parentPanelLogin);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnyMess";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).EndInit();
            this.parentPanelLogin.ResumeLayout(false);
            this.parentPanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slidePictureBox;
        private System.Windows.Forms.Label textBoxBottom;
        private System.Windows.Forms.Label textBoxTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel parentPanelLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getStartedBtn;
        private System.Windows.Forms.Timer toForm;
    }
}

