using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin.MarketServices
{
    public partial class MarketHousekeeper : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        public MarketHousekeeper()
        {
            InitializeComponent();

            loadTextData();
        }

        private void MarketHousekeeper_Load(object sender, EventArgs e)
        {
            loadTextData();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fetch Agency Data to Get name and place
        static Backend_Services.DatabaseConfiguration hkData = new Backend_Services.DatabaseConfiguration();
        private async void loadTextData()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                FirebaseResponse response = await client.GetTaskAsync("Housekeeper Information/" + LoginUserForm.FirstNameUser);

                var dataResult = response.ResultAs<DataHousekeeper>();

                response = await client.GetTaskAsync("Edit Profile Housekeeper/" + LoginUserForm.FirstNameUser);

                var resultImage = response.ResultAs<DataModels.EditProfileHkModel>();
                // Prepare data to send

                Bitmap img = Backend_Services.ImageProcessor.StringToBitmap(resultImage.ImageHkData); 

                labelHkName.Text = dataResult.HousekeeperName;
                labelSkill.Text = dataResult.HousekeeperSkill;
                pbHkService.Image = img;
            }
            catch (Exception) { MessageBox.Show("Request Processing...."); }
        }

        private void postNowBtn_Click(object sender, EventArgs e)
        {
            if(pbHkService.Image != null)
            {
                if(labelHkName.Text != "" && labelSkill.Text != "")
                {
                    try
                    {
                        string stringImage = BitmapToString(pbHkService.Image);

                        hkData.UpdateHousekeepingList(stringImage, labelHkName.Text, labelSkill.Text);

                        MessageBox.Show("Your profile is now in housekeeping list");

                        this.Close();
                    }
                    catch (Exception) {   }
                }
                else
                {
                    MessageBox.Show("Please complete the form!");
                }
                
            }
            else
            {
                MessageBox.Show("Please Insert Image");
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imageFileDialog = new OpenFileDialog();
                imageFileDialog.Title = "Select Image";
                imageFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png;"; // img filters

                if(imageFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(imageFileDialog.FileName);
                    pbHkService.Image = img.GetThumbnailImage(224, 172, null, new IntPtr()); //224, 172
                }
            }
            catch (Exception) { }
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            pbHkService.Image = null;
        }
    }
}
