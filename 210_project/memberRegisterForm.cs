using _210_project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210_project
{
    public partial class memberRegisterForm : Form
    {
        public memberRegisterForm()
        {
            InitializeComponent();
            Closed += new System.EventHandler(memberRegisterForm_Close);
            MaximizeBox = false;
            KeyDown += new KeyEventHandler(memberRegisterForm_KeyDown);
        }

        private void memberRegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                signUpBtn.PerformClick();
            }
        }

        private void memberRegisterForm_Close(object sender, EventArgs e)
        {
            Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
            Close();
        }

        System.Windows.Forms.Timer _typingTimer;
        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxtBox.Text))
            {
                userIdLbl.Text = "User ID: ";
                nameErrorLbl.Text = "*Name cannot be empty";
                return;
            }

            if (_typingTimer == null)
            {
                /* WinForms: */
                _typingTimer = new Timer();
                _typingTimer.Interval = 1000;

                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop(); // Resets the timer
            _typingTimer.Tag = (sender as TextBox).Text; // This should be done with EventArgs
            _typingTimer.Start();
        }

        string userid;

        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer;

            if (timer == null)
            {
                return;
            }

            userid = Utility.GenerateUserID(nameTxtBox.Text, "member");
            userIdLbl.Text = "User ID: " + userid;

            timer.Stop();
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {
            /*Regex rgx = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChars = rgx.IsMatch(passwordTxtBox.Text);*/
            string password = passwordTxtBox.Text;

            if (password.Length == 0)
            {
                passwordStrLbl.ForeColor = Color.Red;
                passwordStrLbl.Text = "*Password cannot be empty.";
                return;
            }

            bool specialChars = Utility.hasSpecialChar(password);
            bool numbers = Utility.hasNumber(password);

            if (specialChars && numbers && (password.Length > 6))
            {
                passwordStrLbl.ForeColor = Color.Green;
                passwordStrLbl.Text = "Strong Password.";
            }
            else
            {
                passwordStrLbl.ForeColor = Color.Red;
                passwordStrLbl.Text = "*Weak Password.";
            }
        }

        private void passwordHideBtn_Click(object sender, EventArgs e)
        {
            passwordShowBtn.BringToFront();
            passwordTxtBox.PasswordChar = '*';
        }

        private void passwordShowBtn_Click(object sender, EventArgs e)
        {
            passwordHideBtn.BringToFront();
            passwordTxtBox.PasswordChar = '\0';
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxtBox.Text) && String.IsNullOrEmpty(passwordTxtBox.Text))
            {
                nameErrorLbl.Text = "*Name cannot be empty.";
                passwordStrLbl.ForeColor = Color.Red;
                passwordStrLbl.Text = "*Password cannot be empty.";
                return;
            }
            else if (String.IsNullOrEmpty(nameTxtBox.Text))
            {
                nameErrorLbl.Text = "*Name cannot be empty.";
                passwordStrLbl.Text = "";
                return;
            }
            else if (String.IsNullOrEmpty(passwordTxtBox.Text))
            {
                passwordStrLbl.ForeColor = Color.Red;
                passwordStrLbl.Text = "*Password cannot be empty.";
                nameErrorLbl.Text = "";
                return;
            }

            string hashedPassword = Utility.HashPassword(passwordTxtBox.Text);
            string name = nameTxtBox.Text;

            try
            {
                // SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minoa\OneDrive\Documents\201_project.mdf;Integrated Security=True;Connect Timeout=30");
                SqlConnection connection = new SqlConnection(Utility.connection);
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO member (id, name, password) VALUES ('" + userid + "', '" + name + "', '" + hashedPassword + "')";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }

            MessageBox.Show("Sign Up Successful.");
        }
    }
}