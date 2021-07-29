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

        IFirebaseConfig configSignIn = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };


        private static bool toMainform;
        public static bool ToMainForm { get => toMainform; }

        IFirebaseClient client;

        public static string TypeOfDataUser { get; set; }
        public static string FirstNameUser { get; set; }
        public static string UserNameUser { get; set; }

        private async void signInBtn_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(configSignIn);

            if (usernameBox.Text != "" && passwordBox.Text != "")
            {
                try
                {
                    FirebaseResponse response = await client.GetTaskAsync("Login Accounts/" + usernameBox.Text);

                    var result = response.ResultAs<DataCreateAccount>();

                    if (usernameBox.Text == result.Username && passwordBox.Text == result.Password)
                    {
                        TypeOfDataUser = result.TypeOfUser;
                        FirstNameUser = result.FirstName;
                        UserNameUser = result.Username;

                        MessageBox.Show("Login Successfully");
                        this.Hide();

                        toMainform = true;

                        MainFormPage mainPage = new MainFormPage();
                        mainPage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(usernameBox.Text + " is not registered! Please register now!");
                    }
                }
                catch (Exception)
                {
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    MessageBox.Show("Internet Connection Error");
                }
                
            }
            else
            {
                MessageBox.Show("Please fill up form!");
            }
            
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
        }
        #endregion
        private void createAccountLogin_Click(object sender, EventArgs e)
        {
            HideThisContents();
            openChildForm(new _3LoginForm());
        }
    }
}
