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
    public partial class CreateAccount : Form
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
        public CreateAccount()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            createAccBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, createAccBtn.Width, createAccBtn.Height, 30, 30));
        }

        // Setting up configuration to DB 
        IFirebaseConfig configCreateAccount = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        IFirebaseClient clientCreateAccount;

        // Saving data to database

        private static bool createBtnClick; 
        public static bool CreateBtnClick { get => createBtnClick; }
        private async void createAccBtn_Click(object sender, EventArgs e)
        {
            // User Type Checker
            createBtnClick = true;
            clientCreateAccount = new FireSharp.FirebaseClient(configCreateAccount);

            var dataCreateAccount = new DataCreateAccount
            { 
                FirstName = firstNameCreate.Text,
                Username = usernameBox.Text,
                Email = emailBox.Text,
                Password = passwordBox.Text,
                ConfirmPassWord = confirmpassBox.Text
            };

            SetResponse response = await clientCreateAccount.SetTaskAsync("Accounts/" + usernameBox.Text, dataCreateAccount);

            MessageBox.Show("Account Created Successfully!");

            this.Close();
        }
        
        // Text Changed to blue
        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            passwordBox.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void confirmpassBox_Enter(object sender, EventArgs e)
        {
            confirmpassBox.ForeColor = Color.FromArgb(5, 62, 189);
        }
    }
}
