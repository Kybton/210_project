using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _210_project.Utilities
{
    public static class Utility
    {

        //public static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minoa\OneDrive\Documents\201_project.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\210_project\210_project\201_project.mdf;Integrated Security=True");

        public static bool usernameAva(string username, string table)
        {
            string query = "SELECT * FROM [" + table + "] WHERE id = '" + username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static string GenerateUserID(string name, string table)
        {
            // removing all whitespaces from the user given string
            name = string.Concat(name.Where(c => !char.IsWhiteSpace(c))).ToLower();
            Random rand = new Random();
            string code = "#";

            for (int i = 0; i < 4; i++)
            {
                code += rand.Next(10);
            }

            string username = name + code;

            while (!usernameAva(username, "member"))
            {
                code = "#";
                for (int i = 0; i < 4; i++)
                {
                    code += rand.Next(10);
                }
                username = name + code;
            }
            
            return username;
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"|!#$%&/()=?»«@£§€{}.-;~`'<>_,";

            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public static bool hasNumber(string input)
        {
            string number = "1234567890";

            foreach (var item in number)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public static string HashPassword(string password)
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

        public static bool CheckPassword(string hashedPassword, string input)
        {
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(input, salt, 50000);
            byte[] hash = pbkdf2.GetBytes(20);

            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i]) return false;

            return true;
        }

        public static string generateStaticID(string last_id, string prefix, string padding = "D4")
        {
            // to store only numbers from the last id
            string id = "";

            for (int i = 0; i < last_id.Length; i++)
                if (char.IsDigit(last_id[i])) id += last_id[i];

            id = prefix + (int.Parse(id) + 1).ToString(padding);

            return id;
        }

        public static bool checkAge(DateTime large)
        {
            int lar = int.Parse(large.ToString("yyyyMMdd"));
            int sma = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            return ((lar - sma / 10000) < 12);
        }
    }
}