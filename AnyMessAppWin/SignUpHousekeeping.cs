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
    public partial class SignUpHousekeeping : Form
    {
         // For Corner Radius
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

        public SignUpHousekeeping()
        {
            InitializeComponent();

            // For Rounded Corners
            NextBtnHousekeeping.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NextBtnHousekeeping.Width, NextBtnHousekeeping.Height, 30, 30));
        }

        private void hkFirstNameBox_Enter(object sender, EventArgs e)
        {
            if (hkFirstNameBox.Text == "Enter First Name")
            {
                hkFirstNameBox.Text = "";
                hkFirstNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }    
        }

        private void hkMiddleNameBox_Enter(object sender, EventArgs e)
        {
            if (hkMiddleNameBox.Text == "Enter Middle Name")
            {
                hkMiddleNameBox.Text = "";
                hkMiddleNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void hkLastNameBox_Enter(object sender, EventArgs e)
        {
            if (hkLastNameBox.Text == "Enter Last Name")
            {
                hkLastNameBox.Text = "";
                hkLastNameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void hkAgeBox_Enter(object sender, EventArgs e)
        {
            
            if (hkAgeBox.Text == "Enter Age")
            {
                hkAgeBox.Text = "";
                hkAgeBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void hkSexBox_Enter(object sender, EventArgs e)
        {
            if (hkSexBox.Text == "Enter Sex")
            {
                hkSexBox.Text = "";
                hkSexBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }
        private void hkContactBox_Enter(object sender, EventArgs e)
        {
            if (hkContactBox.Text == "Enter Contact")
            {
                hkContactBox.Text = "";
                hkContactBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void hkAddressBox_Enter(object sender, EventArgs e)
        {
            if (hkAddressBox.Text == "Enter Address")
            {
                hkAddressBox.Text = "";
                hkAddressBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void hkSkillBox_Enter(object sender, EventArgs e)
        {
            if (hkSkillBox.Text == "Enter Skill")
            {
                hkSkillBox.Text = "";
                hkSkillBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        
        // Firebase Configuration
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // link to DB
        };

        IFirebaseClient clientHk;
        // Click Event

        private async void NextBtnHk_Click(object sender, EventArgs e)
        {
           

            clientHk = new FireSharp.FirebaseClient(config);

            var dataHousekeeper = new DataHousekeeper
            {
                HousekeeperName = hkFirstNameBox.Text,
                HouserkeeperMiddleName = hkMiddleNameBox.Text,
                HousekeeperLastName = hkLastNameBox.Text,
                HousekeeperAge = hkAgeBox.Text,
                HousekeeperSex = hkSexBox.Text,
                HousekeeperContact = hkContactBox.Text,
                HousekeeperAddress = hkAddressBox.Text,
                HousekeeperSkill = hkSkillBox.Text
            };

            SetResponse responseHk = await clientHk.SetTaskAsync("Housekeeper Information/" + hkFirstNameBox.Text, dataHousekeeper);

            DataHousekeeper resultHk = responseHk.ResultAs<DataHousekeeper>();
            MessageBox.Show(resultHk.HousekeeperName + " added to firebase");

            hkFieldToOldState();

            CreateAccount createAccountHk = new CreateAccount();
            createAccountHk.ShowDialog();

            this.Close(); // Closing From
        }

        // Reset Text
        private void hkFieldToOldState()
        {   // Text Changed
            hkFirstNameBox.Text = "Enter First Name";
            hkMiddleNameBox.Text = "Enter Middle Name";
            hkLastNameBox.Text = "Enter Last Name";
            hkAgeBox.Text = "Enter Age";
            hkSexBox.Text = "Enter Sex";
            hkContactBox.Text = "Enter Contact Number";
            hkAddressBox.Text = "Enter Address";
            hkSkillBox.Text = "Enter Skill";

            // Color Changed
            hkFirstNameBox.ForeColor = Color.Silver;
            hkMiddleNameBox.ForeColor = Color.Silver;
            hkLastNameBox.ForeColor = Color.Silver;
            hkAgeBox.ForeColor = Color.Silver;
            hkSexBox.ForeColor = Color.Silver;
            hkContactBox.ForeColor = Color.Silver;
            hkAddressBox.ForeColor = Color.Silver;
            hkSkillBox.ForeColor = Color.Silver;
        }


        // Leave Events 
        private void hkFirstNameBox_Leave(object sender, EventArgs e)
        {
            if (hkFirstNameBox.Text == "")
            {
                hkFirstNameBox.Text = "Enter First Name";
                hkFirstNameBox.ForeColor = Color.Silver; 
            }
        }

        private void hkMiddleNameBox_Leave(object sender, EventArgs e)
        {
            if(hkMiddleNameBox.Text == "")
            {
                hkMiddleNameBox.Text = "Enter Middle Name";
                hkMiddleNameBox.ForeColor = Color.Silver;
            }
        }

        private void hkLastNameBox_Leave(object sender, EventArgs e)
        {
            if (hkLastNameBox.Text == "")
            {
                hkLastNameBox.Text = "Enter Last Name";
                hkLastNameBox.ForeColor = Color.Silver;
            }
        }

        private void hkAgeBox_Leave(object sender, EventArgs e)
        {
            if (hkAgeBox.Text == "")
            {
                hkAgeBox.Text = "Enter Age";
                hkAgeBox.ForeColor = Color.Silver;
            }
        }

        private void hkSexBox_Leave(object sender, EventArgs e)
        {
            if (hkSexBox.Text == "")
            {
                hkSexBox.Text = "Enter Sex";
                hkSexBox.ForeColor = Color.Silver;
            }
        }

        private void hkContactBox_Leave(object sender, EventArgs e)
        {
            if (hkContactBox.Text == "")
            {
                hkContactBox.Text = "Enter Contact Number";
                hkContactBox.ForeColor = Color.Silver;
            }
        }

        private void hkAddressBox_Leave(object sender, EventArgs e)
        {
            if (hkAddressBox.Text == "")
            {
                hkAddressBox.Text = "Enter Address";
                hkAddressBox.ForeColor = Color.Silver;
            }
        }

        private void hkSkillBox_Leave(object sender, EventArgs e)
        {
            if (hkSkillBox.Text == "")
            {
                hkSkillBox.Text = "Enter Skill";
                hkSkillBox.ForeColor = Color.Silver;
            }
        }

        private void SignUpHousekeeping_Load(object sender, EventArgs e)
        {
        }

        private void NextBtnHousekeeping_MouseEnter(object sender, EventArgs e)
        {
            NextBtnHousekeeping.BackColor = Color.FromArgb(255, 201, 72);
            NextBtnHousekeeping.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void NextBtnHousekeeping_MouseLeave(object sender, EventArgs e)
        {
            NextBtnHousekeeping.BackColor = Color.FromArgb(5, 62, 189);
            NextBtnHousekeeping.ForeColor = Color.White;
        }
    }
}
