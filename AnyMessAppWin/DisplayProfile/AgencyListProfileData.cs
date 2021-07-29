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

namespace AnyMessAppWin.DisplayProfile
{
    public partial class AgencyListProfileData : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        // For Rounded Radius Panels
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
        public AgencyListProfileData(string AgencyName, Image image)
        {
            InitializeComponent();

            panelPersonal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPersonal.Width,
            panelPersonal.Height, 30, 30));

            panelAboutMe.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAboutMe.Width,
            panelAboutMe.Height, 30, 30));

            panelContact.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContact.Width,
            panelContact.Height, 30, 30));

            displayUpdateLabelText(AgencyName, image);
        }

        // Set Labels 
        private async void displayUpdateLabelText(string AgencyName, Image image)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                Dynamic_User_Controls.AgencyTab agencyProfile = new Dynamic_User_Controls.AgencyTab();

                FirebaseResponse response = await client.GetTaskAsync("Agency Information/" + AgencyName);
                Data resultAgency = response.ResultAs<Data>();

                labelAgencyName.Text = resultAgency.AgencyName;
                labelAboutAgency.Text = "";
                labelAgencyCode.Text = resultAgency.AgencyCode;
                labelAddress.Text = resultAgency.AgencyAddress;
                labelWebsite.Text = resultAgency.AgencyWebsite;
                labelContact.Text = resultAgency.AgencyContactNumber;

                pbAgencyProfile.Image = image;
                pbAgencyProfile.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {
                MessageBox.Show("Error internet connection");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
