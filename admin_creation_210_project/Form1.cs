using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_creation_210_project
{
    public partial class createAdmin : Form
    {
        public createAdmin()
        {
            InitializeComponent();
        }
        private string generateStaticID(string last_id, string prefix, string padding = "D4")
        {
            // to store only numbers from the last id
            string id = "";

            for (int i = 0; i < last_id.Length; i++)
                if (char.IsDigit(last_id[i])) id += last_id[i];

            id = prefix + (int.Parse(id) + 1).ToString(padding);

            return id;
        }

        private string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 50000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minoa\OneDrive\Documents\201_project.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1 id FROM admin ORDER BY id DESC";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "id");

                if (ds.Tables["id"].Rows.Count > 0)
                {
                    string lastClassID = ds.Tables["id"].Rows[0][0].ToString();
                    adminIDLbl.Text = generateStaticID(lastClassID, "admin-");
                }
                else adminIDLbl.Text = "admin-0001";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fill password"); 
                return;
            }

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minoa\OneDrive\Documents\201_project.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [admin] (id, password) VALUES ('" + adminIDLbl.Text + "', '" + HashPassword(textBox1.Text) + "')";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Admin Created Successfully.");
                Form1_Load(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
