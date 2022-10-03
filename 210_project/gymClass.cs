using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using _210_project.Utilities;

namespace _210_project
{
    public partial class gymClass : Form
    {
        public gymClass()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Utility.connection);

        DataTable dt = new DataTable();

        private void dataShow()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Utility.connection);
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM gym_classes";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dt.Clear();
                adapter.Fill(dt);
                gymClassesDataGridView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    classIDLbl.Text = "";
                    titleTxtBox.Text = "";
                    categoryTxtBox.Text = "";
                    nosTxtBox.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gymClass_Load(object sender, EventArgs e)
        {
            dataShow();
            gymClassesDataGridView_Click(null, null);
            searchByComBox.SelectedText = "Class ID";
        }

        private bool validate_update()
        {
            bool filled = false;
            string require = "* Required";

            if (titleTxtBox.Text.Trim() != "" && categoryTxtBox.Text.Trim() != "" && nosTxtBox.Text.Trim() != "") filled = true;

            if (titleTxtBox.Text.Trim() == "") titleRequiredLbl.Text = require;
            if (categoryTxtBox.Text.Trim() == "") categoryRequiredLbl.Text = require;
            if (nosTxtBox.Text.Trim() == "") nosRequiredLbl.Text = require;

            // have to check the dates
            // start date cannot be smaller than the end date

            return filled;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // validation
            if (!validate_update())
            {
                return;
            }
            

            if (classIDLbl.Text != "")
            {
                SqlConnection connection = new SqlConnection(Utility.connection);
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE gym_classes SET title = '" + titleTxtBox.Text + "', category = '" + categoryTxtBox.Text + "', number_of_session = '" + nosTxtBox.Text + "', start_date = '" + startDateTimePicker.Value.ToString("MM/dd/yyy") + "', end_date = '" + endDateTimePicker.Value.ToString("MM/dd/yyy") + "' WHERE id = '" + classIDLbl.Text + "'";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Updated");
                dataShow();
            }
            else MessageBox.Show("No Data to update.", "No Data!");
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxtBox.Text.Trim() == "")
            {
                searchRequiredLbl.Text = "* Required";
                return;
            }


            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM gym_classes WHERE ";

            switch (searchByComBox.Text.Trim())
            {
                case "Class ID":
                    command.CommandText += "id LIKE '%" + searchTxtBox.Text + "%'";
                    break;

                case "Title":
                    command.CommandText += "title LIKE '%" + searchTxtBox.Text + "%'";
                    break;

                case "Category":
                    command.CommandText += "category LIKE '%" + searchTxtBox.Text + "%'";
                    break;
            }

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dt.Clear();
            adapter.Fill(dt);
            gymClassesDataGridView.DataSource = dt;

            // calling the click function to show the data
            gymClassesDataGridView_Click(null, null);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            classAdd classAddForm = new classAdd();
            classAddForm.insertUpdate += new EventHandler(gym_class_inserted);
            classAddForm.Show();
        }

        void gym_class_inserted(object sender, EventArgs e)
        {
            dataShow();
            gymClassesDataGridView_Click(null, null);
        }

        private void gymClassesDataGridView_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                classIDLbl.Text = gymClassesDataGridView.CurrentRow.Cells[0].Value.ToString();
                titleTxtBox.Text = gymClassesDataGridView.CurrentRow.Cells[1].Value.ToString();
                categoryTxtBox.Text = gymClassesDataGridView.CurrentRow.Cells[2].Value.ToString();
                nosTxtBox.Text = gymClassesDataGridView.CurrentRow.Cells[3].Value.ToString();
                startDateTimePicker.Text = gymClassesDataGridView.CurrentRow.Cells[4].Value.ToString();
                endDateTimePicker.Text = gymClassesDataGridView.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (classIDLbl.Text != "")
            {
                var confirm = MessageBox.Show("The data will be deleted permanently.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM gym_classes WHERE id = '" + classIDLbl.Text + "'";
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    dataShow();
                    gymClassesDataGridView_Click(null, null);
                }
            }
            else MessageBox.Show("There is not data to delete.", "No Data!");
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text.Trim() == "") dataShow();
        }
    }
}
