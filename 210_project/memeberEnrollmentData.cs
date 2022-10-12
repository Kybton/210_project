using _210_project.Properties;
using _210_project.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class memeberEnrollmentData : Form
    {
        public memeberEnrollmentData()
        {
            InitializeComponent();
            //trainerComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        DataTable dt = new DataTable();
        DataTable trainer_dt = new DataTable();

        private void showData()
        {
            SqlCommand command = Utility.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT a.id, b.title, b.category, b.start_date, b.end_date, c.id AS 'trainer id', c.username AS 'trainer name' FROM enrollmement_data a INNER JOIN gym_classes AS b ON b.id = a.class_id INNER JOIN trainer c ON c.id = a.trainer_id WHERE member_id = '" + Settings.Default.username.Trim() + "'";
            Utility.connection.Open();
            command.ExecuteNonQuery();
            Utility.connection.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dt.Clear();
            adapter.Fill(dt);
            enrolDataGridView.DataSource = dt;
            totalEnrollLbl.Text = "Enrolled classes: " + dt.Rows.Count.ToString();

            if (dt.Rows.Count <= 0)
            {
                trainerIDLbl.Text = "";
                enrollIDLbl.Text = "";
                titleLbl.Text = "";
            }
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

        private void memeberEnrollmentData_Load(object sender, EventArgs e)
        {
            try
            {
                showData();
                trainerComboDataAdd();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void unenrollBtn_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Class to Unenroll.", "NO CLASS");
                return;
            }

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM enrollmement_data where id = '" + enrollIDLbl.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Unenrolled successfully.", "Unenrolled!");
                showData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No Data to Update.", "NO DATA");
                return;
            }

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE enrollmement_data SET trainer_id = '" + trainerIDLbl.Text + "' WHERE id = '" + enrollIDLbl.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                MessageBox.Show("Updated Successfully.", "Updated");
                showData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void enrolDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                enrollIDLbl.Text = enrolDataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
                titleLbl.Text = enrolDataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
                trainerIDLbl.Text = enrolDataGridView.CurrentRow.Cells[5].Value.ToString().Trim();
                trainerComBox.Text = enrolDataGridView.CurrentRow.Cells[6].Value.ToString().Trim();
            }
        }

        private void trainerComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainerIDLbl.Text = trainer_dt.Rows[trainerComBox.SelectedIndex][0].ToString();
        }
    }
}
