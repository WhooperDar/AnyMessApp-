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
    public partial class ProfileAgencyChildForm : Form
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

        public ProfileAgencyChildForm()
        {
            InitializeComponent();
            initTextComponents();

            displayProfile();

            UpdateDataProfile();

            detailsPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, detailsPanel.Width,
            detailsPanel.Height, 30, 30));

            panelLook.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelLook.Width,
            panelLook.Height, 30, 30));

            panelWebsite.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelWebsite.Width,
            panelWebsite.Height, 30, 30));
        }

        private void ProfileAgencyChildForm_Load(object sender, EventArgs e)
        {
            displayProfile();
            UpdateDataProfile();
        }

        private void UpdateDataProfile()
        {
            try
            {
                Backend_Services.DatabaseConfiguration agencyDB = new Backend_Services.DatabaseConfiguration();
                agencyDB?.RetrieveAgencyEditData(LoginUserForm.FirstNameUser);

                var dataAgencyProfile = agencyDB?.getEditDataAgency();

                labelAddress.Text = dataAgencyProfile.AddressData;
                labelAddressName.Text = dataAgencyProfile.AddressData;
                labelContact.Text = dataAgencyProfile.AgencyContact;
                labelWebsite.Text = dataAgencyProfile.WebsiteData;
                tbLooking.Text = dataAgencyProfile.AgencyLookingFor;
                tbAboutUs.Text = dataAgencyProfile.AboutUs;

                pbAgency.Image = Backend_Services.ImageProcessor.StringToBitmap(dataAgencyProfile.ImageAgencyData);
            }
            catch(Exception) { MessageBox.Show("Profile loading..."); }

            
        }

        #region DisplayProfileAgencies
        private void displayProfile()
        {
            if (LoginUserForm.TypeOfDataUser == "Agency")
            {
                try
                {
                    displayProfileAgency();
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Profile cannot load");
            }
        }

        // Agency Profile Display 


        private void displayProfileAgency()
        {
            Backend_Services.DatabaseConfiguration fetchData = new Backend_Services.DatabaseConfiguration();
            fetchData?.fetchAgencyDataDB(LoginUserForm.FirstNameUser);
            fetchData?.fetchCreateAccountData(LoginUserForm.UserNameUser);

            DataCreateAccount dataCreateAccount = Backend_Services.DatabaseConfiguration.GetDataCreateAccount();
            Data dataAgency = Backend_Services.DatabaseConfiguration.GetDataProfileAgency();


            labelAgencyName.Text = (dataAgency.AgencyName).ToString();
            labelAddressName.Text = (dataAgency.AgencyAddress).ToString();
            labelContact.Text = (dataAgency.AgencyContactNumber).ToString();
            labelAddress.Text = (dataAgency.AgencyAddress).ToString();
            labelWebsite.Text = (dataAgency.AgencyWebsite).ToString();
            labelEmail.Text = (dataCreateAccount.Email).ToString();
        }
        #endregion

        #region Utility Functions

        private void initTextComponents()
        {
            // For Rounded Corners
            editProfileAgency.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, editProfileAgency.Width, editProfileAgency.Height, 30, 30));

            tbAboutUs.ReadOnly = true;
            tbLooking.ReadOnly = true;
        }
        #endregion

        #region Mouse Hover Effects
        private void editProfileAgency_MouseEnter(object sender, EventArgs e)
        {
            editProfileAgency.BackColor = Color.FromArgb(255, 201, 72);
            editProfileAgency.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void editProfileAgency_MouseLeave(object sender, EventArgs e)
        {
            editProfileAgency.BackColor = Color.FromArgb(5, 62, 189);
            editProfileAgency.ForeColor = Color.White;
        }

        private void editProfileAgency_Click(object sender, EventArgs e)
        {
            EditProfileAgency editProfile = new EditProfileAgency();
            editProfile.ShowDialog();
        }
        #endregion

      
    }
}
