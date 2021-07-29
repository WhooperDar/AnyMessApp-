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

namespace AnyMessAppWin.Dynamic_User_Controls
{
    public partial class AgencyTab : UserControl
    {


        public AgencyTab()
        {
            InitializeComponent();
        }

        private Image imageData;
        private string agencyName;
        private string placeName;

        [Category("Custom Props")]
        public Image ImageData
        {
            get { return imageData; }
            set
            {
                imageData = value;
                pbAgency.Image = value;
            }
        }

        [Category("Custom Props")]
        public string AgencyName
        {
            get { return agencyName; }
            set
            {
                agencyName = value;
                labelAgencyName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string PlaceName
        {
            get { return placeName;  }
            set
            {
                placeName = value;
                labelPlaceAgency.Text = value;
            }
        }

        private void hireMeBtn_MouseEnter(object sender, EventArgs e)
        {
            hireMeBtn.BackColor = Color.FromArgb(255, 201, 72);
            hireMeBtn.ForeColor = Color.FromArgb(5, 62, 189);
            panel1.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void hireMeBtn_MouseLeave(object sender, EventArgs e)
        {
            hireMeBtn.BackColor = Color.FromArgb(5, 62, 189);
            hireMeBtn.ForeColor = Color.FromArgb(239, 239, 239);
            panel1.BackColor = Color.FromArgb(155, 173, 200);
        }

        private void hireMeBtn_Click(object sender, EventArgs e)
        {
            DisplayProfile.AgencyListProfileData agencyProfile = new DisplayProfile.AgencyListProfileData(AgencyName, ImageData);
            agencyProfile.ShowDialog();
        }
    }
}
