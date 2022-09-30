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

        DataTable dt = new DataTable();
        int index;

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
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gymClass_Load(object sender, EventArgs e)
        {
            dataShow();
            index = 0;

            if (dt.Rows.Count > 0)
            {
                classIDLbl.Text = dt.Rows[index][0].ToString();
                titleTxtBox.Text = dt.Rows[index][1].ToString();
                categoryTxtBox.Text = dt.Rows[index][2].ToString();
                nosTxtBox.Text = dt.Rows[index][3].ToString();
                startDateTimePicker.Text = dt.Rows[index][4].ToString();
                endDateTimePicker.Text = dt.Rows[index][5].ToString();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
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
    }
}
