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
    public partial class trainerAdd : Form
    {
        public trainerAdd()
        {
            InitializeComponent();
        }
        public event EventHandler trainerAdded;

        string trainer_id;
        private bool validate_fill()
        {
            bool filled = false;

            if (nameTxtBox.Text.Trim() != "" && genderComBox.Text.Trim() != "") filled = true;

            if (nameTxtBox.Text.Trim() == "") nameRequiredLbl.Text = "* Required";
            if (genderComBox.Text.Trim() == "") genderRequiredLbl.Text = "* Required";

            return filled;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (!validate_fill())
            {
                return;
            }

            string name = nameTxtBox.Text.Trim();
            string gender = genderComBox.Text.Trim();

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO trainer (id, username, gender) VALUES ('" + trainer_id + "', '" + name + "', '" + gender + "')";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                trainerAdded(null, null);
                trainer_id = Utility.generateStaticID(trainer_id, "T-");
                trainerIDLbl.Text = trainer_id;

                nameTxtBox.Text = "";
                genderComBox.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void trainerAdd_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1 id FROM trainer ORDER BY id DESC";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "id");

                if (ds.Tables["id"].Rows.Count > 0)
                {
                    string lastClassID = ds.Tables["id"].Rows[0][0].ToString();
                    trainer_id = Utility.generateStaticID(lastClassID, "T-");
                }
                else trainer_id = "T-0001";

                trainerIDLbl.Text = trainer_id;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
