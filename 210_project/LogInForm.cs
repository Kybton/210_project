using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Forms.VisualStyles;
using _210_project.Utilities;
using _210_project.Properties;

namespace _210_project
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            AcceptButton = loginBtn;
            KeyDown += new KeyEventHandler(loginForm_KeyDown);
        }

        private (bool, string) validate_Login()
        {
            bool filled = true;
            string role = "";

            if (adminRdBtn.Checked)
            {
                role = "admin";
                roleErrorLbl.Text = "";
            }
            else if (memberRdBtn.Checked)
            {
                role = "member";
                roleErrorLbl.Text = "";
            }
            else
            {
                roleErrorLbl.Text = "*Select a role.";
                filled = false;
            }

            // this code can be improved
            // too many repetations and overloaded with unnecessary codes
            if ((string.IsNullOrEmpty(usernameTxtBox.Text) && string.IsNullOrEmpty(passwordTxtBox.Text)) || (usernameTxtBox.Text == "Username" && passwordTxtBox.Text == "Password"))
            {
                usernameErrorLbl.Text = "*Username cannot be empty.";
                passwordErrorLbl.Text = "*Password cannot be empty.";
                if (filled) filled = false;
            }
            else if (string.IsNullOrEmpty(usernameTxtBox.Text) || usernameTxtBox.Text == "Username")
            {
                passwordErrorLbl.Text = "";
                usernameErrorLbl.Text = "*Username cannot be empty.";
                if (filled) filled = false;
            }
            else if (string.IsNullOrEmpty(passwordTxtBox.Text) || passwordTxtBox.Text == "Password")
            {
                usernameErrorLbl.Text = "";
                passwordErrorLbl.Text = "*Password cannot be empty.";
                if (filled) filled = false;
            }
            else
            {
                passwordErrorLbl.Text = "";
                usernameErrorLbl.Text = "";
            }

            return (filled, role);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var val = validate_Login();
            if (val.Item1 == false) return;

            string table = val.Item2;

            try
            {
                DataTable dt = new DataTable();
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT 1 FROM " + table + " WHERE username = '" + usernameTxtBox.Text + "' AND password = '" + passwordTxtBox.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Hide();

                    if (rememberCheckBox.Checked)
                    {
                        Settings.Default.username = usernameTxtBox.Text;
                        Settings.Default.role = table;
                        Settings.Default.Save();
                    }

                    if (table.Equals("admin"))
                    {
                        formAdminMainMenu mainMenuForm = new formAdminMainMenu();
                        mainMenuForm.ShowDialog();
                    }
                    else if (table.Equals("member"))
                    {
                        // show member form
                        // check if the user has already filled out the required fields.
                        // if not ask them to fill it out
                        // if yes, skip to the main menu
                    }
                    else
                    {
                        // show trainer form
                    }
                }
                else
                {
                    // showing incorrect credentials instead of showing "wrong password" or "wrong username"
                    // to protect brute force attacks
                    MessageBox.Show("Incorrect credentials.");
                }
            } 
            catch (Exception errMsg)
            {
                MessageBox.Show(errMsg.Message);
            }
            
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                loginBtn.PerformClick();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Hide();
            memberRegisterForm memberRegForm = new memberRegisterForm();
            memberRegForm.ShowDialog();
            Close();
        }

        private void usernameTxtBox_Enter(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "Username")
            {
                usernameTxtBox.Text = "";
                usernameTxtBox.ForeColor = Color.Black;
            }
        }

        private void usernameTxtBox_Leave(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "")
            {
                usernameTxtBox.ForeColor = Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
                usernameTxtBox.Text = "Username";
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Password")
            {
                passwordTxtBox.ForeColor = Color.Black;
                passwordTxtBox.Text = "";
                passwordTxtBox.PasswordChar = '*';
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "")
            {
                passwordTxtBox.PasswordChar = '\0';
                passwordTxtBox.ForeColor = Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(68)))), ((int)(((byte)(57)))));
                passwordTxtBox.Text = "Password";
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (showPCheckBox.Checked == true)
            {
                passwordTxtBox.PasswordChar = '\0';
            }

            if (showPCheckBox.Checked == false && passwordTxtBox.Text != "Password")
            {
                passwordTxtBox.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
