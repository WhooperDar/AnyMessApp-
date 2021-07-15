using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyMessAppWin
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HousekeepingListForm hkForm = new HousekeepingListForm();
            hkForm.ShowDialog();
            this.Hide(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgencyListForm agencyForm = new AgencyListForm();
            agencyForm.ShowDialog();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.ShowDialog();
            this.Hide();
        }
    }
}
