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
    public partial class LoginMe : UserControl
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

        public LoginMe()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            signInBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signInBtn.Width, signInBtn.Height, 30, 30));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private static bool signBtnClick; 
        public static bool SignBtnClick { get => signBtnClick; }
        private void signInBtn_Click(object sender, EventArgs e)
        {
            signBtnClick = false;
            MainPage mainpage = new MainPage();
            mainpage.ShowDialog();

            this.Hide();
        }
    }
}
