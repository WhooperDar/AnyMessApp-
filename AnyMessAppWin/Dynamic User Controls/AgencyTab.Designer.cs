
namespace AnyMessAppWin.Dynamic_User_Controls
{
    partial class AgencyTab
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
            this.pbAgency = new System.Windows.Forms.PictureBox();
            this.labelAgencyName = new System.Windows.Forms.Label();
            this.labelPlaceAgency = new System.Windows.Forms.Label();
            this.hireMeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(72)))));
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 24);
            this.panel1.TabIndex = 1;
            // 
            // pbAgency
            // 
            this.pbAgency.Location = new System.Drawing.Point(0, 0);
            this.pbAgency.Name = "pbAgency";
            this.pbAgency.Size = new System.Drawing.Size(166, 167);
            this.pbAgency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgency.TabIndex = 2;
            this.pbAgency.TabStop = false;
            // 
            // labelAgencyName
            // 
            this.labelAgencyName.AutoSize = true;
            this.labelAgencyName.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.labelAgencyName.Location = new System.Drawing.Point(182, 40);
            this.labelAgencyName.Name = "labelAgencyName";
            this.labelAgencyName.Size = new System.Drawing.Size(138, 24);
            this.labelAgencyName.TabIndex = 3;
            this.labelAgencyName.Text = "Agency Name";
            // 
            // labelPlaceAgency
            // 
            this.labelPlaceAgency.AutoSize = true;
            this.labelPlaceAgency.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceAgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(173)))), ((int)(((byte)(200)))));
            this.labelPlaceAgency.Location = new System.Drawing.Point(182, 69);
            this.labelPlaceAgency.Name = "labelPlaceAgency";
            this.labelPlaceAgency.Size = new System.Drawing.Size(50, 18);
            this.labelPlaceAgency.TabIndex = 4;
            this.labelPlaceAgency.Text = "Place";
            // 
            // hireMeBtn
            // 
            this.hireMeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(62)))), ((int)(((byte)(189)))));
            this.hireMeBtn.FlatAppearance.BorderSize = 0;
            this.hireMeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hireMeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.hireMeBtn.Location = new System.Drawing.Point(186, 121);
            this.hireMeBtn.Name = "hireMeBtn";
            this.hireMeBtn.Size = new System.Drawing.Size(134, 28);
            this.hireMeBtn.TabIndex = 5;
            this.hireMeBtn.Text = "Hire Me";
            this.hireMeBtn.UseVisualStyleBackColor = false;
            // 
            // AgencyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.hireMeBtn);
            this.Controls.Add(this.labelPlaceAgency);
            this.Controls.Add(this.labelAgencyName);
            this.Controls.Add(this.pbAgency);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AgencyTab";
            this.Size = new System.Drawing.Size(355, 170);
            ((System.ComponentModel.ISupportInitialize)(this.pbAgency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAgency;
        private System.Windows.Forms.Label labelAgencyName;
        private System.Windows.Forms.Label labelPlaceAgency;
        private System.Windows.Forms.Button hireMeBtn;
    }
}
