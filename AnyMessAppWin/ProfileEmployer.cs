using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin
{
    public partial class ProfileEmployer : Form
    {
        public ProfileEmployer()
        {
            InitializeComponent();

            initComponents();
        }

        private void initComponents()
        {
            textBoxAboutUs.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            textBoxEmail.ReadOnly = true; 
        }

        private void editProfileAgency_Click(object sender, EventArgs e)
        {
            EditProfileEmployer editProfile = new EditProfileEmployer();
            editProfile.ShowDialog();
        }
    }
}
