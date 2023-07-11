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
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent();
            LoadCourseData();
        }

        private const string courseConnectionString = "Data Source=LebogangPC;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        private void LoadCourseData(string id = null, string query = "SELECT * FROM CourseDetails")
        {
            using (SqlConnection connection = new SqlConnection(courseConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (id != null)
                    {
                        command.Parameters.AddWithValue("@course_id", id);
                    }
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    courseDGV.DataSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
        }

        private void courseAddBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(courseIdTB.Text);
            string courseName = coursenameCB.SelectedItem.ToString();
            string category = categoryCB.SelectedItem.ToString();
            string description = descriptionTB.Text;

            if (string.IsNullOrEmpty(courseIdTB.Text) || coursenameCB.SelectedItem == null || categoryCB.SelectedItem == null)
            {
                MessageBox.Show("Please enter all required values!");
                return;
            }


            using (SqlConnection connection = new SqlConnection(courseConnectionString))
            {
                string query = "INSERT INTO CourseDetails (course_id, course_name, category, description) VALUES (@id, @coursename, @catergory, @description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@coursename", courseName);
                    command.Parameters.AddWithValue("@catergory", category);
                    command.Parameters.AddWithValue("@description", description);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            courseIdTB.Clear();
            coursenameCB.SelectedIndex = -1;
            categoryCB.SelectedIndex = -1;

            MessageBox.Show("Course added successfully!");

            LoadCourseData(id.ToString(), "SELECT * FROM CourseDetails");
        }

        private void courseSearchBtn_Click(object sender, EventArgs e)
        {
            string id = courseSearchTB.Text;

            using (SqlConnection connection = new SqlConnection(courseConnectionString))
            {
                string query = "SELECT * FROM CourseDetails WHERE course_id = @course_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        courseIdTB.Text = reader["course_id"].ToString();
                        coursenameCB.Text = reader["course_name"].ToString();
                        categoryCB.Text = reader["category"].ToString();
                        descriptionTB.Text = reader["description"].ToString();

                        LoadCourseData(id, "SELECT * FROM CourseDetails WHERE course_id = @course_id");
                    }
                    else
                    {
                        MessageBox.Show("Course not found!");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void courseEditBtn_Click(object sender, EventArgs e)
        {
            string id = courseIdTB.Text;
            string courseName = coursenameCB.SelectedItem.ToString();
            string category = categoryCB.SelectedItem.ToString();
            string description = descriptionTB.Text;

            using (SqlConnection connection = new SqlConnection(courseConnectionString))
            {
                string query = "UPDATE CourseDetails SET course_name = @coursename, category = @category, description = @description WHERE course_id = @course_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@coursename", courseName);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@course_id", id);
                    command.Parameters.AddWithValue("@description", description);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course updated successfully!");

                        LoadCourseData(id, "SELECT * FROM CourseDetails WHERE course_id = @course_id");
                    }
                    else
                    {
                        MessageBox.Show("Course not found!");
                    }
                }
            }
        }

        private void courseDeleteBtn_Click(object sender, EventArgs e)
        {
            string id = courseIdTB.Text;

            using (SqlConnection connection = new SqlConnection(courseConnectionString))
            {
                string query = "DELETE FROM CourseDetails WHERE course_id = @course_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Course deleted successfully!");

                        LoadCourseData();
                    }
                    else
                    {
                        MessageBox.Show("Course not found!");
                    }
                }
            }
        }

        private void courseClearBtn_Click(object sender, EventArgs e)
        {
            courseIdTB.Clear();
            categoryCB.SelectedIndex = -1;
            coursenameCB.SelectedIndex = -1;
            courseSearchTB.Clear();

            LoadCourseData();
        }

        private void studentManagementBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Show();
        }

        private void coursManagentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManagement courseManagement = new CourseManagement();
            courseManagement.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {

        }

        private void courseExitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
