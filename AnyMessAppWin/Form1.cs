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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response; 

namespace AnyMessAppWin
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            // For Rounded Buttons
            this.FormBorderStyle = FormBorderStyle.None;
            getStartedBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, getStartedBtn.Width, getStartedBtn.Height, 30, 30));

            // Hide Login Page and Sign Up Page 
            loginSignUp1.Hide();
            signUpPage1.Hide();
            loginMe1.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        // Get Started button 
        private void getStarted_Click(object sender, EventArgs e)
        {
            loginSignUp1.Show();
            signUpPage1.Hide();
            loginMe1.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Carousel (Image Slide Show) 
        private int imageNumber = 1;
        private void LoadImages()
        {
            if (imageNumber == 9)
            {
                imageNumber = 1;
            }
            slidePictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;

            switch (slidePictureBox.ImageLocation)
            {
                case @"Images\1.jpg":
                    textBoxTop.Text = "You don't have time for laundry?";
                    textBoxBottom.Text = "Hire a Launderer Now!";
                    break;
                case @"Images\2.jpg":
                    textBoxTop.Text = "You don't have time for laundry?";
                    textBoxBottom.Text = "Hire a Launderer Now!";
                    break;
                case @"Images\3.jpg":
                    textBoxTop.Text = "You don't have time for cooking?";
                    textBoxBottom.Text = "Hire a Home Chef Now!";
                    break;
                case @"Images\4.jpg":
                    textBoxTop.Text = "You don't have time for cooking?";
                    textBoxBottom.Text = "Hire a Home Chef Now!";
                    break;
                case @"Images\5.jpg":
                    textBoxTop.Text = "You don't have time for cleaning?";
                    textBoxBottom.Text = "Hire a Cleaner Now!";
                    break;

                case @"Images\6.jpg":
                    textBoxTop.Text = "You don't have time for cleaning?";
                    textBoxBottom.Text = "Hire a Cleaner Now!";
                    break;
                case @"Images\7.jpg":
                    textBoxTop.Text = "Tired of sweeping leaves on your lawn?";
                    textBoxBottom.Text = "Hire a Sweeper Now!";
                    break;
                case @"Images\8.jpg":
                    textBoxTop.Text = "Tired of sweeping leaves on your lawn?";
                    textBoxBottom.Text = "Hire a Sweeper Now!";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImages(); 
        }

        // Link to sign up page (sign as)
        private void signUpTimer_Tick(object sender, EventArgs e)
        {
            if (LoginSignUp.ButtonHasClick) {
                signUpPage1.Show();
                loginSignUp1.Hide();
                loginMe1.Hide();
            }

            if (LoginSignUp.LoginButtonClick) {
                loginMe1.Show();
                loginSignUp1.Hide();
                signUpPage1.Hide();
            }

            if (LoginMe.SignBtnClick)
            {
                this.Hide();
            }

            if (LoginMe.CreateAccountClicked)
            {
                signUpPage1.Show();
                loginMe1.Hide();
                loginSignUp1.Hide();
            }

            if (SignUpPage.SignButtonsClicked)
            {
                this.Hide();
            }

            /*if (SignUpAgency.BackAgencyClicked) {
                this.ShowDialog();
                signUpPage1.Show();
                
            }*/

        }

        private void loginMe1_Load(object sender, EventArgs e)
        {

        }

        // Mouse Hover Effects
        private void getStartedBtn_MouseEnter(object sender, EventArgs e)
        {
            getStartedBtn.BackColor = Color.FromArgb(255, 201, 72);
            getStartedBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void getStartedBtn_MouseLeave(object sender, EventArgs e)
        {
            getStartedBtn.BackColor = Color.FromArgb(5, 62, 189);
            getStartedBtn.ForeColor = Color.White;
        }
    }
}

