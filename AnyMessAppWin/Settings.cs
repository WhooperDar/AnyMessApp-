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

            settingNotif.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingNotif.Width, settingNotif.Height, 30, 30));

            settingAppearance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingAppearance.Width, settingAppearance.Height, 30, 30));

            settingSecurity.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, settingSecurity.Width, settingSecurity.Height, 30, 30));


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
        

        private void settingNotif_MouseEnter(object sender, EventArgs e)
        {
            settingNotif.Image = Properties.Resources.notif_blue20px;
            settingNotif.ForeColor = Color.FromArgb(5, 62, 189);
            settingNotif.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingNotif_MouseLeave(object sender, EventArgs e)
        {
            settingNotif.Image = Properties.Resources.notif_white20;
            settingNotif.ForeColor = Color.FromArgb(239, 239, 239);
            settingNotif.BackColor = Color.FromArgb(5, 62, 189); 
        }

        private void settingAppearance_MouseEnter(object sender, EventArgs e)
        {
            settingAppearance.Image = Properties.Resources.appearance_blue20px;
            settingAppearance.ForeColor = Color.FromArgb(5, 62, 189);
            settingAppearance.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingAppearance_MouseLeave(object sender, EventArgs e)
        {
            settingAppearance.Image = Properties.Resources.appearance_white20;
            settingAppearance.ForeColor = Color.FromArgb(239, 239, 239);
            settingAppearance.BackColor = Color.FromArgb(5, 62, 189);
        }

        private void settingSecurity_MouseEnter(object sender, EventArgs e)
        {
            settingSecurity.Image = Properties.Resources.security_blue20px;
            settingSecurity.ForeColor = Color.FromArgb(5, 62, 189);
            settingSecurity.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void settingSecurity_MouseLeave(object sender, EventArgs e)
        {
            settingSecurity.Image = Properties.Resources.security_white20;
            settingSecurity.ForeColor = Color.FromArgb(239, 239, 239);
            settingSecurity.BackColor = Color.FromArgb(5, 62, 189);
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


    }
}
