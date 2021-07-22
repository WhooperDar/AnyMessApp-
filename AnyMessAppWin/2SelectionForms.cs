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
    public partial class _2SignUpForm : Form
    {
        // For rounded circle button
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        ); // end

        public _2SignUpForm()
        {
            InitializeComponent();

            // For rounded circle button
            loginButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loginButton.Width, loginButton.Height, 30, 30));

            SignUpBotton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SignUpBotton.Width, SignUpBotton.Height, 30, 30));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentPanelSignUp.Controls.Add(childForm);
            parentPanelSignUp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HideThisContents()
        {
            loginButton.Hide();
            SignUpBotton.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            openChildForm(new LoginUserForm());
            HideThisContents();
        }

        private void SignUpBotton_Click(object sender, EventArgs e)
        {
            openChildForm(new _3LoginForm());
            HideThisContents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Mouse Hover Effects
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(255, 201, 72);
            loginButton.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(5, 62, 189);
            loginButton.ForeColor = Color.White;
        }

        private void SignUpBotton_MouseEnter(object sender, EventArgs e)
        {
            SignUpBotton.BackColor = Color.FromArgb(255, 201, 72);
            SignUpBotton.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void SignUpBotton_MouseLeave(object sender, EventArgs e)
        {
            SignUpBotton.BackColor = Color.FromArgb(5, 62, 189);
            SignUpBotton.ForeColor = Color.White;
        }
        #endregion


    }
}
