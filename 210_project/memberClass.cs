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
using _210_project.Properties;

namespace _210_project
{
    public partial class memberClass : Form
    {
        public memberClass()
        {
            InitializeComponent();
        }

        DataTable class_dt = new DataTable();
        DataTable trainer_dt = new DataTable();

        private void showData()
        {
            string class_query = "SELECT * FROM gym_classes";
            string trainer_query = "SELECT id, username as Name, gender FROM trainer";
            SqlDataAdapter adapter = new SqlDataAdapter(class_query, Utility.connection);
            adapter.Fill(class_dt);
            adapter = new SqlDataAdapter(trainer_query, Utility.connection);
            adapter.Fill(trainer_dt);
            classDataGridView.DataSource = class_dt;
            trainerDataGridView.DataSource = trainer_dt;
        }

        private void memberClass_Load(object sender, EventArgs e)
        {
            showData();
            classDataGridView_SelectionChanged(null, null);
        }

        private void classDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (class_dt.Rows.Count > 0)
            {
                classIDLbl.Text = classDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                titleLbl.Text = classDataGridView.CurrentRow.Cells[1].Value.ToString();
                categoryLbl.Text = classDataGridView.CurrentRow.Cells[2].Value.ToString();
                nosLbl.Text = classDataGridView.CurrentRow.Cells[3].Value.ToString();
                startDateLbl.Text = classDataGridView.CurrentRow.Cells[4].Value.ToString();
                endDateLbl.Text = classDataGridView.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void trainerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (trainer_dt.Rows.Count > 0)
            {
                trainerIDLbl.Text = trainerDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                nameLbl.Text = trainerDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (class_dt.Rows.Count > 0 && trainer_dt.Rows.Count > 0)
                {
                    string query = "SELECT TOP 1 id FROM enrollmement_data ORDER BY id DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, Utility.connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    string eID;

                    if (dt.Rows.Count > 0)
                    {
                        string last_id = dt.Rows[0][0].ToString();
                        eID = Utility.generateStaticID(last_id, "eid-", "D5");
                    }
                    else
                    {
                        eID = "eid-00001";
                    }

                    SqlCommand command = Utility.connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO enrollmement_data (id, class_id, member_id, trainer_id) VALUES ('" + eID + "', '" + classIDLbl.Text + "', '" + Settings.Default.username.Trim() + "', '" + trainerIDLbl.Text + "')";
                    Utility.connection.Open();
                    command.ExecuteNonQuery();
                    Utility.connection.Close();
                    MessageBox.Show("Enrolled");
                }
                else
                {
                    MessageBox.Show("Enrollment requirements not met.", "Cannot Enroll!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
