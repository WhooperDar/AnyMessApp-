using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class HomeTabPanel : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        // For Rounded Corner Buttons
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

        // Front End

        #region Form 
        public HomeTabPanel()
        {
            InitializeComponent();

            hiSaying();

            DynamicControlsHk();

            DynamicControlsAgency();
        }

        #endregion

        private void hiSaying()
        {
            labelSaying.Text = $"Hi {LoginUserForm.FirstNameUser},"; 
        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DynamicControlsHk()
        {

            DataTable dataTable = new DataTable();

            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse responseIdHkData = await client.GetTaskAsync("2HousekeepingList/activeNodes/");
            ActiveList_Counter.HousekeepingListCounter resultIdData = responseIdHkData.ResultAs<ActiveList_Counter.HousekeepingListCounter>();


            int cnt = Convert.ToInt32(resultIdData.count);

            // Table Columns

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("category");
            dataTable.Columns.Add("imageString");


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
                    FirebaseResponse responseDataHk2 = await client.GetTaskAsync("3HousekeepingListData/" + i);
                    DataModels.HousekeepingListData dataResultHk = responseDataHk2.ResultAs<DataModels.HousekeepingListData>();

                    DataRow row = dataTable.NewRow();

                    row["id"] = dataResultHk.HousekeeperID;
                    row["name"] = dataResultHk.HousekeeperName;
                    row["category"] = dataResultHk.Category;
                    row["imageString"] = dataResultHk.ImageData;

                    dataTable.Rows.Add(row);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }


            flowLayoutPanel1.Controls.Clear();

            DataTable dt = new DataTable();

            dt = dataTable;

            if (dt != null)
            {

                if (dt.Rows.Count > 0)
                {
                    Dynamic_User_Controls.HousekeeperTab[] listview = new Dynamic_User_Controls.HousekeeperTab[dt.Rows.Count];

                    for (int j = 0; j < 1; j++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listview[j] = new Dynamic_User_Controls.HousekeeperTab();

                            listview[j].HkName = row["name"].ToString();
                            listview[j].Category = row["category"].ToString();
                            Bitmap imageData = Backend_Services.ImageProcessor.StringToBitmap((string)row["imageString"]);

                            listview[j].ImageData = imageData;

                            flowLayoutPanel1.Controls.Add(listview[j]);
                        }
                    }
                }
            }
        }

        private async void DynamicControlsAgency()
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


            this.flowLayoutPanel2.Controls.Clear();

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

                            this.flowLayoutPanel2.Controls.Add(listviewAgency[j]);
                        }
                    }
                }
            }
        }

        private void refreshBtnHk_Click(object sender, EventArgs e)
        {
            DynamicControlsHk();
        }

        private void refreshBtnAgency_Click(object sender, EventArgs e)
        {
            DynamicControlsAgency();
        }
    }
}
