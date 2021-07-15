
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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "As Agency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign Up";
            // 
            // agencyNameBox
            // 
            this.agencyNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agencyNameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyNameBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyNameBox.Location = new System.Drawing.Point(32, 149);
            this.agencyNameBox.Name = "agencyNameBox";
            this.agencyNameBox.Size = new System.Drawing.Size(411, 29);
            this.agencyNameBox.TabIndex = 14;
            this.agencyNameBox.TabStop = false;
            this.agencyNameBox.Text = "Enter Agency Name";
            this.agencyNameBox.Enter += new System.EventHandler(this.agencyNameBox_Enter);
            this.agencyNameBox.Leave += new System.EventHandler(this.agencyNameBox_Leave);
            // 
            // agencyAddressBox
            // 
            this.agencyAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agencyAddressBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyAddressBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyAddressBox.Location = new System.Drawing.Point(32, 204);
            this.agencyAddressBox.Name = "agencyAddressBox";
            this.agencyAddressBox.Size = new System.Drawing.Size(411, 29);
            this.agencyAddressBox.TabIndex = 15;
            this.agencyAddressBox.TabStop = false;
            this.agencyAddressBox.Text = "Enter Address";
            this.agencyAddressBox.Enter += new System.EventHandler(this.agencyAddressBox_Enter);
            this.agencyAddressBox.Leave += new System.EventHandler(this.agencyAddressBox_Leave);
            // 
            // agencyWebsiteBox
            // 
            this.agencyWebsiteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agencyWebsiteBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyWebsiteBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyWebsiteBox.Location = new System.Drawing.Point(32, 314);
            this.agencyWebsiteBox.Name = "agencyWebsiteBox";
            this.agencyWebsiteBox.Size = new System.Drawing.Size(411, 29);
            this.agencyWebsiteBox.TabIndex = 17;
            this.agencyWebsiteBox.TabStop = false;
            this.agencyWebsiteBox.Text = "Enter Website";
            this.agencyWebsiteBox.Enter += new System.EventHandler(this.agencyWebsiteBox_Enter);
            this.agencyWebsiteBox.Leave += new System.EventHandler(this.agencyWebsiteBox_Leave);
            // 
            // agencyContactBox
            // 
            this.agencyContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agencyContactBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyContactBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyContactBox.Location = new System.Drawing.Point(32, 259);
            this.agencyContactBox.Name = "agencyContactBox";
            this.agencyContactBox.Size = new System.Drawing.Size(411, 29);
            this.agencyContactBox.TabIndex = 16;
            this.agencyContactBox.TabStop = false;
            this.agencyContactBox.Text = "Enter Contact Number";
            this.agencyContactBox.Enter += new System.EventHandler(this.agencyContactBox_Enter);
            this.agencyContactBox.Leave += new System.EventHandler(this.agencyContactBox_Leave);
            // 
            // agencyCodeBox
            // 
            this.agencyCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agencyCodeBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agencyCodeBox.ForeColor = System.Drawing.Color.Silver;
            this.agencyCodeBox.Location = new System.Drawing.Point(32, 368);
            this.agencyCodeBox.Name = "agencyCodeBox";
            this.agencyCodeBox.Size = new System.Drawing.Size(411, 29);
            this.agencyCodeBox.TabIndex = 18;
            this.agencyCodeBox.TabStop = false;
            this.agencyCodeBox.Text = "Enter Agency Code";
            this.agencyCodeBox.Enter += new System.EventHandler(this.agencyCodeBox_Enter);
            this.agencyCodeBox.Leave += new System.EventHandler(this.agencyCodeBox_Leave);
            // 
            // NextBtnAgency
            // 
            this.NextBtnAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.NextBtnAgency.FlatAppearance.BorderSize = 0;
            this.NextBtnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtnAgency.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtnAgency.ForeColor = System.Drawing.Color.White;
            this.NextBtnAgency.Location = new System.Drawing.Point(32, 554);
            this.NextBtnAgency.Name = "NextBtnAgency";
            this.NextBtnAgency.Size = new System.Drawing.Size(411, 48);
            this.NextBtnAgency.TabIndex = 19;
            this.NextBtnAgency.Text = "Next";
            this.NextBtnAgency.UseVisualStyleBackColor = false;
            this.NextBtnAgency.Click += new System.EventHandler(this.NextBtnAgency_Click);
            // 
            // SignUpAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 626);
            this.Controls.Add(this.NextBtnAgency);
            this.Controls.Add(this.agencyCodeBox);
            this.Controls.Add(this.agencyWebsiteBox);
            this.Controls.Add(this.agencyContactBox);
            this.Controls.Add(this.agencyAddressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agencyNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up Agency";
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
    }
}