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

        public AgencyTab()
        {
            InitializeComponent();

            // For Rounded Corners
            hireMeBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hireMeBtn.Width, hireMeBtn.Height, 30, 30));
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
    }
}
