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
    public partial class EditProfileEmployer : Form
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

        public EditProfileEmployer()
        {
            InitializeComponent();

            // For Rounded Corners
            browseBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, browseBtn.Width, browseBtn.Height, 30, 30));

            // For Rounded Corners
            RemoveImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, RemoveImage.Width, RemoveImage.Height, 30, 30));

            // For Rounded Corners
            saveBtnAgency.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, saveBtnAgency.Width, saveBtnAgency.Height, 30, 30));

            // For Rounded Corners
            cancelBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 30, 30));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseBtn_MouseEnter(object sender, EventArgs e)
        {
            browseBtn.BackColor = Color.FromArgb(255, 201, 72);
            browseBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void browseBtn_MouseLeave(object sender, EventArgs e)
        {
            browseBtn.BackColor = Color.FromArgb(5, 62, 189);
            browseBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void RemoveImage_MouseEnter(object sender, EventArgs e)
        {
            RemoveImage.BackColor = Color.FromArgb(245, 93, 72);
            RemoveImage.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void RemoveImage_MouseLeave(object sender, EventArgs e)
        {
            RemoveImage.BackColor = Color.FromArgb(239, 239, 239);
            RemoveImage.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void saveBtnAgency_MouseEnter(object sender, EventArgs e)
        {
            saveBtnAgency.BackColor = Color.FromArgb(255, 201, 72);
            saveBtnAgency.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void saveBtnAgency_MouseLeave(object sender, EventArgs e)
        {
            saveBtnAgency.BackColor = Color.FromArgb(5, 62, 189);
            saveBtnAgency.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void cancelBtn_MouseEnter(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.FromArgb(245, 93, 72);
            cancelBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.FromArgb(239, 239, 239);
            cancelBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void RemoveImage_Click(object sender, EventArgs e)
        {
            pbImageBoxEmployer.Image = null;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Title = "Select Image";
            imageDialog.Filter = "Image Files(*.jpg) | *.jpg | Image Files(*.png) | *.png"; 

            if(imageDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(imageDialog.FileName);
                pbImageBoxEmployer.Image = img.GetThumbnailImage(243, 173, null, new IntPtr());
            }
        }

        private void saveBtnAgency_Click(object sender, EventArgs e)
        {
            if (CheckStateTextBox())
            {

            }
            else
            {
                WarningForms.PleaseFillUpForm warningSign = new WarningForms.PleaseFillUpForm();
                warningSign.ShowDialog();
            }
        }

        private bool CheckStateTextBox()
        {
            return (tbAboutMe.Text == null || tbAddress.Text == null || tbEmail.Text == null);
        }
    }
}
