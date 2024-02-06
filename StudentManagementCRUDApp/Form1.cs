using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Drawing.Configuration;
using System.Reflection.PortableExecutable;
using StudentManagementCRUDApp.Properties;

namespace StudentManagementCRUDApp
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=StudentsDB;Integrated Security=True;Trust Server Certificate=True";

        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllDataInDatagridview();
        }

        private void ShowAllDataInDatagridview()
        {
            students = GetAllStudentsDataFromDatabase();

            foreach (Student student in students)
            {
                AddStudentToDatagridview(student);
            }
        }

        private void AddStudentToDatagridview(Student student)
        {
            dataGridViewStudent.Rows.Add(student.ID, student.Image, student.Name, student.Surname, student.Birthdate,
                                         student.Nationality, student.Gender, student.Address);
        }

        private List<Student> GetAllStudentsDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Students", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader is not null)
                        {
                            while (reader.Read())
                            {
                                var student = new Student()
                                {
                                    ID = reader.GetInt32("Student_ID"),
                                    Image = Image.FromStream(reader.GetStream("Student_ImageInByteArray")),
                                    Name = reader.GetString("Student_Name"),
                                    Surname = reader.GetString("Student_Surname"),
                                    Birthdate = ToDateOnly(reader.GetDateTime("Student_Birthdate")),
                                    Nationality = reader.GetString("Student_Nationality"),
                                    Gender = reader.GetString("Student_Gender"),
                                    Address = reader.GetString("Student_Address")
                                };

                                students.Add(student);
                            }
                        }
                    }
                }
            }

            return students;
        }

        private DateOnly ToDateOnly(DateTime dateTime)
        {
            return DateOnly.Parse(dateTime.ToString().Split(' ')[0]);
        }

        private void button_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog_Student_Image.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF";
            DialogResult dialogResult = openFileDialog_Student_Image.ShowDialog();

            if (dialogResult is DialogResult.OK)
                pictureBox_Image.Image = new Bitmap(openFileDialog_Student_Image.FileName);
        }

        private void button_DeleteImage_Click(object sender, EventArgs e)
        {
            pictureBox_Image.Image = null;
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            CheckIDValidation();

            Student student = GetStudentDataFromUser();

            SaveStudentDataInDatabase(student);

            student.Image = pictureBox_Image.Image;
            AddStudentToDatagridview(student);

            ClearDataControlsForNewData();
        }

        private void CheckIDValidation()
        {
            if (textBox_ID.Text is null)
                MessageBox.Show("You must set ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string otherStudentID = null;

            foreach (DataGridViewRow row in dataGridViewStudent.Rows)
            {
                otherStudentID = row.Cells["ID"].Value.ToString();

                if (textBox_ID.Text == otherStudentID)
                {
                    MessageBox.Show("This ID is used by other student.\nChoose another one.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        private Student GetStudentDataFromUser()
        {
            var student = new Student()
            {
                ID = int.Parse(textBox_ID.Text),
                imageInByteArray = DefineImageInBytes(),
                Name = textBox_Name.Text,
                Surname = textBox_Surname.Text,
                Birthdate = ToDateOnly(dateTimePicker_Birthdate.Value),
                Nationality = textBox_Nationality.Text,
                Gender = DefineGender(),
                Address = textBox_Address.Text
            };

            return student;
        }

        private byte[] DefineImageInBytes()
        {
            if (pictureBox_Image.Image is null & radioButton_Male.Checked)
            {
                pictureBox_Image.Image = Resources.default_male;
            }
            else if (pictureBox_Image.Image is null & radioButton_Female.Checked)
            {
                pictureBox_Image.Image = Resources.default_female;
            }

            MemoryStream memoryStream = new MemoryStream();
            pictureBox_Image.Image.Save(memoryStream, pictureBox_Image.Image.RawFormat);

            return memoryStream.GetBuffer();
        }

        private string DefineGender()
        {
            string gender = null;

            while (gender is null)
            {
                if (radioButton_Male.Checked)
                {
                    gender = radioButton_Male.Text;
                }
                else if (radioButton_Female.Checked)
                {
                    gender = radioButton_Female.Text;
                }
                else if (radioButton_PreferNotToSay.Checked)
                {
                    gender = radioButton_PreferNotToSay.Text;
                }

                if (gender is null)
                    MessageBox.Show("You must choose gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return gender;
        }

        private void SaveStudentDataInDatabase(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Students (Student_ID, Student_ImageInByteArray, Student_Name, 
                                                              Student_Surname, Student_Birthdate, Student_Nationality, 
                                                              Student_Gender, Student_Address)
                                        VALUES (@Id,@ImageInByteArray,@Name,
                                                @Surname,@Birthdate,@Nationality,
                                                @Gender,@Address)";

                command.Parameters.AddRange(new SqlParameter[] {
                    new SqlParameter("@Id", student.ID),
                    new SqlParameter("@ImageInByteArray", student.imageInByteArray),
                    new SqlParameter("@Name", student.Name),
                    new SqlParameter("@Surname", student.Surname),
                    new SqlParameter("@Birthdate", student.Birthdate),
                    new SqlParameter("@Nationality", student.Nationality),
                    new SqlParameter("@Gender", student.Gender),
                    new SqlParameter("@Address", student.Address)
                });

                command.ExecuteNonQuery();

                MessageBox.Show($"Student with id {student.ID} is saved succesfully.", "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearDataControlsForNewData()
        {
            foreach (Control formMember in Controls)
            {
                if (formMember is PictureBox)
                {
                    pictureBox_Image.Image = null;
                }
                else if (formMember is RadioButton)
                {
                    radioButton_Male.Checked = false;
                    radioButton_Female.Checked = false;
                    radioButton_PreferNotToSay.Checked = false;
                }
                else if (AreDataControlsTextboxOrDatetimepicker(formMember))
                {
                    formMember.ResetText();
                }
            }
        }

        private bool AreDataControlsTextboxOrDatetimepicker(Control formMember)
        {
            return ((formMember is System.Windows.Forms.TextBox) || (formMember is DateTimePicker))
                     && (formMember != textBox_Search);
        }


        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridViewStudent.CurrentRow.Cells["ID"].Value.ToString();
            pictureBox_Image.Image = (Image)dataGridViewStudent.CurrentRow.Cells["Student_Image"].Value;
            textBox_Name.Text = dataGridViewStudent.CurrentRow.Cells["Student_Name"].Value.ToString();
            textBox_Surname.Text = dataGridViewStudent.CurrentRow.Cells["Surname"].Value.ToString();
            dateTimePicker_Birthdate.Text = dataGridViewStudent.CurrentRow.Cells["Birthdate"].Value.ToString();
            textBox_Nationality.Text = dataGridViewStudent.CurrentRow.Cells["Nationality"].Value.ToString();
            textBox_Address.Text = dataGridViewStudent.CurrentRow.Cells["Address"].Value.ToString();

            string gender = dataGridViewStudent.CurrentRow.Cells["Gender"].Value.ToString();

            if (gender is "Male")
            {
                radioButton_Male.PerformClick();
            }
            else if (gender is "Female")
            {
                radioButton_Female.PerformClick();
            }
            else
            {
                radioButton_PreferNotToSay.PerformClick();
            }
        }

        private void dataGridViewStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Image image = (Image)dataGridViewStudent.CurrentRow.Cells["Student_Image"].Value;

            ShowImageInBigSizes(image);
        }

        private void pictureBox_Image_DoubleClick(object sender, EventArgs e)
        {
            Image image = (Image)dataGridViewStudent.CurrentRow.Cells["Student_Image"].Value;

            ShowImageInBigSizes(image);
        }

        private void ShowImageInBigSizes(Image image)
        {
            StudentImage studentImageForm = new StudentImage(image);
            studentImageForm.ShowDialog();
        }



        private void button_Update_Click(object sender, EventArgs e)
        {
            Student student = GetStudentDataFromUser();
            UpdateStudentInDatabase(student);

            UpdateStudentInDatagridview(student);

            ClearDataControlsForNewData();
        }

        private void UpdateStudentInDatabase(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"UPDATE Students
                                        SET Student_ImageInByteArray = @ImageInByteArray, Student_Name = @Name, 
                                            Student_Surname = @Surname, Student_Birthdate = @Birthdate, 
                                            Student_Nationality = @Nationality, Student_Gender = @Gender, 
                                            Student_Address = @Address
                                        WHERE Student_ID = @Id";

                command.Parameters.AddRange(new SqlParameter[] {
                    new SqlParameter("@Id", student.ID),
                    new SqlParameter("@ImageInByteArray", student.imageInByteArray),
                    new SqlParameter("@Name", student.Name),
                    new SqlParameter("@Surname", student.Surname),
                    new SqlParameter("@Birthdate", student.Birthdate),
                    new SqlParameter("@Nationality", student.Nationality),
                    new SqlParameter("@Gender", student.Gender),
                    new SqlParameter("@Address", student.Address)
                });

                command.ExecuteNonQuery();

                MessageBox.Show($"Student with id {student.ID} is updated succesfully.", "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStudentInDatagridview(Student student)
        {
            int rowIndex = dataGridViewStudent.Rows.IndexOf(dataGridViewStudent.CurrentRow);
            dataGridViewStudent.Rows.RemoveAt(rowIndex);

            student.Image = pictureBox_Image.Image;
            dataGridViewStudent.Rows.Insert(rowIndex, student.ID, student.Image, student.Name, student.Surname, student.Birthdate, 
                                                      student.Nationality, student.Gender, student.Address);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This student data will be removed.\nAre you sure to do this?",
                                                        "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult is DialogResult.OK)
            {
                var student = GetStudentDataFromUser();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @"DELETE FROM Students WHERE Student_ID = @targetStudentID";
                    command.Parameters.Add(new SqlParameter("@targetStudentID", student.ID));
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Student with id {student.ID} was removed succesfully.", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowAllDataInDatagridview();
                }
            }

            ClearDataControlsForNewData();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearDataControlsForNewData();
        }


        private void textBox_Search_Click(object sender, EventArgs e)
        {
            textBox_Search.ResetText();
        }
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            textBox_Search.Text.Remove(0);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string targetStudentID = textBox_Search.Text;
            Student student = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM Students WHERE Student_ID = @targetStudentID";
                command.Parameters.Add(new SqlParameter("@targetStudentID", targetStudentID));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader is not null)
                    {
                        if (reader.GetString("Student_ID") == targetStudentID)
                        {
                            student = new Student()
                            {
                                ID = reader.GetInt32("Student_ID"),
                                Image = Image.FromStream(reader.GetStream("Student_ImageInByteArray")),
                                Name = reader.GetString("Student_Name"),
                                Surname = reader.GetString("Student_Surname"),
                                Birthdate = ToDateOnly(reader.GetDateTime("Student_Birthdate")),
                                Nationality = reader.GetString("Student_Nationality"),
                                Gender = reader.GetString("Student_Gender"),
                                Address = reader.GetString("Student_Address")
                            };

                            ShowAllDataInDatagridview();
                        }
                        else
                        {
                            MessageBox.Show($"Student with id {student.ID} is not found.", "Notification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "Search by ID";

            ShowAllDataInDatagridview();
        }
    }
}