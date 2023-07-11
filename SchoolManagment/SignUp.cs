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

namespace SchoolManagment
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=LebogangPC;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string confirmPassword = confirmPasswordTB.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM UserDetails WHERE user_name = @Username";
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username is already taken.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred...");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO UserDetails (user_name, password) VALUES (@Username, @Password)";
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            this.Hide();
                            MessageBox.Show("Registration successful!");
                            StudentManagement studentManagement = new StudentManagement();
                            studentManagement.Show();

                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred...");
                    }

                }
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = showPassword.Checked ? '\0' : '•';
            confirmPasswordTB.PasswordChar = showPassword.Checked ? '\0' : '•';
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTB.Clear();
            passwordTB.Clear();
            confirmPasswordTB.Clear();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
