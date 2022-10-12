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
    public partial class classAdd : Form
    {

        public event EventHandler insertUpdate;

        public classAdd()
        {
            InitializeComponent();
        }

        Color grey = Color.FromArgb(97, 68, 57);
        string class_id;

        private void classAdd_Close(object sender, EventArgs e)
        {
            // if the text fields are not empty, ask the user for the exit confirmation
            // or save the value to the settings    
        }

        private void classAdd_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1 id FROM gym_classes ORDER BY id DESC";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "id");

                if (ds.Tables["id"].Rows.Count > 0)
                {
                    string lastClassID = ds.Tables["id"].Rows[0][0].ToString();
                    class_id = Utility.generateStaticID(lastClassID, "Class-");
                }
                else class_id = "Class-0001";

                classIDLbl.Text = class_id;
                
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void titleTxtBox_Enter(object sender, EventArgs e)
        {
            if (titleTxtBox.Text == "Title")
            {
                titleTxtBox.ForeColor = Color.Black;
                titleTxtBox.Text = "";
            }
        }

        private void titleTxtBox_Leave(object sender, EventArgs e)
        {
            if (titleTxtBox.Text == "")
            {
                titleTxtBox.ForeColor = grey;
                titleTxtBox.Text = "Title";
            }
        }

        private void categoryTxtBox_Enter(object sender, EventArgs e)
        {
            if (categoryTxtBox.Text == "Category")
            {
                categoryTxtBox.ForeColor = Color.Black;
                categoryTxtBox.Text = "";
            }
        }

        private void categoryTxtBox_Leave(object sender, EventArgs e)
        {
            if (categoryTxtBox.Text == "")
            {
                categoryTxtBox.ForeColor = grey;
                categoryTxtBox.Text = "Category";
            }
        }

        private void nosTxtBox_Enter(object sender, EventArgs e)
        {
            if (nosTxtBox.Text == "Number of Session")
            {
                nosTxtBox.ForeColor = Color.Black;
                nosTxtBox.Text = "";
            }
        }

        private void nosTxtBox_Leave(object sender, EventArgs e)
        {
            if (nosTxtBox.Text == "")
            {
                nosTxtBox.ForeColor = grey;
                nosTxtBox.Text = "Number of Session";
            }
        }

        private bool validate()
        {
            if (startDateTimePicker.Value > endDateTimePicker.Value)
            {
                MessageBox.Show("Start date cannot be later than the end date.");
                return false;
            }
            bool val = true;

            if (titleTxtBox.Text == "" || titleTxtBox.Text == "Title") val = false;
            if (categoryTxtBox.Text == "" || categoryTxtBox.Text == "Category") val = false;
            if (nosTxtBox.Text == "" || nosTxtBox.Text == "Number of Session") val = false;

            return val;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Fill out every fields.");
                return;
            }

            try
            {
                SqlCommand command = Utility.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO gym_classes (id, title, category, number_of_session, start_date, end_date) VALUES ('" + classIDLbl.Text + "', '" + titleTxtBox.Text + "', '" + categoryTxtBox.Text + "', '" + nosTxtBox.Text + "', '" + startDateTimePicker.Value.ToString("MM/dd/yyy") + "', '" + endDateTimePicker.Value.ToString("MM/dd/yyy") + "')";
                Utility.connection.Open();
                command.ExecuteNonQuery();
                Utility.connection.Close();

                class_id = Utility.generateStaticID(class_id, "Class-");
                classIDLbl.Text = class_id;
                titleTxtBox.ForeColor = grey;
                titleTxtBox.Text = "Title";
                categoryTxtBox.ForeColor = grey;
                categoryTxtBox.Text = "Category";
                nosTxtBox.ForeColor = grey;
                nosTxtBox.Text = "Number of Session";
                insertUpdate(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
