using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210_project
{
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            Hide();
            loginForm loginF = new loginForm();
            loginF.ShowDialog();
            Close();
        }

        private void loadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
