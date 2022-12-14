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

            if (usernameTxtBox.Text == "" || usernameTxtBox.Text == "User ID")
            {
                usernameErrorLbl.Text = "*User ID cannot be empty.";
                if (filled) filled = false;
            }
            else usernameErrorLbl.Text = "";

            if (passwordTxtBox.Text == "" || passwordTxtBox.Text == "Password")
            {
                passwordErrorLbl.Text = "*Password cannot be empty.";
                if (filled) filled = false;
            }
            else passwordErrorLbl.Text = "";

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
                command.CommandText = "SELECT password FROM " + table + " WHERE id = '" + usernameTxtBox.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (table.Equals("admin"))
                    {
                        if (Utility.CheckPassword(dt.Rows[0][0].ToString(), passwordTxtBox.Text))
                        {
                            Hide();
                            if (rememberCheckBox.Checked)
                            {
                                Settings.Default.username = usernameTxtBox.Text;
                                Settings.Default.role = table;
                                Settings.Default.Save();
                            }

                            formAdminMainMenu mainMenuForm = new formAdminMainMenu();
                            mainMenuForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect credentials.");
                        }
                    }
                    else
                    {
                        if (Utility.CheckPassword(dt.Rows[0][0].ToString(), passwordTxtBox.Text))
                        {
                            Hide();
                            if (rememberCheckBox.Checked)
                            {
                                Settings.Default.username = usernameTxtBox.Text;
                                Settings.Default.role = table;
                                Settings.Default.Save();
                            }

                            memberMainMenu mf = new memberMainMenu();
                            mf.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect credentials.");
                        }
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
            if (usernameTxtBox.Text == "User ID")
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
                usernameTxtBox.Text = "User ID";
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
