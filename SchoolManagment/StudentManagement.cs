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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private const string connectionString = "Data Source=LebogangPC;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        private void LoadStudentData(string id = null, string query = "SELECT * FROM StudentDetails")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    if (id != null)
                    {
                        command.Parameters.AddWithValue("@student_id", id);
                    }

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    studentDGV.DataSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idTB.Text) || string.IsNullOrEmpty(fullnameTB.Text) || string.IsNullOrEmpty(courseCB.Text) ||
                    string.IsNullOrEmpty(addressTB.Text) || (!maleRadio.Checked && !femaleRadio.Checked))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                int studentId = int.Parse(idTB.Text), contactNumber = int.Parse(contactNumberTB.Text);

                string gender = maleRadio.Checked ? "Male" : "Female";

                string contactNumberText = contactNumberTB.Text;
                if (contactNumberText.Length != 10)
                {
                    MessageBox.Show("Contact Number should be 10 digits long.");
                    return;
                }

                string fullName = fullnameTB.Text;
                string address = addressTB.Text;
                string courseEnrolled = courseCB.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO StudentDetails (student_id, fullname, gender, course_enrolled, contact_number, address) VALUES (@student_id, @fullname, @gender, @course_enrolled, @contact_number, @address)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentId);
                        command.Parameters.AddWithValue("@fullname", fullName);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@course_enrolled", courseEnrolled);
                        command.Parameters.AddWithValue("@contact_number", contactNumber);
                        command.Parameters.AddWithValue("@address", address);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                idTB.Clear();
                contactNumberTB.Clear();
                fullnameTB.Clear();
                maleRadio.Checked = false;
                femaleRadio.Checked = false;
                addressTB.Clear();
                courseCB.SelectedIndex = -1;

                MessageBox.Show("Student added successfully!");

                LoadStudentData(studentId.ToString(), "SELECT * FROM StudentDetails");
            }
            catch
            {
                MessageBox.Show("An error occurred...");
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string studentId = searchTB.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM StudentDetails WHERE student_id = @student_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idTB.Text = reader["student_id"].ToString();
                        fullnameTB.Text = reader["fullname"].ToString();
                        contactNumberTB.Text = reader["contact_number"].ToString();
                        courseCB.Text = reader["course_enrolled"].ToString();
                        addressTB.Text = reader["address"].ToString();
                        string gender = reader["gender"].ToString();
                        maleRadio.Checked = gender == "Male";
                        femaleRadio.Checked = gender == "Female";


                        LoadStudentData(studentId, "SELECT * FROM StudentDetails WHERE student_id = @student_id");
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string studentId = idTB.Text;
            string fullName = fullnameTB.Text;
            string contactNumber = contactNumberTB.Text;
            string address = addressTB.Text;
            string gender = maleRadio.Checked == true ? "Male" : "Female";
            string courseEnrolled = courseCB.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE StudentDetails SET fullname = @fullname, gender = @gender, course_enrolled = @course_enrolled, contact_number = @contact_number, address = @address WHERE student_id = @student_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullname", fullName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@course_enrolled", courseEnrolled);
                    command.Parameters.AddWithValue("@contact_number", contactNumber);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@student_id", studentId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student updated successfully!");

                        LoadStudentData(studentId, "SELECT * FROM StudentDetails WHERE student_id = @student_id");
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string studentId = idTB.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM StudentDetails WHERE student_id = @student_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@student_id", studentId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student deleted successfully!");

                        LoadStudentData(studentId, "SELECT * FROM StudentDetails");
                    }
                    else
                    {
                        MessageBox.Show("Student not found!");
                    }
                }
            }

            idTB.Clear();
            contactNumberTB.Clear();
            fullnameTB.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            addressTB.Clear();
            courseCB.SelectedIndex = -1;
            searchTB.Clear();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTB.Clear();
            contactNumberTB.Clear();
            fullnameTB.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            addressTB.Clear();
            courseCB.SelectedIndex = -1;
            searchTB.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM StudentDetails", connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    studentDGV.DataSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
        }

        private void teacherManagmentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherManagement teacherManagement = new TeacherManagement();
            teacherManagement.Show();
        }

        private void courseManagmentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManagement courseManagement = new CourseManagement();
            courseManagement.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
