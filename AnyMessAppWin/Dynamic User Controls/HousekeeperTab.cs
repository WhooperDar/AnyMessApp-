using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin.Dynamic_User_Controls
{
    public partial class HousekeeperTab : UserControl
    {
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
                pbHousekeeping.Image = value;
            }
        }
        [Category("Custom Props")]
        public string HkName
        {
            get { return agencyName; }
            set
            {
                agencyName = value;
                labelHkName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Category
        {
            get { return placeName; }
            set
            {
                placeName = value;
                labelSkill.Text = value;
            }
        }
        public HousekeeperTab()
        {
            InitializeComponent();
        }
    }
}
