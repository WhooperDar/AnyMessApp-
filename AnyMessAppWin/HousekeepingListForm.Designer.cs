
namespace AnyMessAppWin
{
    partial class HousekeepingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HousekeepingListForm));
            this.exitHousekeepingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitHousekeepingBtn
            // 
            this.exitHousekeepingBtn.Location = new System.Drawing.Point(22, 12);
            this.exitHousekeepingBtn.Name = "exitHousekeepingBtn";
            this.exitHousekeepingBtn.Size = new System.Drawing.Size(92, 48);
            this.exitHousekeepingBtn.TabIndex = 0;
            this.exitHousekeepingBtn.Text = "X";
            this.exitHousekeepingBtn.UseVisualStyleBackColor = true;
            this.exitHousekeepingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F);
            this.label1.Location = new System.Drawing.Point(305, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Housekeeping List";
            // 
            // HousekeepingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 858);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitHousekeepingBtn);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HousekeepingListForm";
            this.Text = "HousekeepingListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitHousekeepingBtn;
        private System.Windows.Forms.Label label1;
    }
}