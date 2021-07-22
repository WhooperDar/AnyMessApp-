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
    public partial class SignUpAgency : Form
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

        public SignUpAgency()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            NextBtnAgency.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NextBtnAgency.Width, NextBtnAgency.Height, 30, 30));
        }

        private void SignUpAgency_Load(object sender, EventArgs e)
        {
        }

        //------------Text Color Changed------------------
        private void agencyNameBox_Enter(object sender, EventArgs e)
        {
            if(agencyNameBox.Text == "Enter Agency Name")
            {
                agencyNameBox.Text = "";
                agencyNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void agencyAddressBox_Enter(object sender, EventArgs e)
        {
            if (agencyAddressBox.Text == "Enter Address")
            {
                agencyAddressBox.Text = "";
                agencyAddressBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void agencyContactBox_Enter(object sender, EventArgs e)
        {
            if (agencyContactBox.Text == "Enter Contact Number")
            {
                agencyContactBox.Text = "";
                agencyContactBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void agencyWebsiteBox_Enter(object sender, EventArgs e)
        {
            if (agencyWebsiteBox.Text == "Enter Website")
            {
                agencyWebsiteBox.Text = "";
                agencyWebsiteBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void agencyCodeBox_Enter(object sender, EventArgs e)
        {
            if (agencyCodeBox.Text == "Enter Agency Code")
            {
                agencyCodeBox.Text = "";
                agencyCodeBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }
        //------------Text Color Changed------------------


        // --------------------Saviing data to database------------------

        // Firebase Configuration
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        IFirebaseClient client;
        private async void NextBtnAgency_Click(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config); // database connection

            // Prepare data to insert
            var data = new Data
            {
                AgencyName = agencyNameBox.Text,
                AgencyAddress = agencyAddressBox.Text,
                AgencyContactNumber = agencyContactBox.Text,
                AgencyWebsite = agencyWebsiteBox.Text,
                AgencyCode = agencyCodeBox.Text
            };

            // Insert Data to firebase
            SetResponse response = await client.SetTaskAsync("Agency Information/"+agencyNameBox.Text, data); // 
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Added " + result.AgencyName + " to firebase");

            this.Hide();

            CreateAccount createAccountAgency = new CreateAccount();
            createAccountAgency.ShowDialog();

            
        }

        // Reset Text
        private void returnToOldState()
        {
            // return textboxes to old state
            agencyNameBox.Text = "Enter Agency Name";
            agencyAddressBox.Text = "Enter Address";
            agencyContactBox.Text = "Enter Contact Number";
            agencyWebsiteBox.Text = "Enter Website";
            agencyCodeBox.Text = "Enter Agency Code";

            // also the colors
            agencyNameBox.ForeColor = Color.Silver;
            agencyAddressBox.ForeColor = Color.Silver;
            agencyContactBox.ForeColor = Color.Silver;
            agencyWebsiteBox.ForeColor = Color.Silver;
            agencyCodeBox.ForeColor = Color.Silver;
        }

        #region Text Effects
        // Leave Events
        private void agencyNameBox_Leave(object sender, EventArgs e)
        {
            if (agencyNameBox.Text == "")
            {
                agencyNameBox.Text = "Enter Agency Name";
                agencyNameBox.ForeColor = Color.Silver;
            }
        }

        private void agencyAddressBox_Leave(object sender, EventArgs e)
        {
            if (agencyAddressBox.Text == "")
            {
                agencyAddressBox.Text = "Enter Address";
                agencyAddressBox.ForeColor = Color.Silver;
            }
        }

        private void agencyContactBox_Leave(object sender, EventArgs e)
        {
            if (agencyContactBox.Text == "")
            {
                agencyContactBox.Text = "Enter Contact Number";
                agencyContactBox.ForeColor = Color.Silver;
            }
        }

        private void agencyWebsiteBox_Leave(object sender, EventArgs e)
        {
            if (agencyWebsiteBox.Text == "")
            {
                agencyWebsiteBox.Text = "Enter Website";
                agencyWebsiteBox.ForeColor = Color.Silver;
            }
        }

        private void agencyCodeBox_Leave(object sender, EventArgs e)
        {
            if (agencyCodeBox.Text == "")
            {
                agencyCodeBox.Text = "Enter Agency Code";
                agencyCodeBox.ForeColor = Color.Silver;
            }
        }
        #endregion
        #region Mouse Hover Effect (Next Button in Agency Form) 
        private void NextBtnAgency_MouseEnter(object sender, EventArgs e)
        {
            NextBtnAgency.BackColor = Color.FromArgb(255, 201, 72);
            NextBtnAgency.ForeColor = Color.FromArgb(5, 62, 189);
        }
        private void NextBtnAgency_MouseLeave(object sender, EventArgs e)
        {
            NextBtnAgency.BackColor = Color.FromArgb(5, 62, 189);
            NextBtnAgency.ForeColor = Color.White;
        }


        #endregion
        #region Mouse Hover Effect(Back Button)
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.Image = Properties.Resources.arrow_back_orange50px;
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.Image = Properties.Resources.arrow_back_blue50px;
        }
        #endregion

        private void HideThisContents()
        {
            backBtn.Hide();
            label1.Hide();
            label2.Hide();
            agencyNameBox.Hide();
            agencyAddressBox.Hide();
            agencyContactBox.Hide();
            agencyWebsiteBox.Hide();
            agencyCodeBox.Hide();
            NextBtnAgency.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAgencySignUp.Controls.Add(childForm);
            panelAgencySignUp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HideThisContents();
            openChildForm(new _3LoginForm());
        }
    }
}
