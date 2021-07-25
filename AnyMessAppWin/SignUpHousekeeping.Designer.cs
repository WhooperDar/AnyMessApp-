
namespace AnyMessAppWin
{
    partial class SignUpHousekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpHousekeeping));
            this.hkAddressBox = new System.Windows.Forms.TextBox();
            this.hkSexBox = new System.Windows.Forms.TextBox();
            this.NextBtnHousekeeping = new System.Windows.Forms.Button();
            this.hkContactBox = new System.Windows.Forms.TextBox();
            this.hkAgeBox = new System.Windows.Forms.TextBox();
            this.hkLastNameBox = new System.Windows.Forms.TextBox();
            this.hkMiddleNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hkFirstNameBox = new System.Windows.Forms.TextBox();
            this.hkSkillBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.panelHkParent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hkAddressBox
            // 
            this.hkAddressBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkAddressBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkAddressBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkAddressBox.Location = new System.Drawing.Point(42, 488);
            this.hkAddressBox.Name = "hkAddressBox";
            this.hkAddressBox.Size = new System.Drawing.Size(411, 29);
            this.hkAddressBox.TabIndex = 39;
            this.hkAddressBox.TabStop = false;
            this.hkAddressBox.Text = "Enter Address";
            this.hkAddressBox.Enter += new System.EventHandler(this.hkAddressBox_Enter);
            this.hkAddressBox.Leave += new System.EventHandler(this.hkAddressBox_Leave);
            // 
            // hkSexBox
            // 
            this.hkSexBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkSexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkSexBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkSexBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkSexBox.Location = new System.Drawing.Point(252, 392);
            this.hkSexBox.Name = "hkSexBox";
            this.hkSexBox.Size = new System.Drawing.Size(201, 29);
            this.hkSexBox.TabIndex = 38;
            this.hkSexBox.TabStop = false;
            this.hkSexBox.Text = "Enter Sex";
            this.hkSexBox.Enter += new System.EventHandler(this.hkSexBox_Enter);
            this.hkSexBox.Leave += new System.EventHandler(this.hkSexBox_Leave);
            // 
            // NextBtnHousekeeping
            // 
            this.NextBtnHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.NextBtnHousekeeping.FlatAppearance.BorderSize = 0;
            this.NextBtnHousekeeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtnHousekeeping.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtnHousekeeping.ForeColor = System.Drawing.Color.White;
            this.NextBtnHousekeeping.Location = new System.Drawing.Point(43, 593);
            this.NextBtnHousekeeping.Name = "NextBtnHousekeeping";
            this.NextBtnHousekeeping.Size = new System.Drawing.Size(411, 48);
            this.NextBtnHousekeeping.TabIndex = 37;
            this.NextBtnHousekeeping.Text = "Next";
            this.NextBtnHousekeeping.UseVisualStyleBackColor = false;
            this.NextBtnHousekeeping.Click += new System.EventHandler(this.NextBtnHk_Click);
            this.NextBtnHousekeeping.MouseEnter += new System.EventHandler(this.NextBtnHousekeeping_MouseEnter);
            this.NextBtnHousekeeping.MouseLeave += new System.EventHandler(this.NextBtnHousekeeping_MouseLeave);
            // 
            // hkContactBox
            // 
            this.hkContactBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkContactBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkContactBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkContactBox.Location = new System.Drawing.Point(42, 441);
            this.hkContactBox.Name = "hkContactBox";
            this.hkContactBox.Size = new System.Drawing.Size(411, 29);
            this.hkContactBox.TabIndex = 36;
            this.hkContactBox.TabStop = false;
            this.hkContactBox.Text = "Enter Contact";
            this.hkContactBox.Enter += new System.EventHandler(this.hkContactBox_Enter);
            this.hkContactBox.Leave += new System.EventHandler(this.hkContactBox_Leave);
            // 
            // hkAgeBox
            // 
            this.hkAgeBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkAgeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkAgeBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkAgeBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkAgeBox.Location = new System.Drawing.Point(42, 392);
            this.hkAgeBox.Name = "hkAgeBox";
            this.hkAgeBox.Size = new System.Drawing.Size(204, 29);
            this.hkAgeBox.TabIndex = 35;
            this.hkAgeBox.TabStop = false;
            this.hkAgeBox.Text = "Enter Age";
            this.hkAgeBox.Enter += new System.EventHandler(this.hkAgeBox_Enter);
            this.hkAgeBox.Leave += new System.EventHandler(this.hkAgeBox_Leave);
            // 
            // hkLastNameBox
            // 
            this.hkLastNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkLastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkLastNameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkLastNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkLastNameBox.Location = new System.Drawing.Point(42, 342);
            this.hkLastNameBox.Name = "hkLastNameBox";
            this.hkLastNameBox.Size = new System.Drawing.Size(411, 29);
            this.hkLastNameBox.TabIndex = 34;
            this.hkLastNameBox.TabStop = false;
            this.hkLastNameBox.Text = "Enter Last Name";
            this.hkLastNameBox.Enter += new System.EventHandler(this.hkLastNameBox_Enter);
            this.hkLastNameBox.Leave += new System.EventHandler(this.hkLastNameBox_Leave);
            // 
            // hkMiddleNameBox
            // 
            this.hkMiddleNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkMiddleNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkMiddleNameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkMiddleNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkMiddleNameBox.Location = new System.Drawing.Point(42, 294);
            this.hkMiddleNameBox.Name = "hkMiddleNameBox";
            this.hkMiddleNameBox.Size = new System.Drawing.Size(411, 29);
            this.hkMiddleNameBox.TabIndex = 33;
            this.hkMiddleNameBox.TabStop = false;
            this.hkMiddleNameBox.Text = "Enter Middle Name";
            this.hkMiddleNameBox.Enter += new System.EventHandler(this.hkMiddleNameBox_Enter);
            this.hkMiddleNameBox.Leave += new System.EventHandler(this.hkMiddleNameBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(39, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "As Housekeeper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 65);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sign Up";
            // 
            // hkFirstNameBox
            // 
            this.hkFirstNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkFirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkFirstNameBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkFirstNameBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkFirstNameBox.Location = new System.Drawing.Point(43, 245);
            this.hkFirstNameBox.Name = "hkFirstNameBox";
            this.hkFirstNameBox.Size = new System.Drawing.Size(411, 29);
            this.hkFirstNameBox.TabIndex = 32;
            this.hkFirstNameBox.TabStop = false;
            this.hkFirstNameBox.Text = "Enter First Name";
            this.hkFirstNameBox.Enter += new System.EventHandler(this.hkFirstNameBox_Enter);
            this.hkFirstNameBox.Leave += new System.EventHandler(this.hkFirstNameBox_Leave);
            // 
            // hkSkillBox
            // 
            this.hkSkillBox.BackColor = System.Drawing.SystemColors.Control;
            this.hkSkillBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hkSkillBox.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkSkillBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.hkSkillBox.Location = new System.Drawing.Point(42, 535);
            this.hkSkillBox.Name = "hkSkillBox";
            this.hkSkillBox.Size = new System.Drawing.Size(411, 29);
            this.hkSkillBox.TabIndex = 40;
            this.hkSkillBox.TabStop = false;
            this.hkSkillBox.Text = "Enter Skill";
            this.hkSkillBox.Enter += new System.EventHandler(this.hkSkillBox_Enter);
            this.hkSkillBox.Leave += new System.EventHandler(this.hkSkillBox_Leave);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backBtn.Location = new System.Drawing.Point(42, 26);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 48);
            this.backBtn.TabIndex = 41;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // panelHkParent
            // 
            this.panelHkParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHkParent.Location = new System.Drawing.Point(0, 0);
            this.panelHkParent.Name = "panelHkParent";
            this.panelHkParent.Size = new System.Drawing.Size(504, 673);
            this.panelHkParent.TabIndex = 42;
            // 
            // SignUpHousekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 673);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.hkSkillBox);
            this.Controls.Add(this.hkAddressBox);
            this.Controls.Add(this.hkSexBox);
            this.Controls.Add(this.NextBtnHousekeeping);
            this.Controls.Add(this.hkContactBox);
            this.Controls.Add(this.hkAgeBox);
            this.Controls.Add(this.hkLastNameBox);
            this.Controls.Add(this.hkMiddleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hkFirstNameBox);
            this.Controls.Add(this.panelHkParent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUpHousekeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up Housekeeping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hkAddressBox;
        private System.Windows.Forms.TextBox hkSexBox;
        private System.Windows.Forms.Button NextBtnHousekeeping;
        private System.Windows.Forms.TextBox hkContactBox;
        private System.Windows.Forms.TextBox hkAgeBox;
        private System.Windows.Forms.TextBox hkLastNameBox;
        private System.Windows.Forms.TextBox hkMiddleNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hkFirstNameBox;
        private System.Windows.Forms.TextBox hkSkillBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panelHkParent;
    }
}