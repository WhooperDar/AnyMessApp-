
namespace AnyMessAppWin
{
    partial class EditProfileAgency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileAgency));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pbImageBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLookingFor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtnAgency = new System.Windows.Forms.Button();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAboutUs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RemoveImage);
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.pbImageBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 273);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Profile Picture";
            // 
            // RemoveImage
            // 
            this.RemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RemoveImage.FlatAppearance.BorderSize = 0;
            this.RemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.RemoveImage.Location = new System.Drawing.Point(307, 194);
            this.RemoveImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(226, 42);
            this.RemoveImage.TabIndex = 1;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.UseVisualStyleBackColor = false;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            this.RemoveImage.MouseEnter += new System.EventHandler(this.RemoveImage_MouseEnter);
            this.RemoveImage.MouseLeave += new System.EventHandler(this.RemoveImage_MouseLeave);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.browseBtn.Location = new System.Drawing.Point(307, 146);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(226, 42);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse Image";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            this.browseBtn.MouseEnter += new System.EventHandler(this.browseBtn_MouseEnter);
            this.browseBtn.MouseLeave += new System.EventHandler(this.browseBtn_MouseLeave);
            // 
            // pbImageBox
            // 
            this.pbImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(72)))));
            this.pbImageBox.Location = new System.Drawing.Point(39, 78);
            this.pbImageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbImageBox.Name = "pbImageBox";
            this.pbImageBox.Size = new System.Drawing.Size(243, 173);
            this.pbImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageBox.TabIndex = 0;
            this.pbImageBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbLookingFor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbContact);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.saveBtnAgency);
            this.panel2.Controls.Add(this.tbWebsite);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbAboutUs);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 456);
            this.panel2.TabIndex = 1;
            // 
            // tbLookingFor
            // 
            this.tbLookingFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tbLookingFor.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLookingFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.tbLookingFor.Location = new System.Drawing.Point(302, 207);
            this.tbLookingFor.Multiline = true;
            this.tbLookingFor.Name = "tbLookingFor";
            this.tbLookingFor.Size = new System.Drawing.Size(231, 68);
            this.tbLookingFor.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(300, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Looking for";
            // 
            // tbContact
            // 
            this.tbContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tbContact.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.tbContact.Location = new System.Drawing.Point(301, 306);
            this.tbContact.Multiline = true;
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(231, 62);
            this.tbContact.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(298, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact Number";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.cancelBtn.Location = new System.Drawing.Point(302, 398);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(226, 42);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.cancelBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            // 
            // saveBtnAgency
            // 
            this.saveBtnAgency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.saveBtnAgency.FlatAppearance.BorderSize = 0;
            this.saveBtnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtnAgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.saveBtnAgency.Location = new System.Drawing.Point(39, 399);
            this.saveBtnAgency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBtnAgency.Name = "saveBtnAgency";
            this.saveBtnAgency.Size = new System.Drawing.Size(226, 42);
            this.saveBtnAgency.TabIndex = 3;
            this.saveBtnAgency.Text = "Save ";
            this.saveBtnAgency.UseVisualStyleBackColor = false;
            this.saveBtnAgency.Click += new System.EventHandler(this.saveBtnAgency_Click);
            this.saveBtnAgency.MouseEnter += new System.EventHandler(this.saveBtnAgency_MouseEnter);
            this.saveBtnAgency.MouseLeave += new System.EventHandler(this.saveBtnAgency_MouseLeave);
            // 
            // tbWebsite
            // 
            this.tbWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tbWebsite.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.tbWebsite.Location = new System.Drawing.Point(38, 306);
            this.tbWebsite.Multiline = true;
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(246, 62);
            this.tbWebsite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(35, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Website";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tbAddress.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.tbAddress.Location = new System.Drawing.Point(39, 207);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(245, 68);
            this.tbAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label4.Location = new System.Drawing.Point(36, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // tbAboutUs
            // 
            this.tbAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tbAboutUs.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.tbAboutUs.Location = new System.Drawing.Point(39, 99);
            this.tbAboutUs.Multiline = true;
            this.tbAboutUs.Name = "tbAboutUs";
            this.tbAboutUs.Size = new System.Drawing.Size(494, 75);
            this.tbAboutUs.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "About Us";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(72)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 10);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update Details";
            // 
            // EditProfileAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(570, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "EditProfileAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Profile (Agency)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImageBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAboutUs;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtnAgency;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLookingFor;
        private System.Windows.Forms.Label label7;
    }
}