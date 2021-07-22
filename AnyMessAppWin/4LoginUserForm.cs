using FireSharp.Config;
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
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AnyMessAppWin
{
    public partial class LoginUserForm : Form
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

        public LoginUserForm()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            signInBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, signInBtn.Width, signInBtn.Height, 30, 30));
        }

        private void exitBtnSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        IFirebaseConfig configSignIn = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        
        private static bool toMainform;
        public static bool ToMainForm { get => toMainform; }
        IFirebaseClient client;
        private void signInBtn_Click(object sender, EventArgs e)
        {
            toMainform = true;

            client = new FireSharp.FirebaseClient(configSignIn);

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

        #region Mouse Hover Effect(Create Account, Forget Password)
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

        private void createAccountLogin_MouseEnter(object sender, EventArgs e)
        {
            createAccountLogin.ForeColor = Color.FromArgb(255, 201, 72);
        }

        private void createAccountLogin_MouseLeave(object sender, EventArgs e)
        {
            createAccountLogin.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void forgetBtn_MouseEnter(object sender, EventArgs e)
        {
            forgetBtn.ForeColor = Color.FromArgb(255, 201, 72);
        }

        private void forgetBtn_MouseLeave(object sender, EventArgs e)
        {
            forgetBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }
        #endregion

        #region Utility Functions(Open Child Form, Hide Components)
        private Form activeForm = null; 
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelSignInParent.Controls.Add(childForm);
            panelSignInParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HideThisContents()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            usernameText.Hide();
            usernameBox.Hide();
            passwordBox.Hide();
            label4.Hide();
            forgetBtn.Hide();
            signInBtn.Hide();
            label8.Hide();
            createAccountLogin.Hide();
            exitBtnSignIn.Hide();
        }
        #endregion
        private void createAccountLogin_Click(object sender, EventArgs e)
        {
            HideThisContents();
            openChildForm(new _3LoginForm());
        }
    }
}
