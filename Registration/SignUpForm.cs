using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Registration
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                MessageBox.Show("Enter FirstName!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxLastName.Text == "")
            {
                MessageBox.Show("Enter LastName!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Enter Email!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Enter UserName!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxConfirmPass.Text == "")
            {
                MessageBox.Show("Enter Confirm Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxPassword.Text != textBoxConfirmPass.Text)
            {
                MessageBox.Show("Password and Confirm Paswword don't match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailExists())
                return;

            Database database = new Database();

            SqlCommand sqlCommand = new SqlCommand("insert into UsersReg (FirstName, LastName, Email, UserName, Password) values" +
                "(@FirstName, @LastName, @Email, @UserName, @Password)", database.GetConnection());

            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName.Text;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBoxLastName.Text;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBoxEmail.Text;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBoxUserName.Text;
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBoxPassword.Text;

            database.OpenConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("You have successfully registered!");
            else
                MessageBox.Show("Sorry, you haven't registered!");

            database.CloseConnection();
        }

        public bool IsEmailExists()
        {
            Database database = new Database();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand sqlCommand1 = new SqlCommand("select * from UsersReg where Email = @Email", database.GetConnection());
            sqlCommand1.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBoxEmail.Text;

            adapter.SelectCommand = sqlCommand1;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Email already exists, please enter another one.", "Warning!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        private void buttonHavingAccount_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.StartPosition = FormStartPosition.CenterScreen;
            signInForm.Show();           
        }
    }
}
