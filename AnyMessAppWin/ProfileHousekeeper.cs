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
    public partial class ProfileHousekeeper : Form
    {
        public ProfileHousekeeper()
        {
            InitializeComponent();

            initComponents();
        }

        private void initComponents()
        {
            textBoxAddress.ReadOnly = true;
            txtBoxOtherSkills.ReadOnly = true;
            textBoxAboutMe.ReadOnly = true;
        }

        private void editProfileHk_Click(object sender, EventArgs e)
        {
            EdiProfileHousekeeper editProfile = new EdiProfileHousekeeper();
            editProfile.ShowDialog();
        }
    }
}
