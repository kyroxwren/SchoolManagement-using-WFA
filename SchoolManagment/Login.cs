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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=LebogangPC;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM UserDetails WHERE user_name = @Username AND password = @Password";
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");
                            this.Hide();

                            StudentManagement studentManagement = new StudentManagement();
                            studentManagement.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong...");
                    }
                }
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = showPassword.Checked ? '\0' : '•';
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTB.Clear();
            passwordTB.Clear();
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = showPassword.Checked ? '\0' : '•';
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
