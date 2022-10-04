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

        SqlConnection connection = new SqlConnection(Utility.connection);

        DataTable dt = new DataTable();

        private void showData()
        {
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT id, username, gender FROM trainer";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
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
                nameTxtBox.Text = trainerDataGridView.CurrentRow.Cells[1].Value.ToString();
                genderComBox.Text = trainerDataGridView.CurrentRow.Cells[2].Value.ToString();
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
    }
}
