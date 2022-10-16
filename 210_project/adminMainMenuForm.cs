using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _210_project.Properties;

namespace _210_project
{
    public partial class formAdminMainMenu : Form
    {
        public formAdminMainMenu()
        {
            InitializeComponent();
            Closed += new EventHandler(formAdminMainMenu_Close);
        }

        private void formAdminMainMenu_Close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.username = string.Empty;
            Settings.Default.role = string.Empty;
            Settings.Default.Save();
            // Settings.Default.Reload();
            Hide();
            loginForm loginF = new loginForm();
            loginF.Show();
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new gymClass());
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new userManagement());
        }

        private void trainerBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new trainerManagementForm());
        }

        private void enrollmentBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new adminEnrollManage());
        }
    }
}
