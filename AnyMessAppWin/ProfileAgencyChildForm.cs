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
    public partial class ProfileAgencyChildForm : Form
    {
        public ProfileAgencyChildForm()
        {
            InitializeComponent();
            initTextComponents(); 
        }

        private void initTextComponents()
        {
            textBoxAboutUs.Enabled = true;
            textBoxAboutUs.ReadOnly = true;
        }

        private void editProfileAgency_MouseEnter(object sender, EventArgs e)
        {
            editProfileAgency.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void editProfileAgency_MouseLeave(object sender, EventArgs e)
        {
            editProfileAgency.ForeColor = Color.Gray;
        }

        private void editProfileAgency_Click(object sender, EventArgs e)
        {
            EditProfileAgency editProfile = new EditProfileAgency();
            editProfile.ShowDialog();
        }
    }
}
