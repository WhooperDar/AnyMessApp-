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

        private void hireMeBtnHk_MouseEnter(object sender, EventArgs e)
        {
            hireMeBtnHk.BackColor = Color.FromArgb(255, 201, 72);
            hireMeBtnHk.ForeColor = Color.FromArgb(5, 62, 189);
            panel1.BackColor = Color.FromArgb(255, 201, 72);
        }

        private void hireMeBtnHk_MouseLeave(object sender, EventArgs e)
        {
            hireMeBtnHk.BackColor = Color.FromArgb(5, 62, 189);
            hireMeBtnHk.ForeColor = Color.FromArgb(239, 239, 239);
            panel1.BackColor = Color.FromArgb(155, 173, 200);
        }
    }
}
