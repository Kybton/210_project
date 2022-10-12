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
using _210_project.Properties;

namespace _210_project
{
    public partial class userChangePassword : Form
    {
        public userChangePassword()
        {
            InitializeComponent();
        }
        bool same_pass = false;

        private bool validate()
        {
            string error = "* Password cannot be empty";
            if (oldPasswordTxtBox.Text == "") oldErrorLbl.Text = error;
            if (newPassTxtBox.Text == "") newErrorLbl.Text = error;
            if (newPassTxtBox2.Text == "") new2ErrorLbl.Text = error;

            return (oldPasswordTxtBox.Text != "" && newPassTxtBox.Text != "" && newPassTxtBox2.Text != "");
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            // if validate returns false exit.
            if (!validate() || !same_pass) return;

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT password FROM member WHERE id = '" + Settings.Default.username + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (Utility.CheckPassword(dt.Rows[0][0].ToString(), oldPasswordTxtBox.Text))
                {
                    command.CommandText = "UPDATE member SET password = '" + Utility.HashPassword(newPassTxtBox.Text) + "' WHERE id = '" + Settings.Default.username + "'";
                    Utility.connection.Open();
                    command.ExecuteNonQuery();
                    Utility.connection.Close();
                    MessageBox.Show("Password Updated Successfully.", "UPDATED!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Credentials.", "Check Again");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void newPassTxtBox2_TextChanged(object sender, EventArgs e)
        {
            if (newPassTxtBox.Text != newPassTxtBox2.Text)
            {
                new2ErrorLbl.Text = "* Passwords do not match.";
                same_pass = false;
            }
            else
            {
                newErrorLbl.Text = "";
                new2ErrorLbl.Text = "";
                same_pass = true;
            }
        }

        private void newPassTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (newPassTxtBox.Text != newPassTxtBox2.Text)
            {
                newErrorLbl.Text = "* Passwords do not match.";
                same_pass = false;
            }
            else
            {
                newErrorLbl.Text = "";
                new2ErrorLbl.Text = "";
                same_pass = true;
            }
        }
    }
}
