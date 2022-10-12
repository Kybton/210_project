using _210_project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210_project
{
    public partial class addNewUser : Form
    {
        public addNewUser()
        {
            InitializeComponent();
            MaximizeBox = false;
            KeyDown += new KeyEventHandler(addNewUserForm_KeyDown);
            genderComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addNewUserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                signUpBtn.PerformClick();
            }
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

        private bool validate()
        {
            string require = "* Require";
            if (nameTxtBox.Text.Trim() == "") nameErrorLbl.Text = require;
            else nameErrorLbl.Text = "";

            if (passwordTxtBox.Text == "")
            {
                passwordStrLbl.ForeColor = Color.Red;
                passwordStrLbl.Text = require;
            }

            if (phoneTxtBox.Text.Trim() == "") phoneErrorLbl.Text = require; else phoneErrorLbl.Text = "";

            int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int dob = int.Parse(dobDateTimePicker.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            if (age < 12) dobErrorLbl.Text = "* You cannot be under 12"; else dobErrorLbl.Text = "";

            if (addressTxtBox.Text == "") addressErrorLbl.Text = require; else addressErrorLbl.Text = "";

            if (genderComBox.Text == "") genderErrorLbl.Text = require; else genderErrorLbl.Text = "";

            if (weightTxtBox.Text.Trim() == "") weightErrorLbl.Text = require; else weightErrorLbl.Text = "";

            if (heightTxtBox.Text.Trim() == "") heightErrorLbl.Text = require; else heightErrorLbl.Text = "";

            //return (nameTxtBox.Text != "" && passwordTxtBox.Text != "" && phoneTxtBox.Text != "" && age < 12 && addressTxtBox.Text != "" && genderComBox.Text != "" && weightTxtBox.Text != "" && heightTxtBox.Text != "");
            return (nameTxtBox.Text != "" && passwordTxtBox.Text != "" && phoneTxtBox.Text != "" && age >= 12 && addressTxtBox.Text != "" && genderComBox.Text != "" && weightTxtBox.Text != "" && heightTxtBox.Text != "");
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            string hashedPassword = Utility.HashPassword(passwordTxtBox.Text);
            string name = nameTxtBox.Text;
            string phone = phoneTxtBox.Text;
            string date_of_birth = dobDateTimePicker.Value.ToString("MM/dd/yyyy");
            string address = addressTxtBox.Text;
            string gender = genderComBox.Text;
            string weight = weightTxtBox.Text;
            string height = heightTxtBox.Text;

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO member (id, username, password, phone, date_of_birth, address, gender, weight, height) VALUES ('" + userid + "', '" + name + "', '" + hashedPassword + "', '" + phone + "', '" + date_of_birth + "', '" + address + "', '" + gender + "', '" + weight + "', '" + height + "')";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Sign Up Successful.");
                this.Close();
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
            }

        }

        private void phoneTxtBox_Leave(object sender, EventArgs e)
        {
            string strRegex = @"(^[0-9]{10,}$)|(^\+[0-9]{3}\s+[0-9]{8,}$)";
            Regex reg = new Regex(strRegex);
            if (!reg.IsMatch(phoneTxtBox.Text)) phoneErrorLbl.Text = "Invalid Format"; else phoneErrorLbl.Text = "";
        }
    }
}
