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

        #region Database Configuration
        IFirebaseConfig configSignIn = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        IFirebaseClient clientLogin;

        private static bool signBtnClick;
        public static bool SignBtnClick { get => signBtnClick; }
        private void signInBtn_Click(object sender, EventArgs e)
        {
            signBtnClick = true;
            clientLogin = new FireSharp.FirebaseClient(configSignIn);

            // Fetch Data From Firebase

            /*FirebaseResponse responseLogin = await clientLogin.GetTaskAsync("Accounts/" + usernameBox.Text);

            DataCreateAccount fetchedData = responseLogin.ResultAs<DataCreateAccount>();
            string username = fetchedData.Username;
            string password = fetchedData.Password; 

            if(username == usernameBox.Text || password == fetchedData.Password)
            {
                MessageBox.Show("Welcome to AnyMess");
            }
            this.Hide();
*/
            MainFormPage mainPage = new MainFormPage();
            mainPage.ShowDialog();
        }
        #endregion

        private static bool createAccountClicked;
        public static bool CreateAccountClicked { get => createAccountClicked; }
        private void button1_Click(object sender, EventArgs e)
        {
            createAccountClicked = true; 
        }

        #region Mouse Hover Effects 
        private void signInBtn_MouseEnter(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(255, 201, 72);
            signInBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void signInBtn_MouseLeave(object sender, EventArgs e)
        {
            signInBtn.BackColor = Color.FromArgb(5, 62, 189);
            signInBtn.ForeColor = Color.White;
        }
        #endregion 
    }
}
