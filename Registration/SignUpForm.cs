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
using System.Security.Cryptography;

namespace Registration
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            textBoxFirstName.Text = "Enter First Name";
            textBoxFirstName.ForeColor = Color.Gray;
            
            textBoxLastName.Text = "Enter Last Name";
            textBoxLastName.ForeColor = Color.Gray;

            textBoxEmail.Text = "Enter Email";
            textBoxEmail.ForeColor = Color.Gray;

            textBoxUserName.Text = "Enter User Name";
            textBoxUserName.ForeColor = Color.Gray;

            textBoxPassword.Text = "Enter Password";
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.UseSystemPasswordChar = false;

            textBoxConfirmPass.Text = "Enter Confirm Password";
            textBoxConfirmPass.ForeColor = Color.Gray;
            textBoxConfirmPass.UseSystemPasswordChar = false;
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

            if (IsUserNameExists())
                return;

            var hashPass = "";

            using (var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
                hashPass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

                Database database = new Database();

            SqlCommand sqlCommand = new SqlCommand("insert into UsersReg (FirstName, LastName, Email, UserName, Password) values" +
                "(@FirstName, @LastName, @Email, @UserName, @Password)", database.GetConnection());

            sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName.Text;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textBoxLastName.Text;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBoxEmail.Text;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBoxUserName.Text;
            sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = hashPass;//textBoxPassword.Text;

            database.OpenConnection();

            if (sqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("You have successfully registered!");
            else
                MessageBox.Show("Sorry, you haven't registered!");

            database.CloseConnection();
        }

        private bool IsEmailExists()
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

        private bool IsUserNameExists()
        {
            Database database = new Database();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand sqlCommand1 = new SqlCommand("select * from UsersReg where UserName = @UserName", database.GetConnection());
            sqlCommand1.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = textBoxUserName.Text;

            adapter.SelectCommand = sqlCommand1;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("UserName already exists, please enter another one.", "Warning!",
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

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void checkBoxConfPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConfPass.Checked)
                textBoxConfirmPass.UseSystemPasswordChar = false;
            else
                textBoxConfirmPass.UseSystemPasswordChar = true;
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Enter First Name")
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            }                
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                textBoxFirstName.Text = "Enter First Name";
                textBoxFirstName.ForeColor = Color.Gray;
            }                
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Enter Last Name")
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }                
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
            {
                textBoxLastName.Text = "Enter Last Name";
                textBoxLastName.ForeColor = Color.Gray;
            }                
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Enter Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Enter Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
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

        private void textBoxConfirmPass_Enter(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == "Enter Confirm Password")
            {
                textBoxConfirmPass.Text = "";
                textBoxConfirmPass.ForeColor = Color.Black;
                textBoxConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxConfirmPass_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmPass.Text == "")
            {
                textBoxConfirmPass.Text = "Enter Confirm Password";
                textBoxConfirmPass.ForeColor = Color.Black;
                textBoxConfirmPass.UseSystemPasswordChar = false;
            }
        }
    }
}
