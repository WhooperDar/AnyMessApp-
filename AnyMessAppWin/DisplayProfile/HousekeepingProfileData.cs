using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin.DisplayProfile
{
    public partial class HousekeepingProfileData : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        public HousekeepingProfileData(string HkName, Image image)
        {
            InitializeComponent();
            displayUpdatedProfile(HkName, image);
        }

        private async void displayUpdatedProfile(string HkName, Image image)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

                FirebaseResponse response = await client.GetTaskAsync("Housekeeper Information/" + HkName);
                DataHousekeeper resultHk = response.ResultAs<DataHousekeeper>();

                labelHkName.Text = $"{resultHk.HousekeeperName} {resultHk.HouserkeeperMiddleName} {resultHk.HousekeeperLastName}";
                labelSkill.Text = resultHk.HousekeeperSkill;
                labelHkSex.Text = resultHk.HousekeeperSex;
                labelHkContact.Text = resultHk.HousekeeperContact;
                labelHkAddress.Text = resultHk.HousekeeperAddress;

                pbHkProfile.Image = image;
                pbHkProfile.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Internet Connection");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
