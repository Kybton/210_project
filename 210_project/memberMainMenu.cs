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
    public partial class memberMainMenu : Form
    {
        public memberMainMenu()
        {
            InitializeComponent();
            Closed += new EventHandler(memberMainMenu_Close);
        }

        private void memberMainMenu_Close(object sender, EventArgs e)
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
            Settings.Default.username = "";
            Settings.Default.role = "";
            Settings.Default.Save();
            Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new memberClass());
        }

        private void eDataBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new memeberEnrollmentData());
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new memberProfileEdit());
        }
    }
}
