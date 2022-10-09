using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _210_project.Utilities;

namespace _210_project
{
    public partial class trainerManagementForm : Form
    {
        public trainerManagementForm()
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
                command.CommandText = "SELECT id, username, gender FROM trainer";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dt.Clear();
                adapter.Fill(dt);
                trainerDataGridView.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void trainerManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                showData();
                trainerDataGridView_Click(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void trainerDataGridView_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                trainerIDLbl.Text = trainerDataGridView.CurrentRow.Cells[0].Value.ToString();
                nameTxtBox.Text = trainerDataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
                genderComBox.Text = trainerDataGridView.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            else
            {
                trainerIDLbl.Text = "ID".Trim();
                nameTxtBox.Text = "".Trim();
                genderComBox.Text = "".Trim();
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            trainerAdd trainerAddF = new trainerAdd();
            trainerAddF.trainerAdded += new EventHandler(trainerAdded);
            trainerAddF.Show();
        }

        private void trainerAdded(object sender, EventArgs e)
        {
            showData();
            trainerDataGridView_Click(null, null);
        }

        private bool validate()
        {
            if (nameTxtBox.Text.Trim() == "") nameRequiredLbl.Text = "* Required";
            else nameRequiredLbl.Text = "";

            if (genderComBox.Text.Trim() == "") genderRequiredLbl.Text = "* Required";
            else genderRequiredLbl.Text = "";

            return (nameTxtBox.Text.Trim() != "" && genderComBox.Text != "" && trainerIDLbl.Text != "ID");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!validate()) return;

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE trainer SET username = '" + nameTxtBox.Text + "', gender = '" + genderComBox.Text + "' WHERE id = '" + trainerIDLbl.Text + "'";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                showData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainerIDLbl.Text != "ID")
                {
                    SqlCommand command = Utility.connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM trainer WHERE id = '" + trainerIDLbl.Text + "'";
                    Utility.connection.Open();
                    command.ExecuteNonQuery();
                    Utility.connection.Close();
                    showData();
                    trainerDataGridView_Click(null, null);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
