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
    public partial class ProfileEmployer : Form
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

        public ProfileEmployer()
        {
            InitializeComponent();

            initComponents();

            displayProfile();
        }

        private void ProfileEmployer_Load(object sender, EventArgs e)
        {
            displayProfile();
        }

        private void displayProfile()
        {
            if(LoginUserForm.TypeOfDataUser == "Employer")
            {
                try
                {
                    displayProfileEmployer();
                }
                catch (Exception)
                {
                    MessageBox.Show("Profile loading...");
                }
            }
            else
            {
                MessageBox.Show("Profile does not load"); 
            }
        }

        private void displayProfileEmployer()
        {

            Backend_Services.DatabaseConfiguration fetchEmployerData = new Backend_Services.DatabaseConfiguration();

                
                fetchEmployerData.fetchEmployerDataDB(LoginUserForm.FirstNameUser);
                fetchEmployerData.fetchCreateAccountData(LoginUserForm.UserNameUser);

                DataEmployer dataEmployer = Backend_Services.DatabaseConfiguration.GetDataProfileEmployer();
                DataCreateAccount dataCreateAccount = Backend_Services.DatabaseConfiguration.GetDataCreateAccount();

                labelEmployerName.Text = (dataEmployer.EmployerName).ToString();
                labelAddress.Text = (dataEmployer.EmployerAddress).ToString();
                labelPlace.Text = (dataEmployer.EmployerAddress).ToString();
                labelEmail.Text = dataEmployer.EmployerAddress.ToString();
                labelContact.Text = (dataEmployer.EmployerContactNumber).ToString();
                labelEmail.Text = dataCreateAccount.Email.ToString();
           
        }

        private void initComponents()
        {
            editProfileEmployer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, editProfileEmployer.Width, editProfileEmployer.Height, 30, 30));

            tbAboutUs.ReadOnly = true;
            tbLookingFor.ReadOnly = true;
        }
        
        private void editProfileEmployer_Click(object sender, EventArgs e)
        {
            EditProfileEmployer editProfile = new EditProfileEmployer();
            editProfile.ShowDialog();    
        }
        #region Mouse Hover Effects
        private void editProfileEmployer_MouseEnter(object sender, EventArgs e)
        {
            editProfileEmployer.BackColor = Color.FromArgb(255, 201, 72);
            editProfileEmployer.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void editProfileEmployer_MouseLeave(object sender, EventArgs e)
        {
            editProfileEmployer.BackColor = Color.FromArgb(5, 62, 189);
            editProfileEmployer.ForeColor = Color.White;

        }
        #endregion

       
    }
}
