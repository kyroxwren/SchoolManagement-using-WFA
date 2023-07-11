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
    public partial class TeacherManagement : Form
    {
        public TeacherManagement()
        {
            InitializeComponent();
            LoadTeacherData();
        }

        string connectionString = "Data Source=LebogangPC;Initial Catalog=SchoolManagementSystem;Integrated Security=True";

        private void LoadTeacherData(string id = null, string query = "SELECT * FROM TeacherDetails")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (id != null)
                    {
                        command.Parameters.AddWithValue("@teacher_id", id);
                    }

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    teacherDGV.DataSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id, contactNumber;

            try {
            if (!int.TryParse(idTB.Text, out id))
            {
                MessageBox.Show("Invalid teacher ID!");
                return;
            }

            if (!int.TryParse(contactTB.Text, out contactNumber))
            {
                MessageBox.Show("Invalid contact number!");
                return;
            }

            string fullName = fullnameTB.Text;
            string gender = maleRadio.Checked == true ? "Male" : "Female";
            string course = courseCB.SelectedItem.ToString();
            string department = departmentCB.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(fullnameTB.Text) || string.IsNullOrWhiteSpace(departmentCB.SelectedItem?.ToString()) || string.IsNullOrWhiteSpace(courseCB.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please enter all the required values!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TeacherDetails (teacher_id, fullname, gender, course, contact_number, department) VALUES (@id, @fullname, @gender, @course, @contact_number, @department)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@fullname", fullName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@course", course);
                    command.Parameters.AddWithValue("@contact_number", contactNumber);
                    command.Parameters.AddWithValue("@department", department);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            idTB.Clear();
            contactTB.Clear();
            fullnameTB.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            departmentCB.SelectedIndex = -1;
            courseCB.SelectedIndex = -1;

            MessageBox.Show("Teacher added successfully!");

            LoadTeacherData(id.ToString(), "SELECT * FROM TeacherDetails");
            }
            catch
            {
                MessageBox.Show("An error occurred...");
            }
        }

        private void teacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TeacherDetails WHERE teacher_id = @teacher_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teacher_id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher deleted successfully!");

                        LoadTeacherData();
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found!");
                    }
                }
            }

            idTB.Clear();
            contactTB.Clear();
            fullnameTB.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            departmentCB.SelectedIndex = -1;
            courseCB.SelectedIndex = -1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;
            string fullName = fullnameTB.Text;
            string contactNumber = contactTB.Text;
            string gender = maleRadio.Checked == true ? "Male" : "Female";
            string course = courseCB.SelectedItem.ToString();
            string department = departmentCB.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE TeacherDetails SET fullname = @fullname, gender = @gender, course = @course, contact_number = @contact_number, department = @department WHERE teacher_id = @teacher_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullname", fullName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@course", course);
                    command.Parameters.AddWithValue("@contact_number", contactNumber);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@teacher_id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher updated successfully!");

                        LoadTeacherData(id, "SELECT * FROM TeacherDetails WHERE teacher_id = @teacher_id");
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found!");
                    }
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string id = searchTB.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TeacherDetails WHERE teacher_id = @teacher_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@teacher_id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idTB.Text = reader["teacher_id"].ToString();
                        fullnameTB.Text = reader["fullname"].ToString();
                        contactTB.Text = reader["contact_number"].ToString();
                        courseCB.Text = reader["course"].ToString();
                        departmentCB.Text = reader["department"].ToString();
                        string gender = reader["gender"].ToString();
                        maleRadio.Checked = gender == "Male";
                        femaleRadio.Checked = gender == "Female";

                        LoadTeacherData(id, "SELECT * FROM TeacherDetails WHERE teacher_id = @teacher_id");
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found!");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTB.Clear();
            contactTB.Clear();
            fullnameTB.Clear();
            maleRadio.Checked = false;
            femaleRadio.Checked = false;
            departmentCB.SelectedIndex = -1;
            courseCB.SelectedIndex = -1;
            searchTB.Clear();

            LoadTeacherData();
        }

        private void TeacherManagement_Load(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManagement courseManagement = new CourseManagement();
            courseManagement.Show();
        }

        private void studentManagementBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
