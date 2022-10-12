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
    public partial class memberProfileEdit : Form
    {
        public memberProfileEdit()
        {
            InitializeComponent();
            genderComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        DataTable dt = new DataTable();

        private void fillOutData()
        {
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM member WHERE id = '" + Settings.Default.username + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dt.Clear();
                adapter.Fill(dt);

                userIDLbl.Text = dt.Rows[0][0].ToString();
                nameTxtBox.Text = dt.Rows[0][1].ToString().Trim();
                phoneTxtBox.Text = dt.Rows[0][3].ToString().Trim();
                dobDateTimePicker.Text = dt.Rows[0][4].ToString().Trim();
                addressRchTxtBox.Text = dt.Rows[0][5].ToString().Trim();
                genderComBox.Text = dt.Rows[0][6].ToString().Trim();
                weightTxtBox.Text = dt.Rows[0][7].ToString().Trim();
                heightTxtBox.Text = dt.Rows[0][8].ToString().Trim();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void memberProfileEdit_Load(object sender, EventArgs e)
        {
            try
            {
                fillOutData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private bool validate()
        {
            if (nameTxtBox.Text.Trim() == "") return false;
            if (phoneTxtBox.Text.Trim() == "") return false;
            if (addressRchTxtBox.Text.Trim() == "") return false;
            if (weightTxtBox.Text.Trim() == "") return false;


            int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int dob = int.Parse(dobDateTimePicker.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            if (age < 12) return false;

            try
            {
                int weight = int.Parse(weightTxtBox.Text.Trim());
                int height = int.Parse(heightTxtBox.Text.Trim());
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!validate()) MessageBox.Show("Requirements do not match.");

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE member SET username = '" + nameTxtBox.Text.Trim() + "', phone = '" + phoneTxtBox.Text.Trim() + "', date_of_birth = '" + dobDateTimePicker.Value.ToString("MM/dd/yyyy") + "', address = '" + addressRchTxtBox.Text + "', gender = '" + genderComBox.Text + "', weight = '" + weightTxtBox.Text + "', height = '" + heightTxtBox.Text + "' WHERE id = '" + Settings.Default.username + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Updated Successfully", "Updated!");
                fillOutData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void chgPassBtn_Click(object sender, EventArgs e)
        {
            userChangePassword cpF = new userChangePassword();
            cpF.Show();
        }
    }
}
