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

        private void agencyBtn_Click(object sender, EventArgs e)
        {
            SignUpAgency agencySignUp = new SignUpAgency();
            agencySignUp.ShowDialog();

           /* this.Hide();*/
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
    }
}
