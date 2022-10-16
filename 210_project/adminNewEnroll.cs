using _210_project.Properties;
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
    public partial class adminNewEnroll : Form
    {
        public adminNewEnroll()
        {
            InitializeComponent();
        }

        DataTable class_dt = new DataTable();
        DataTable user_dt = new DataTable();
        DataTable trainer_dt = new DataTable();

        private void showData()
        {
                string class_query = "SELECT * FROM gym_classes";
                string trainer_query = "SELECT id, username as Name, gender FROM member";
                SqlDataAdapter adapter = new SqlDataAdapter(class_query, Utility.connection);
                adapter.Fill(class_dt);
                adapter = new SqlDataAdapter(trainer_query, Utility.connection);
                adapter.Fill(user_dt);
                classDataGridView.DataSource = class_dt;
                userDataGridView.DataSource = user_dt;
        }

        private void trainerComboDataAdd()
        {
            string query = "SELECT * FROM trainer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Utility.connection);
            adapter.Fill(trainer_dt);

            for (int i = 0; i < trainer_dt.Rows.Count; i++)
            {
                trainerComBox.Items.Add(trainer_dt.Rows[i][1].ToString());
            }
        }

        private void adminNewEnroll_Load(object sender, EventArgs e)
        {
            showData();
            trainerComboDataAdd();
        }

        private void classDataGridView_Click(object sender, EventArgs e)
        {
            if (class_dt.Rows.Count > 0)
            {
                classIDLbl.Text = classDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                titleLbl.Text = classDataGridView.CurrentRow.Cells[1].Value.ToString();
                categoryLbl.Text = classDataGridView.CurrentRow.Cells[2].Value.ToString();
                nosLbl.Text = classDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void userDataGridView_Click(object sender, EventArgs e)
        {
            if (user_dt.Rows.Count > 0)
            {
                userIDLbl.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                usernameLbl.Text = userDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void trainerComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainerIDLbl.Text = trainer_dt.Rows[trainerComBox.SelectedIndex][0].ToString();
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            if (trainerIDLbl.Text == "Trainer ID" || userIDLbl.Text == "User ID" || classIDLbl.Text == "")
            {
                MessageBox.Show("Requiremements do not meet");
                return;
            }

            try
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
                command.CommandText = "INSERT INTO enrollmement_data (id, class_id, member_id, trainer_id) VALUES ('" + eID + "', '" + classIDLbl.Text + "', '" + userIDLbl.Text + "', '" + trainerIDLbl.Text + "')";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Enrolled");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
