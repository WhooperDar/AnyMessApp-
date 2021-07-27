using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin
{
    public partial class MainFormPage : Form
    {
        public MainFormPage()
        {
            InitializeComponent();
            // Form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region Hover Effects(Main Category)
        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            homeBtn.Image = Properties.Resources.home_shade;
        }

        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            homeBtn.Image = Properties.Resources.home;
        }

        private void hkListBtn_MouseEnter(object sender, EventArgs e)
        {
            hkListBtn.Image = Properties.Resources.hklist_shade;
        }

        private void hkListBtn_MouseLeave(object sender, EventArgs e)
        {
            hkListBtn.Image = Properties.Resources.hklist;
        }

        private void agencyListBtn_MouseEnter(object sender, EventArgs e)
        {
            agencyListBtn.Image = Properties.Resources.agency_shade; 
        }

        private void agencyListBtn_MouseLeave(object sender, EventArgs e)
        {
            agencyListBtn.Image = Properties.Resources.agency;
        }

        private void profileBtn_MouseEnter(object sender, EventArgs e)
        {
            profileBtn.Image = Properties.Resources.profile_shade; 
        }

        private void profileBtn_MouseLeave(object sender, EventArgs e)
        {
            profileBtn.Image = Properties.Resources.profile;
        }

        private void settingBtn_MouseEnter(object sender, EventArgs e)
        {
            settingBtn.Image = Properties.Resources.setting_shade; 
        }

        private void settingBtn_MouseLeave(object sender, EventArgs e)
        {
            settingBtn.Image = Properties.Resources.setting;
        }

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            mainBtn.Image = Properties.Resources.mainlogo3_shade;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            mainBtn.Image = Properties.Resources.mainlogo3;
        }

        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.Image = Properties.Resources.cancel_shade;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.Image = Properties.Resources.cancel20;
        }

        
        private void homeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            homeBtn.Image = Properties.Resources.home_orange;
        }

        #endregion

        #region Click Events(Click Buttons)
        private void hkListBtn_Click(object sender, EventArgs e)
        {
            hkListBtn.Image = Properties.Resources.hklist_orange;
            openChildForm(new HousekeepingListForm());
        }

        private void agencyListBtn_Click(object sender, EventArgs e)
        {
            agencyListBtn.Image = Properties.Resources.agency_orange;
            openChildForm(new AgencyList());
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            profileBtn.Image = Properties.Resources.profile_orange;
            openChildForm(new ProfileSection()); 
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingBtn.Image = Properties.Resources.setting_orange;
            openChildForm(new Settings()); 
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeBtn.Image = Properties.Resources.home_orange;
            openChildForm(new HomeTabPanel());
        }

        private void MainFormPage_Load(object sender, EventArgs e)
        {

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
            panelParent.Controls.Add(childForm);
            panelParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            // Class Instances
            HomeTabPanel maintab = new HomeTabPanel();
            AgencyList agencytab = new AgencyList();

            // Hide all open forms
            maintab.Close();
            agencytab.Close();
        }
    }
}
