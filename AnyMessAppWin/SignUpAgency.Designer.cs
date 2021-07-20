
namespace AnyMessAppWin
{
    partial class SignUpAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpAgency));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agencyNameBox = new System.Windows.Forms.TextBox();
            this.agencyAddressBox = new System.Windows.Forms.TextBox();
            this.agencyWebsiteBox = new System.Windows.Forms.TextBox();
            this.agencyContactBox = new System.Windows.Forms.TextBox();
            this.agencyCodeBox = new System.Windows.Forms.TextBox();
            this.NextBtnAgency = new System.Windows.Forms.Button();
            this.backButtonAgency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // agencyNameBox
            // 
            this.agencyNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.agencyNameBox, "agencyNameBox");
            this.agencyNameBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyNameBox.Name = "agencyNameBox";
            this.agencyNameBox.TabStop = false;
            this.agencyNameBox.Enter += new System.EventHandler(this.agencyNameBox_Enter);
            this.agencyNameBox.Leave += new System.EventHandler(this.agencyNameBox_Leave);
            // 
            // agencyAddressBox
            // 
            this.agencyAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.agencyAddressBox, "agencyAddressBox");
            this.agencyAddressBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyAddressBox.Name = "agencyAddressBox";
            this.agencyAddressBox.TabStop = false;
            this.agencyAddressBox.Enter += new System.EventHandler(this.agencyAddressBox_Enter);
            this.agencyAddressBox.Leave += new System.EventHandler(this.agencyAddressBox_Leave);
            // 
            // agencyWebsiteBox
            // 
            this.agencyWebsiteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.agencyWebsiteBox, "agencyWebsiteBox");
            this.agencyWebsiteBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyWebsiteBox.Name = "agencyWebsiteBox";
            this.agencyWebsiteBox.TabStop = false;
            this.agencyWebsiteBox.Enter += new System.EventHandler(this.agencyWebsiteBox_Enter);
            this.agencyWebsiteBox.Leave += new System.EventHandler(this.agencyWebsiteBox_Leave);
            // 
            // agencyContactBox
            // 
            this.agencyContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.agencyContactBox, "agencyContactBox");
            this.agencyContactBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyContactBox.Name = "agencyContactBox";
            this.agencyContactBox.TabStop = false;
            this.agencyContactBox.Enter += new System.EventHandler(this.agencyContactBox_Enter);
            this.agencyContactBox.Leave += new System.EventHandler(this.agencyContactBox_Leave);
            // 
            // agencyCodeBox
            // 
            this.agencyCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.agencyCodeBox, "agencyCodeBox");
            this.agencyCodeBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyCodeBox.Name = "agencyCodeBox";
            this.agencyCodeBox.TabStop = false;
            this.agencyCodeBox.Enter += new System.EventHandler(this.agencyCodeBox_Enter);
            this.agencyCodeBox.Leave += new System.EventHandler(this.agencyCodeBox_Leave);
            // 
            // NextBtnAgency
            // 
            this.NextBtnAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.NextBtnAgency.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.NextBtnAgency, "NextBtnAgency");
            this.NextBtnAgency.ForeColor = System.Drawing.Color.White;
            this.NextBtnAgency.Name = "NextBtnAgency";
            this.NextBtnAgency.UseVisualStyleBackColor = false;
            this.NextBtnAgency.Click += new System.EventHandler(this.NextBtnAgency_Click);
            this.NextBtnAgency.MouseEnter += new System.EventHandler(this.NextBtnAgency_MouseEnter);
            this.NextBtnAgency.MouseLeave += new System.EventHandler(this.NextBtnAgency_MouseLeave);
            // 
            // backButtonAgency
            // 
            this.backButtonAgency.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.backButtonAgency, "backButtonAgency");
            this.backButtonAgency.Name = "backButtonAgency";
            this.backButtonAgency.UseVisualStyleBackColor = true;
            this.backButtonAgency.Click += new System.EventHandler(this.backButtonAgency_Click);
            this.backButtonAgency.MouseEnter += new System.EventHandler(this.backButtonAgency_MouseEnter);
            this.backButtonAgency.MouseLeave += new System.EventHandler(this.backButtonAgency_MouseLeave);
            // 
            // SignUpAgency
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backButtonAgency);
            this.Controls.Add(this.NextBtnAgency);
            this.Controls.Add(this.agencyCodeBox);
            this.Controls.Add(this.agencyWebsiteBox);
            this.Controls.Add(this.agencyContactBox);
            this.Controls.Add(this.agencyAddressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agencyNameBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "SignUpAgency";
            this.Load += new System.EventHandler(this.SignUpAgency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agencyNameBox;
        private System.Windows.Forms.TextBox agencyAddressBox;
        private System.Windows.Forms.TextBox agencyWebsiteBox;
        private System.Windows.Forms.TextBox agencyContactBox;
        private System.Windows.Forms.TextBox agencyCodeBox;
        private System.Windows.Forms.Button NextBtnAgency;
        private System.Windows.Forms.Button backButtonAgency;
    }
}