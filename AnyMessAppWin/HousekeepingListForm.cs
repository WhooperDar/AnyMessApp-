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
    public partial class HousekeepingListForm : Form
    {
        public HousekeepingListForm()
        {
            InitializeComponent();
        }

        private void housekeepingExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}
