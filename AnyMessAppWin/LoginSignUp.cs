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
    public partial class LoginSignUp : UserControl
    {
        // For rounded circle button
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        ); // end

        public LoginSignUp()
        {
            InitializeComponent();

            // For rounded circle button
            loginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginButton.Width, loginButton.Height, 30, 30));

            SignUpBotton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SignUpBotton.Width, SignUpBotton.Height, 30, 30));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static bool loginbuttonClick; 
        public static bool LoginButtonClick { get => loginbuttonClick; }
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginbuttonClick = true;
            this.Hide();
        }

        // a link from LoginSignUp to SignUpPage 
        // using properties
        public static bool buttonHasClick = false;
        public static bool ButtonHasClick { get => buttonHasClick; }
        private void SignUpBotton_Click(object sender, EventArgs e)
        {
            buttonHasClick = true;
            this.Hide();

            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }

        #region Mouse Hover Effects 
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(255, 201, 72);
            loginButton.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(5, 62, 189);
            loginButton.ForeColor = Color.White;
        }

        private void SignUpBotton_MouseEnter(object sender, EventArgs e)
        {
            SignUpBotton.BackColor = Color.FromArgb(255, 201, 72);
            SignUpBotton.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void SignUpBotton_MouseLeave(object sender, EventArgs e)
        {
            SignUpBotton.BackColor = Color.FromArgb(5, 62, 189);
            SignUpBotton.ForeColor = Color.White;
        }
        #endregion
    }
}
