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
    public partial class ProfileHousekeeper : Form
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

        public ProfileHousekeeper()
        {
            InitializeComponent();

            initComponents();

            displayProfile();

            UpdateProfile();
        }

        private void UpdateProfile()
        {
            try
            {
                Backend_Services.DatabaseConfiguration dataEditHk = new Backend_Services.DatabaseConfiguration();
                dataEditHk?.RetrieveHousekeeperEditData(LoginUserForm.FirstNameUser);

                DataModels.EditProfileHkModel resultHkEditData = dataEditHk?.getEditDataHk();

                labelAddress.Text = resultHkEditData.AddressHk;
                labelContact.Text = resultHkEditData.ContactNumberHk;
                labelEmail.Text = resultHkEditData.EmailHk;
                labelHkPlace.Text = resultHkEditData.AddressHk;
                labelSkill.Text = resultHkEditData.OtherSkills;
                tbAboutMe.Text = resultHkEditData.AboutMeHk;
                tbOtherSkill.Text = resultHkEditData.OtherSkills;
                labelRate.Text = $"{resultHkEditData.RateHk}/hr"; 

                pbHk.Image = Backend_Services.ImageProcessor.StringToBitmap(resultHkEditData.ImageHkData);
            }
            catch (Exception)
            {
                MessageBox.Show("Profile is loading...");
            }

        }
        private void ProfileHousekeeper_Load(object sender, EventArgs e)
        {
            displayProfile();
            UpdateProfile();
        }
        private void displayProfile()
        {
            if(LoginUserForm.TypeOfDataUser == "Housekeeping")
            {
                try
                {
                    displayProfileHousekeeping();
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Profile does not found"); 
            }
        }

        private void displayProfileHousekeeping()
        {
            
                Backend_Services.DatabaseConfiguration fetchDataHk = new Backend_Services.DatabaseConfiguration();

                fetchDataHk?.fetchHousekeepingAccount(LoginUserForm.FirstNameUser);
                fetchDataHk?.fetchCreateAccountData(LoginUserForm.UserNameUser);

                DataCreateAccount dataCreateAccout = Backend_Services.DatabaseConfiguration.GetDataCreateAccount();
                DataHousekeeper dataHk = Backend_Services.DatabaseConfiguration.GetDataProfileHk();

                labelHkName.Text = dataHk.HousekeeperName;
                labelHkPlace.Text = dataHk.HousekeeperAddress;
                labelSkill.Text = dataHk.HousekeeperSkill;
                labelContact.Text = dataHk.HousekeeperContact;
                labelEmail.Text = dataCreateAccout.Email;
                labelAddress.Text = dataHk.HousekeeperAddress;
           
        }
        private void initComponents()
        {
            // For Rounded Corners
            editProfileHk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, editProfileHk.Width, editProfileHk.Height, 30, 30));

            tbOtherSkill.ReadOnly = true;
            tbAboutMe.ReadOnly = true;
        }
        

        #region Mouse Hover Effects
        private void editProfileHk_Click_1(object sender, EventArgs e)
        {
            EdiProfileHousekeeper editProfile = new EdiProfileHousekeeper();
            editProfile.ShowDialog();
        }

        private void editProfileHk_MouseEnter(object sender, EventArgs e)
        {
            editProfileHk.BackColor = Color.FromArgb(255, 201, 72);
            editProfileHk.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void editProfileHk_MouseLeave(object sender, EventArgs e)
        {
            editProfileHk.BackColor = Color.FromArgb(5, 62, 189);
            editProfileHk.ForeColor = Color.White;
        }
        #endregion
    }
}
