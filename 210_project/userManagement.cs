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
using _210_project.Utilities;

namespace _210_project
{
    public partial class userManagement : Form
    {
        public userManagement()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void showData()
        {
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT id as 'User ID', username as Name, phone, date_of_birth as Birthday, address, gender, weight, height FROM member";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dt.Clear();
                adapter.Fill(dt);
                userDataGridView.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    userDataGridView_SelectionChanged(null, null);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void userManagement_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    userIdLbl.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                    usernameTxtBox.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
                    phoneTxtBox.Text = userDataGridView.CurrentRow.Cells[2].Value.ToString().Trim();
                    dobDateTimePicker.Text = userDataGridView.CurrentRow.Cells[3].Value.ToString();
                    addressTxtBox.Text = userDataGridView.CurrentRow.Cells[4].Value.ToString().Trim();
                    genderComBox.Text = userDataGridView.CurrentRow.Cells[5].Value.ToString().Trim();
                    weightTxtBox.Text = userDataGridView.CurrentRow.Cells[6].Value.ToString().Trim();
                    heightTxtBox.Text = userDataGridView.CurrentRow.Cells[7].Value.ToString().Trim();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM member WHERE username LIKE '%" + searchTxtBox.Text + "%'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dt.Clear();
                adapter.Fill(dt);
                userDataGridView.DataSource = dt;

                if (dt.Rows.Count > 0) userDataGridView_SelectionChanged(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "")
            {
                showData();
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            addNewUser aUF = new addNewUser();
            aUF.Show();
        }

        private bool validate()
        {
            if (usernameTxtBox.Text == "") return false;
            if (phoneTxtBox.Text == "") return false;

            int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int dob = int.Parse(dobDateTimePicker.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            if (age < 12)
            {
                MessageBox.Show("Cannot be younger than 12.");
                return false;
            }

            return true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (userIdLbl.Text == "ID" || userIdLbl.Text == "")
            {
                MessageBox.Show("No user to update");
                return;
            }

            if (!validate())
            {
                MessageBox.Show("Please fill out all the required fields.");
                return;
            }

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE member SET username = '" + usernameTxtBox.Text + "', phone = '" + phoneTxtBox.Text + "', date_of_birth = '" + dobDateTimePicker.Value.ToString("MM/dd/yyyy") + "', address = '" + addressTxtBox.Text + "', gender = '" + genderComBox.Text + "', weight = '" + weightTxtBox.Text + "', height ='" + heightTxtBox.Text + "' WHERE id = '" + userIdLbl.Text + "'"; 
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Updated Successfully", "Updated");
                showData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "")
            {
                MessageBox.Show("Please enter the password first.");
                return;
            }

            if (userIdLbl.Text == "ID")
            {
                MessageBox.Show("No member to update");
                return;
            }
            
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE member SET password = '" + Utility.HashPassword(passwordTxtBox.Text) + "' WHERE id = '" + userIdLbl.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                passwordTxtBox.Text = "";
                MessageBox.Show("Updated Successfully", "Updated");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
