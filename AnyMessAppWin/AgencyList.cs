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
    public partial class AgencyList : Form
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

        
        public AgencyList()
        {
            InitializeComponent();

            // For Rounded Corners
            MarketAgencyBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, MarketAgencyBtn.Width, MarketAgencyBtn.Height, 30, 30));

            displayBtnOnly();
        }

        private void displayBtnOnly()
        {
            if(LoginUserForm.TypeOfDataUser == "Agency")
            {
                MarketAgencyBtn.Show();
            }
            else
            {
                MarketAgencyBtn.Hide();
            }
        }
        private void agencyListExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarketAgencyBtn_Click(object sender, EventArgs e)
        {
            MarketServices.MarketAgency marketagency = new MarketServices.MarketAgency();
            marketagency.ShowDialog();
        }
    }
}
