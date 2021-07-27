﻿
namespace AnyMessAppWin.Dynamic_User_Controls
{
    partial class HousekeeperTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.hireMeBtnHk = new System.Windows.Forms.Button();
            this.labelSkill = new System.Windows.Forms.Label();
            this.labelHkName = new System.Windows.Forms.Label();
            this.pbHousekeeping = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbHousekeeping)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 20);
            this.panel1.TabIndex = 0;
            // 
            // hireMeBtnHk
            // 
            this.hireMeBtnHk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.hireMeBtnHk.FlatAppearance.BorderSize = 0;
            this.hireMeBtnHk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireMeBtnHk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.hireMeBtnHk.Location = new System.Drawing.Point(187, 119);
            this.hireMeBtnHk.Name = "hireMeBtnHk";
            this.hireMeBtnHk.Size = new System.Drawing.Size(134, 28);
            this.hireMeBtnHk.TabIndex = 9;
            this.hireMeBtnHk.Text = "Hire Me";
            this.hireMeBtnHk.UseVisualStyleBackColor = false;
            // 
            // labelSkill
            // 
            this.labelSkill.AutoSize = true;
            this.labelSkill.BackColor = System.Drawing.Color.White;
            this.labelSkill.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.labelSkill.Location = new System.Drawing.Point(183, 67);
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(43, 20);
            this.labelSkill.TabIndex = 8;
            this.labelSkill.Text = "Skill";
            // 
            // labelHkName
            // 
            this.labelHkName.AutoSize = true;
            this.labelHkName.BackColor = System.Drawing.Color.White;
            this.labelHkName.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelHkName.Location = new System.Drawing.Point(183, 38);
            this.labelHkName.Name = "labelHkName";
            this.labelHkName.Size = new System.Drawing.Size(157, 24);
            this.labelHkName.TabIndex = 7;
            this.labelHkName.Text = "Applicant Name";
            // 
            // pbHousekeeping
            // 
            this.pbHousekeeping.Location = new System.Drawing.Point(1, -2);
            this.pbHousekeeping.Name = "pbHousekeeping";
            this.pbHousekeeping.Size = new System.Drawing.Size(166, 167);
            this.pbHousekeeping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHousekeeping.TabIndex = 6;
            this.pbHousekeeping.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Location = new System.Drawing.Point(164, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(191, 170);
            this.panelChild.TabIndex = 10;
            // 
            // HousekeeperTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hireMeBtnHk);
            this.Controls.Add(this.labelSkill);
            this.Controls.Add(this.labelHkName);
            this.Controls.Add(this.pbHousekeeping);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChild);
            this.Name = "HousekeeperTab";
            this.Size = new System.Drawing.Size(355, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pbHousekeeping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hireMeBtnHk;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.Label labelHkName;
        private System.Windows.Forms.PictureBox pbHousekeeping;
        private System.Windows.Forms.Panel panelChild;
    }
}