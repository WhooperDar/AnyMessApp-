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
    public partial class HousekeepingListForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VV2PEctRnqHQ1KVcDEBlprQiD4wzSS4wYUG4FUY2", // Secret Key  
            BasePath = "https://anymesswin-app-default-rtdb.asia-southeast1.firebasedatabase.app/" // Basekey 
        };

        IFirebaseClient client;

        DataTable dataTable = new DataTable();

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
        private void HousekeepingListForm_Load(object sender, EventArgs e)
        {

            DynamicControls();
        }

        public HousekeepingListForm()
        {
            InitializeComponent();

            displayIfHkOnly();

            // For Rounded Corners
            MarketServiceBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, MarketServiceBtn.Width, MarketServiceBtn.Height, 30, 30));

        }

        private void displayIfHkOnly()
        {
            if (LoginUserForm.TypeOfDataUser == "Housekeeping")
            {
                MarketServiceBtn.Show();
            }
            else
            {
                MarketServiceBtn.Hide();
            }
        }
        private void housekeepingExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Mousehover Effects
        private void cleaningCatBtn_MouseEnter(object sender, EventArgs e)
        {
            cookingBtn.BackColor = Color.FromArgb(5, 62, 189);
            cookingBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void cleaningCatBtn_MouseLeave(object sender, EventArgs e)
        {
            cookingBtn.BackColor = Color.FromArgb(239, 239, 239);
            cookingBtn.ForeColor = Color.FromArgb(119, 120, 127);
        }

        private void cleaningBtn_MouseEnter(object sender, EventArgs e)
        {
            cleaningBtn.BackColor = Color.FromArgb(5, 62, 189);
            cleaningBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void cleaningBtn_MouseLeave(object sender, EventArgs e)
        {
            cleaningBtn.BackColor = Color.FromArgb(239, 239, 239);
            cleaningBtn.ForeColor = Color.FromArgb(119, 120, 127);
        }

        private void laundryBtn_MouseEnter(object sender, EventArgs e)
        {
            laundryBtn.BackColor = Color.FromArgb(5, 62, 189);
            laundryBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void laundryBtn_MouseLeave(object sender, EventArgs e)
        {
            laundryBtn.BackColor = Color.FromArgb(239, 239, 239);
            laundryBtn.ForeColor = Color.FromArgb(119, 120, 127);
        }

        private void sweepingBtn_MouseEnter(object sender, EventArgs e)
        {
            sweepingBtn.BackColor = Color.FromArgb(5, 62, 189);
            sweepingBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }

        private void sweepingBtn_MouseLeave(object sender, EventArgs e)
        {
            sweepingBtn.BackColor = Color.FromArgb(239, 239, 239);
            sweepingBtn.ForeColor = Color.FromArgb(119, 120, 127);
        }

        private void MarketServiceBtn_MouseEnter(object sender, EventArgs e)
        {
            MarketServiceBtn.BackColor = Color.FromArgb(255, 201, 72);
            MarketServiceBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void MarketServiceBtn_MouseLeave(object sender, EventArgs e)
        {
            MarketServiceBtn.BackColor = Color.FromArgb(5, 62, 189);
            MarketServiceBtn.ForeColor = Color.FromArgb(239, 239, 239);
        }
        #endregion

        private void MarketServiceBtn_Click(object sender, EventArgs e)
        {
            MarketServices.MarketHousekeeper marketHk = new MarketServices.MarketHousekeeper();
            marketHk.ShowDialog();
        }

        private async void DynamicControls()
        {

            DataTable dataTable = new DataTable();
/*
            Backend_Services.DatabaseConfiguration databasecon = new Backend_Services.DatabaseConfiguration();
            databasecon.GetItemsTable();
*/
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
                catch(Exception ex) { MessageBox.Show(ex.Message);  }          
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

        private void button2_Click(object sender, EventArgs e)
        {
            DynamicControls();
        }
    }
}
