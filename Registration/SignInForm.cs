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
using System.Security.Cryptography;

namespace Registration
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();

            textBoxUserName.Text = "Enter User Name";
            textBoxUserName.ForeColor = Color.Gray;

            textBoxPassword.Text = "Enter Password";
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Enter User Name")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "Enter User Name";
                textBoxUserName.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Enter Password";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (IsUserNameExistsPasswordMatches() == false)
                return;            
        }

        private bool IsUserNameExistsPasswordMatches()
        {
            var hashPass = "";

            using (var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
                hashPass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            Database database = new Database();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand sqlCommand = new SqlCommand("select * from UsersReg where UserName = @UserName and Password = @hashPass", database.GetConnection());
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBoxUserName.Text;
            sqlCommand.Parameters.Add("@hashPass", SqlDbType.NVarChar).Value = hashPass;

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
            {
                MessageBox.Show("Invalid UserName or Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }                
        }
    }
}
