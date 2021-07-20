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
    public partial class HomeTabPanel : Form
    {
        // For Rounded Corner Buttons
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

        // Front End

        #region Form 
        public HomeTabPanel()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            hkBtnHireMe1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hkBtnHireMe1.Width, hkBtnHireMe1.Height, 30, 30));

            // For Rounded Corner Buttons
            hkBtnHireMe2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hkBtnHireMe2.Width, hkBtnHireMe2.Height, 30, 30));

            // For Rounded Corner Buttons
            ContactUs1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ContactUs1.Width, ContactUs1.Height, 30, 30));

            // For Rounded Corner Buttons
            ContactUs2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ContactUs2.Width, ContactUs2.Height, 30, 30));
        }
        #endregion

        #region Hover Effects Button Panels

        // Mouse Enter Events
        private void panelButton1_MouseEnter(object sender, EventArgs e)
        {
            panelButton1.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            panelButton1.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void panelButton2_MouseEnter(object sender, EventArgs e)
        {
            panelButton2.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            panelButton2.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void panelButton3_MouseEnter(object sender, EventArgs e)
        {
            panelButton3.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            panelButton3.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void panelButton4_MouseEnter(object sender, EventArgs e)
        {
            panelButton4.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            panelButton4.BackColor = Color.FromArgb(239, 239, 239);
        }// end 

        // Mouse Leave Event
        private void panelButton1_MouseLeave(object sender, EventArgs e)
        {
            panelButton1.FlatAppearance.BorderColor = Color.FromArgb(173, 177, 182);
            
        }
        private void panelButton2_MouseLeave(object sender, EventArgs e)
        {
            panelButton2.FlatAppearance.BorderColor = Color.FromArgb(173, 177, 182);
        }

        private void panelButton3_MouseLeave(object sender, EventArgs e)
        {
            panelButton3.FlatAppearance.BorderColor = Color.FromArgb(173, 177, 182);
        }
        private void panelButton4_MouseLeave(object sender, EventArgs e)
        {
            panelButton4.FlatAppearance.BorderColor = Color.FromArgb(173, 177, 182);
        }

        #endregion



        #region Mouse Hover Effects (Hire Me and Contact Us Buttons)
        private void hkBtnHireMe1_MouseEnter(object sender, EventArgs e)
        {
            hkBtnHireMe1.BackColor = Color.FromArgb(255, 201, 72);
            hkBtnHireMe1.ForeColor = Color.FromArgb(5, 62, 189); 
        }
        private void hkBtnHireMe1_MouseLeave(object sender, EventArgs e)
        {
            hkBtnHireMe1.BackColor = Color.FromArgb(5, 62, 189);
            hkBtnHireMe1.ForeColor = Color.FromArgb(239, 239, 239);
        }
        private void hkBtnHireMe2_MouseEnter(object sender, EventArgs e)
        {
            hkBtnHireMe2.BackColor = Color.FromArgb(255, 201, 72);
            hkBtnHireMe2.ForeColor = Color.FromArgb(5, 62, 189);
        }
        private void hkBtnHireMe2_MouseLeave(object sender, EventArgs e)
        {
            hkBtnHireMe2.BackColor = Color.FromArgb(5, 62, 189);
            hkBtnHireMe2.ForeColor = Color.FromArgb(239, 239, 239);
        }



        #endregion



        #region Mouse Hover Effects (Categories)
        // Mouse Enter Hover (Categories)
        private void CleaningBtn_MouseEnter(object sender, EventArgs e)
        {
            CleaningBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            CleaningBtn.ForeColor = Color.FromArgb(5, 62, 189);
            CleaningBtn.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void CookingBtn_MouseEnter_1(object sender, EventArgs e)
        {
            CookingBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            CookingBtn.ForeColor = Color.FromArgb(5, 62, 189);
            CookingBtn.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void LaundryButton_MouseEnter(object sender, EventArgs e)
        {
            LaundryButton.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            LaundryButton.ForeColor = Color.FromArgb(5, 62, 189);
            LaundryButton.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void SweepingBtn_MouseEnter(object sender, EventArgs e)
        {
            SweepingBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            SweepingBtn.ForeColor = Color.FromArgb(5, 62, 189);
            SweepingBtn.BackColor = Color.FromArgb(255, 201, 72);
        }

        // Mouse Leave (Category)
        private void CookingBtn_MouseLeave(object sender, EventArgs e)
        {
            CookingBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            CookingBtn.BackColor = Color.FromArgb(5, 62, 189);
            CookingBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void CleaningBtn_MouseLeave(object sender, EventArgs e)
        {
            CleaningBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            CleaningBtn.BackColor = Color.FromArgb(5, 62, 189);
            CleaningBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void LaundryButton_MouseLeave(object sender, EventArgs e)
        {
            LaundryButton.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            LaundryButton.BackColor = Color.FromArgb(5, 62, 189);
            LaundryButton.ForeColor = Color.FromArgb(239, 239, 239);

        }

        private void SweepingBtn_MouseLeave(object sender, EventArgs e)
        {
            SweepingBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            SweepingBtn.BackColor = Color.FromArgb(5, 62, 189);
            SweepingBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }
        #endregion

     

        #region Mouse Hover Effect (Market Service)
        // Mouse Enter Event (Market Service)
        private void MarketServiceBtn_MouseEnter(object sender, EventArgs e)
        {
            MarketServiceBtn.BackColor = Color.FromArgb(255, 201, 72);
            MarketServiceBtn.ForeColor = Color.FromArgb(5, 62, 189);
            MarketServiceBtn.Image = Properties.Resources.plane_blue;
        }
        // Mouse Leave Event (Market Service)
        private void MarketServiceBtn_MouseLeave(object sender, EventArgs e)
        {
            MarketServiceBtn.BackColor = Color.FromArgb(5, 62, 189);
            MarketServiceBtn.ForeColor = Color.FromArgb(239, 239, 239);
            MarketServiceBtn.Image = Properties.Resources.plane_white;
        }
        #endregion



        #region Mouse Hover Effect (Exit Button)
        private void homeExitBtn_MouseEnter(object sender, EventArgs e)
        {
            homeExitBtn.BackColor = Color.FromArgb(5, 62, 189);
        }

        private void homeExitBtn_MouseLeave(object sender, EventArgs e)
        {
            homeExitBtn.FlatAppearance.BorderColor = Color.FromArgb(5, 62, 189);
            homeExitBtn.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void ContactUs1_MouseEnter(object sender, EventArgs e)
        {
            ContactUs1.BackColor = Color.FromArgb(255, 201, 72);
            ContactUs1.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void ContactUs1_MouseLeave(object sender, EventArgs e)
        {
            ContactUs1.BackColor = Color.FromArgb(5, 62, 189);
            ContactUs1.ForeColor = Color.White;
        }

        private void ContactUs2_MouseEnter(object sender, EventArgs e)
        {
            ContactUs2.BackColor = Color.FromArgb(255, 201, 72);
            ContactUs2.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void ContactUs2_MouseLeave(object sender, EventArgs e)
        {
            ContactUs2.BackColor = Color.FromArgb(5, 62, 189);
            ContactUs2.ForeColor = Color.White;
        }
        #endregion

        private void hkBtnHireMe1_Click(object sender, EventArgs e)
        {

        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
