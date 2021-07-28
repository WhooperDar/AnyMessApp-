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
using FireSharp.Interfaces;
using FireSharp.Response; 

namespace AnyMessAppWin
{
    public partial class CreateAccount : Form
    {
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
        public CreateAccount()
        {
            InitializeComponent();

            // For Rounded Corner Buttons
            createAccBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, createAccBtn.Width, createAccBtn.Height, 30, 30));
        }

        // Saving data to database
        private void createAccBtn_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text != "Username" && firstNameCreate.Text != "First Name" && emailBox.Text != "Email" && passwordBox.Text != null && confirmpassBox.Text != null)
            {
                try
                {
                    if (string.Equals(passwordBox.Text, confirmpassBox.Text))
                    {
                        Backend_Services.DatabaseConfiguration databaseObj = new Backend_Services.DatabaseConfiguration();

                        databaseObj.SavaDataCreateAccount(usernameBox.Text, firstNameCreate.Text, emailBox.Text, passwordBox.Text, confirmpassBox.Text);

                        openChildForm(new LoginUserForm());
                        HideThisContents();
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password does not match!");
                        if(!string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrEmpty(confirmpassBox.Text))
                        {
                            passwordBox.Text = "";
                            confirmpassBox.Text = "";
                        }
                    }
                    
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Please fill up the form!"); 
            }
            
        }

        #region Text Effects(TextBoxes)
        // Text Changed to blue
        private void firstNameCreate_Enter(object sender, EventArgs e)
        {
            if(firstNameCreate.Text == "First Name")
            {
                firstNameCreate.Text = ""; 
                firstNameCreate.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }
        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.FromArgb(5, 62, 189);
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            passwordBox.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void confirmpassBox_Enter(object sender, EventArgs e)
        {
            confirmpassBox.ForeColor = Color.FromArgb(5, 62, 189);
        }

        #endregion

        #region Mouse Hover Effects(Create button)
        private void createAccBtn_MouseEnter(object sender, EventArgs e)
        {
            createAccBtn.BackColor = Color.FromArgb(255, 201, 72);
            createAccBtn.ForeColor = Color.FromArgb(5, 62, 189);
        }

        private void createAccBtn_MouseLeave(object sender, EventArgs e)
        {
            createAccBtn.BackColor = Color.FromArgb(5, 62, 189);
            createAccBtn.ForeColor = Color.White;
        }
        #endregion

        #region Utility Functions(OpenChildForm, Hide Components)
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCreateAccParent.Controls.Add(childForm);
            panelCreateAccParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } 
        
        private void HideThisContents()
        {
            label1.Hide();
            label2.Hide();
            nameLabel.Hide();
            usernameLabel.Hide();
            emailLabel.Hide();
            passwordLabel.Hide();
            conPassLabel.Hide();
            firstNameCreate.Hide();
            usernameBox.Hide();
            emailBox.Hide();
            passwordBox.Hide();
            confirmpassBox.Hide();
            createAccBtn.Hide();
        }
        #endregion
    }
}
