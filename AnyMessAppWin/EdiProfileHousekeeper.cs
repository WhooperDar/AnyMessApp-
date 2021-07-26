using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin
{
    public partial class EdiProfileHousekeeper : Form
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

        public EdiProfileHousekeeper()
        {
            InitializeComponent();

            // For Rounded Corners
            browseBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, browseBtn.Width, browseBtn.Height, 30, 30));

            // For Rounded Corners
            RemoveImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, RemoveImage.Width, RemoveImage.Height, 30, 30));

            // For Rounded Corners
            saveBtnHousekeeper.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, saveBtnHousekeeper.Width, saveBtnHousekeeper.Height, 30, 30));

            // For Rounded Corners
            cancelBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 30, 30));

        }
        #region Mouse Hover Effect 
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
            saveBtnHousekeeper.BackColor = Color.FromArgb(255, 201, 72);
            saveBtnHousekeeper.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void saveBtnAgency_MouseLeave(object sender, EventArgs e)
        {
            saveBtnHousekeeper.BackColor = Color.FromArgb(5, 62, 189);
            saveBtnHousekeeper.ForeColor = Color.FromArgb(239, 239, 239);
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
        #endregion


        // Browse Image

        public static string ImageFileName { get; set; }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageFileDialog = new OpenFileDialog();
            imageFileDialog.Title = "Select Image";
            imageFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png;"; // img filters

            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 243, 173

                Image img = new Bitmap(imageFileDialog.FileName);
                pbProfileHk.Image = img.GetThumbnailImage(243, 173, null, new IntPtr());
            }
        }

        private void RemoveImage_Click(object sender, EventArgs e)
        {
            pbProfileHk.Image = null;
            
        }

        public static bool SaveHkBtnClicked { get; set; }
        private void saveBtnHousekeeper_Click(object sender, EventArgs e)
        {
            if (CheckStateTextBox())
            {
                if(pbProfileHk.Image != null)
                {
                    string stringImg = BitmapToString(pbProfileHk.Image);

                    Backend_Services.DatabaseConfiguration saveEditData = new Backend_Services.DatabaseConfiguration();

                    saveEditData.SaveEditProfileHousekeeper(LoginUserForm.FirstNameUser, 
                                                            tbRate.Text,
                                                            stringImg, 
                                                            tbAboutMe.Text,
                                                            tbAddress.Text, 
                                                            tbContactNumber.Text,
                                                            tbEmail.Text,
                                                            tbOtherSkills.Text);

                    MessageBox.Show("Data has been saved!");
                    ReturnToOldState();

                    SaveHkBtnClicked = true;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Please Insert Image!");
                }
                    
            } 
            else
            {
                WarningForms.PleaseFillUpForm warningSign = new WarningForms.PleaseFillUpForm();
                warningSign.ShowDialog();
            }
        }

        // Utility Functions 
        private string BitmapToString(Image img)
        {
            MemoryStream memorystream = new MemoryStream();

            img.Save(memorystream, ImageFormat.Jpeg);

            byte[] byteImg = memorystream.GetBuffer();

            string stringImg = Convert.ToBase64String(byteImg);

            return stringImg;
        }
        private void ReturnToOldState()
        {
            if (!string.IsNullOrEmpty(tbAboutMe.Text) && !string.IsNullOrEmpty(tbAddress.Text) && !string.IsNullOrEmpty(tbContactNumber.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbRate.Text) && !string.IsNullOrEmpty(tbOtherSkills.Text)) 
            {
                tbAboutMe.Text = "";
                tbAddress.Text = "";
                tbContactNumber.Text = "";
                tbEmail.Text = "";
                tbRate.Text = "";
                tbOtherSkills.Text = "";

                pbProfileHk.Image = null;
            }
        }
        private bool CheckStateTextBox()
        {
            return (tbAboutMe.Text != "" && tbAddress.Text != "" && tbContactNumber.Text != "" && tbEmail.Text != ""
               && tbRate.Text != "");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
