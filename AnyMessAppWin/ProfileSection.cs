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
    public partial class ProfileSection : Form
    {
        public ProfileSection()
        {
            InitializeComponent();

        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            panelProfileParent.Controls.Add(childForm);
            panelProfileParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ProfileSection_Load(object sender, EventArgs e)
        {
            openChildForm(new ProfileEmployer()); 
        }
    }
}
