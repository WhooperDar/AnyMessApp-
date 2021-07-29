using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin
{
    public partial class Settings : Form
    {
        // For Rounded Radius Buttons
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Settings()
        {
            InitializeComponent();

            settingAccount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingAccount.Width, settingAccount.Height, 30, 30));

            settingSupport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingSupport.Width, settingSupport.Height, 30, 30));

            settingAboutUs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingAboutUs.Width, settingAboutUs.Height, 30, 30));
        }

        private void exitSettingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingSecurity_Click(object sender, EventArgs e)
        {

        }

        #region Mouse Hover Effects(Hover and Leave Events)
        private void settingAccount_MouseEnter(object sender, EventArgs e)
        {
            settingAccount.Image = Properties.Resources.user_blue20px;
            settingAccount.ForeColor = Color.FromArgb(5, 62, 189);
            settingAccount.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingAccount_MouseLeave(object sender, EventArgs e)
        {
            settingAccount.Image = Properties.Resources.account_white20;
            settingAccount.ForeColor = Color.FromArgb(239, 239, 239);
            settingAccount.BackColor = Color.FromArgb(5, 62, 189);
        }
        
        private void settingSupport_MouseEnter(object sender, EventArgs e)
        {
            settingSupport.Image = Properties.Resources.supportme_blue20px;
            settingSupport.ForeColor = Color.FromArgb(5, 62, 189);
            settingSupport.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingSupport_MouseLeave(object sender, EventArgs e)
        {
            settingSupport.Image = Properties.Resources.support_white20;
            settingSupport.ForeColor = Color.FromArgb(239, 239, 239);
            settingSupport.BackColor = Color.FromArgb(5, 62, 189);
        }

        private void settingAboutUs_MouseEnter(object sender, EventArgs e)
        {
            settingAboutUs.Image = Properties.Resources.aboutme_blue20px;
            settingAboutUs.ForeColor = Color.FromArgb(5, 62, 189);
            settingAboutUs.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingAboutUs_MouseLeave(object sender, EventArgs e)
        {
            settingAboutUs.Image = Properties.Resources.questionmark_white20;
            settingAboutUs.ForeColor = Color.FromArgb(239, 239, 239);
            settingAboutUs.BackColor = Color.FromArgb(5, 62, 189);
        }

        private void exitSettingBtn_MouseEnter(object sender, EventArgs e)
        {
            exitSettingBtn.BackColor = Color.FromArgb(5, 62, 189);
        }

        private void exitSettingBtn_MouseLeave(object sender, EventArgs e)
        {
            exitSettingBtn.BackColor = Color.FromArgb(239, 239, 239);
        }


        #endregion
        // Display Forms 
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelParentSettings.Controls.Add(childForm);
            panelParentSettings.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void settingSupport_Click(object sender, EventArgs e)
        {
            openChildForm(new ContentSettings.HelpAndSupport()); 
        }
    }
}
