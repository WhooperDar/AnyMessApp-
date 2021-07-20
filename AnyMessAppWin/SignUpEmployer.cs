using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class SignUpEmployer : Form
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

        public SignUpEmployer()
        {
            InitializeComponent();

            // For Rounded Corners
            NextBtnEmployer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NextBtnEmployer.Width, NextBtnEmployer.Height, 30, 30));
        }

        #region Database Configuration
        // --------------------Saviing data to database------------------

        // Firebase Configuration
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        IFirebaseClient client;

        // Saving data to Database (Firebase) 

        private static string typedata; 
        public static string TypeDataEmployer { get => typedata;}
        private async void NextBtnEmployer_Click(object sender, EventArgs e)
        {
            typedata = "Employer";
            
            client = new FireSharp.FirebaseClient(config); // database connection

            // Prepare employer data to insert
            var dataEmployer = new DataEmployer
            {
                EmployerName = employerFirstNameBox.Text,
                EmployerMiddleName = employerMiddleNameBox.Text,
                EmployerLastName = employerLastNameBox.Text,
                EmployerAge = employerAgeBox.Text,
                EmployerSex = employerSexBox.Text,
                EmployerContactNumber = employerContactBox.Text,
                EmployerAddress = employerAddressBox.Text
            };

            // send data to firebase
            SetResponse response = await client.SetTaskAsync("Employer Information/" + employerFirstNameBox.Text, dataEmployer);
            DataEmployer resultEmployer = response.ResultAs<DataEmployer>();

            // get the response
            MessageBox.Show(resultEmployer.EmployerName + "added to database");

            returnToOldStateEmp();

            this.Hide(); // Closing Form

            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();          
        }
        #endregion 

        // Text Reset
        public void returnToOldStateEmp()
        {
            // text change
            employerFirstNameBox.Text = "Enter First Name";
            employerMiddleNameBox.Text = "Enter Middle Name";
            employerLastNameBox.Text = "Enter Last Name";
            employerAgeBox.Text = "Enter Age";
            employerSexBox.Text = "Enter Sex";
            employerContactBox.Text = "Enter Contact Number";
            employerAddressBox.Text = "Enter Address";

            // color change
            employerFirstNameBox.ForeColor = Color.Silver;
            employerMiddleNameBox.ForeColor = Color.Silver;
            employerLastNameBox.ForeColor = Color.Silver;
            employerAgeBox.ForeColor = Color.Silver;
            employerSexBox.ForeColor = Color.Silver;
            employerContactBox.ForeColor = Color.Silver;
            employerAddressBox.ForeColor = Color.Silver;
        }


        #region Text Hover Effects (textBox)
        // Leave Events
        private void employerFirstNameBox_Enter(object sender, EventArgs e)
        {
            if (employerFirstNameBox.Text == "Enter First Name")
            {
                employerFirstNameBox.Text = ""; 
                employerFirstNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerMiddleNameBox_Enter(object sender, EventArgs e)
        {
            if (employerMiddleNameBox.Text == "Enter Middle Name")
            {
                employerMiddleNameBox.Text = "";
                employerMiddleNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerLastNameBox_Enter(object sender, EventArgs e)
        {
            if (employerLastNameBox.Text == "Enter Last Name")
            {
                employerLastNameBox.Text = "";
                employerLastNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerAgeBox_Enter(object sender, EventArgs e)
        {
            if (employerAgeBox.Text == "Enter Age")
            {
                employerAgeBox.Text = "";
                employerAgeBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerSexBox_Enter(object sender, EventArgs e)
        {
            if (employerSexBox.Text == "Enter Sex")
            {
                employerSexBox.Text = "";
                employerSexBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerContactBox_Enter(object sender, EventArgs e)
        {
            if (employerContactBox.Text == "Enter Contact Number")
            {
                employerContactBox.Text = "";
                employerContactBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void employerAddressBox_Enter(object sender, EventArgs e)
        {
            if (employerAddressBox.Text == "Enter Address")
            {
                employerAddressBox.Text = "";
                employerAddressBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        #endregion


        #region Mouse Hover Effects(Next Button)
        private void NextBtnEmployer_MouseEnter(object sender, EventArgs e)
        {
            NextBtnEmployer.BackColor = Color.FromArgb(255, 201, 72);
            NextBtnEmployer.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void NextBtnEmployer_MouseLeave(object sender, EventArgs e)
        {
            NextBtnEmployer.BackColor = Color.FromArgb(5, 62, 189);
            NextBtnEmployer.ForeColor = Color.White;
        }
        #endregion 
    }
}
