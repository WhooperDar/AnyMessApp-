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
    public partial class SignUpPage : UserControl
    {
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

        public SignUpPage()
        {
            InitializeComponent();

            agencyBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, agencyBtn.Width, agencyBtn.Height, 30, 30));

            employerBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, employerBtn.Width, employerBtn.Height, 30, 30));

            housekeperBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, housekeperBtn.Width, housekeperBtn.Height, 30, 30));
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static bool signButtonsClicked; 
        public static bool SignButtonsClicked { get => signButtonsClicked;  }
        private void agencyBtn_Click(object sender, EventArgs e)
        {
            signButtonsClicked = true;
            SignUpAgency agencySignUp = new SignUpAgency();
            agencySignUp.ShowDialog();
        }

        private void employerBtn_Click(object sender, EventArgs e)
        {
            SignUpEmployer employerSignUp = new SignUpEmployer();
            employerSignUp.ShowDialog();
        }

        private void housekeperBtn_Click(object sender, EventArgs e)
        {
            SignUpHousekeeping housekeepingSignup = new SignUpHousekeeping();
            housekeepingSignup.ShowDialog();
        }

        #region Mouse Hover Effects
        // Mouse Hover Effects (Sign Up As Buttons)
        private void agencyBtn_MouseEnter(object sender, EventArgs e)
        {
            agencyBtn.BackColor = Color.FromArgb(255, 201, 72); 
            agencyBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void agencyBtn_MouseLeave(object sender, EventArgs e)
        {
            agencyBtn.BackColor = Color.FromArgb(5, 62, 189);
            agencyBtn.ForeColor = Color.White; 
        }

        private void employerBtn_MouseEnter(object sender, EventArgs e)
        {
            employerBtn.BackColor = Color.FromArgb(255, 201, 72);
            employerBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void employerBtn_MouseLeave(object sender, EventArgs e)
        {
            employerBtn.BackColor = Color.FromArgb(5, 62, 189);
            employerBtn.ForeColor = Color.White;
        }

        private void housekeperBtn_MouseEnter(object sender, EventArgs e)
        {
            housekeperBtn.BackColor = Color.FromArgb(255, 201, 72);
            housekeperBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void housekeperBtn_MouseLeave(object sender, EventArgs e)
        {
            housekeperBtn.BackColor = Color.FromArgb(5, 62, 189);
            housekeperBtn.ForeColor = Color.White;
        }
        #endregion

    }
}
