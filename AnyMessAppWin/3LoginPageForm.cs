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
    public partial class _1GetStarted : Form
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

        public _1GetStarted()
        {
            InitializeComponent();

            getStartedBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, getStartedBtn.Width, getStartedBtn.Height, 30, 30));
        }

        private void getStartedBtn_Click(object sender, EventArgs e)
        {

        }

        private void getStartedBtn_MouseEnter(object sender, EventArgs e)
        {
            getStartedBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, getStartedBtn.Width, getStartedBtn.Height, 30, 30));
        }

        private void getStartedBtn_MouseLeave(object sender, EventArgs e)
        {
            getStartedBtn.BackColor = Color.FromArgb(5, 62, 189);
            getStartedBtn.ForeColor = Color.White;
        }
    }
}
