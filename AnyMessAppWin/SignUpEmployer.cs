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
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;


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

        public static bool EmployerClicked { get; set; } 
        private async void NextBtnEmployer_Click(object sender, EventArgs e)
        {
            EmployerClicked = true; 

            if(employerAddressBox.Text != "Enter Address" && employerContactBox.Text != "Enter Contact Number" && employerFirstNameBox.Text != "Enter First Name" && employerMiddleNameBox.Text != "Enter Middle Name" && employerLastNameBox.Text != "Enter Last Name" && employerSexBox.Text != "Enter Sex" && employerAgeBox.Text != "Enter Age")
            {   
                try
                {
                    FirebaseResponse response = await client.GetTaskAsync("Employer Information/" + employerFirstNameBox.Text);
                    var result = response.ResultAs<DataEmployer>();

                    if(employerFirstNameBox.Text != result.EmployerName)
                    {
                        Backend_Services.DatabaseConfiguration databaseObj = new Backend_Services.DatabaseConfiguration();

                        databaseObj.SavaDataEmployer(employerFirstNameBox.Text, employerMiddleNameBox.Text, employerLastNameBox.Text, employerAddressBox.Text, employerContactBox.Text, employerAgeBox.Text, employerSexBox.Text);

                        returnToOldStateEmp();

                        HideThisContents();
                        openChildForm(new CreateAccount());
                    }
                    else
                    {
                        MessageBox.Show($"{employerFirstNameBox.Text} is already existed");
                        returnToOldStateEmp();
                    }
                    
                }
                catch (Exception)
                {
                    Backend_Services.DatabaseConfiguration databaseObj = new Backend_Services.DatabaseConfiguration();

                    databaseObj.SavaDataEmployer(employerFirstNameBox.Text, employerMiddleNameBox.Text, employerLastNameBox.Text, employerAddressBox.Text, employerContactBox.Text, employerAgeBox.Text, employerSexBox.Text);

                    returnToOldStateEmp();

                    HideThisContents();
                    openChildForm(new CreateAccount());
                }         
            }
            else
            {
                MessageBox.Show("Please fill up this form!");
            }
            
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

        #region Mouse Hover Effects(Back Button) 
        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.Image = Properties.Resources.arrow_back_orange50px;
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.Image = Properties.Resources.arrow_back_blue50px;
        }
        #endregion 

        #region Utility Functions(OpenChild and Hide Components)
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEmployerParent.Controls.Add(childForm);
            panelEmployerParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HideThisContents()
        {
            backBtn.Hide();
            label1.Hide();
            label2.Hide();
            employerFirstNameBox.Hide();
            employerMiddleNameBox.Hide();
            employerLastNameBox.Hide();
            employerSexBox.Hide();
            employerAgeBox.Hide();
            employerAddressBox.Hide();
            employerContactBox.Hide();
            NextBtnEmployer.Hide();
        }
        #endregion

        private void backBtn_Click(object sender, EventArgs e)
        {
            HideThisContents();
            openChildForm(new _3LoginForm()); 
        }
    }
}
