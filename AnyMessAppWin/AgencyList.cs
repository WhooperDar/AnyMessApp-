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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace AnyMessAppWin
{
    public partial class AgencyList : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

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
            if (LoginUserForm.TypeOfDataUser == "Agency")
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

        
        private async void DynamicControls()
        {
            client = new FireSharp.FirebaseClient(config);

            DataTable dataTableAgency = new DataTable();

            FirebaseResponse responseIdAgencyData = await client.GetTaskAsync("1AgencyList/activeNodes/");
            ActiveList_Counter.AgencyListCounter resultIdData = responseIdAgencyData.ResultAs<ActiveList_Counter.AgencyListCounter>();


            int cnt = Convert.ToInt32(resultIdData.count);

            // Table Columns
            dataTableAgency.Columns.Add("agencyID");
            dataTableAgency.Columns.Add("agencyName");
            dataTableAgency.Columns.Add("agencyPlace");
            dataTableAgency.Columns.Add("imageString");


            int i = 0;
            while (true)
            {

                if (i == cnt)
                {
                    break;
                }

                i++;
                
                try
                {
                    FirebaseResponse responseDataAgency2 = await client.GetTaskAsync("3AgencyListData/" + i);
                    DataModels.AgencyListData dataResultAgency = responseDataAgency2.ResultAs<DataModels.AgencyListData>();

                    DataRow row = dataTableAgency.NewRow();

                    row["agencyID"] = dataResultAgency.AgencyID;
                    row["agencyName"] = dataResultAgency.AgencyName;
                    row["agencyPlace"] = dataResultAgency.AgencyAddress;
                    row["imageString"] = dataResultAgency.ImageData;

                    dataTableAgency.Rows.Add(row);
                }
                catch (Exception) { }
            }


            this.flowLayoutPanel1.Controls.Clear();

            DataTable dataTableCopy = dataTableAgency;

            if (dataTableCopy != null)
            {

                if (dataTableCopy.Rows.Count > 0)
                {
                    Dynamic_User_Controls.AgencyTab[] listviewAgency = new Dynamic_User_Controls.AgencyTab[dataTableCopy.Rows.Count];

                    for (int j = 0; j < 1; j++)
                    {
                        foreach (DataRow row in dataTableCopy.Rows)
                        {
                            listviewAgency[j] = new Dynamic_User_Controls.AgencyTab();

                            listviewAgency[j].AgencyName = row["agencyName"].ToString();
                            listviewAgency[j].PlaceName = row["agencyPlace"].ToString();
                            Bitmap imageData = Backend_Services.ImageProcessor.StringToBitmap((string)row["imageString"]);

                            listviewAgency[j].ImageData = imageData;

                            this.flowLayoutPanel1.Controls.Add(listviewAgency[j]);
                        }
                    }
                }
            }
        }

        private void AgencyList_Load(object sender, EventArgs e)
        {
            DynamicControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DynamicControls();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(Dynamic_User_Controls.AgencyTab))
                {
                    Dynamic_User_Controls.AgencyTab agencyProfileData = (Dynamic_User_Controls.AgencyTab)c;
                    if (!agencyProfileData.AgencyName.ToLower().Contains(searchBoxAgency.Text.ToLower()))
                    {

                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
        }

        private void seachBoxAgency_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(Dynamic_User_Controls.AgencyTab))
                {
                    Dynamic_User_Controls.AgencyTab agencyProfileData = (Dynamic_User_Controls.AgencyTab)c;
                    if (!agencyProfileData.AgencyName.ToLower().Contains(searchBoxAgency.Text.ToLower()))
                    {

                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
        }
    }
}
