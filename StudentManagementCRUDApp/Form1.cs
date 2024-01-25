using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementCRUDApp
{
    public partial class Form1 : Form
    {
        const string myDbPath = @"D:\StudentsDB";

        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllStudentDataInDataGridView();
        }

        private void ShowAllStudentDataInDataGridView()
        {
            var dbDirectory = new DirectoryInfo(myDbPath);

            foreach (FileInfo file in dbDirectory.EnumerateFiles())
            {
                string[] fileContent = File.ReadAllLines($@"{myDbPath}\{file.Name}");

                var student = new Student()
                {
                    ID = int.Parse(Path.GetFileNameWithoutExtension(file.FullName)),
                    ProfilImagePath = fileContent[0].Split(": ")[1].Trim(),
                    Name = fileContent[1].Split(":")[1].Trim(),
                    Surname = fileContent[2].Split(":")[1].Trim(),
                    DateOfBirth = DateOnly.Parse(fileContent[3].Split(":")[1].Trim()),
                    Nationality = fileContent[4].Split(":")[1].Trim(),
                    Gender = fileContent[5].Split(":")[1].Trim(),
                    Address = fileContent[6].Split(":")[1].Trim(),
                };

                students.Add(student);
            }

            foreach (var student in students)
            {
                AddStudentDataToDataGridView(student);
            }
        }

        private void AddStudentDataToDataGridView(Student student)
        {
            dataGridViewStudent.Rows.Add(Image.FromFile(student.ProfilImagePath), student.ID, student.Name,
                student.Surname, student.DateOfBirth, student.Nationality, student.Gender, student.Address);
        }

        private void button_SelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog_Profil_Image.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF";
            openFileDialog_Profil_Image.ShowDialog();
            pictureBox_Profil_Image.Image = Image.FromFile(openFileDialog_Profil_Image.FileName);
        }
        private void button_RemoveImage_Click(object sender, EventArgs e)
        {
            pictureBox_Profil_Image.Image = null;
        }

        private Student SetAndGetStudentData()
        {
            var student = new Student()
            {
                ID = int.Parse(textBox_ID.Text),
                Name = textBox_Name.Text,
                Surname = textBox_Surname.Text,
                DateOfBirth = DateOnly.Parse(dateTimePicker_Birthdate.Text.Split(" ")[0]),
                Nationality = textBox_Nationality.Text,
                Address = textBox_Address.Text
            };


            if (radioButton_Male.Checked)
            {
                student.Gender = radioButton_Male.Text;
            }
            else if (radioButton_Female.Checked)
            {
                student.Gender = radioButton_Female.Text;
            }
            else
            {
                MessageBox.Show("You must choose gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (pictureBox_Profil_Image.Image is null && radioButton_Male.Checked)
            {
                student.ProfilImagePath = @"C:\Users\User\Downloads\default_male.jpg";
            }
            else if (pictureBox_Profil_Image.Image is null && radioButton_Female.Checked)
            {
                student.ProfilImagePath = @"C:\Users\User\Downloads\default_female.jpg";
            }
            else
            {
                if (openFileDialog_Profil_Image.FileName.Contains('\\'))
                {
                    student.ProfilImagePath = openFileDialog_Profil_Image.FileName;
                }
                else
                {
                    student.ProfilImagePath = pictureBox_Profil_Image.ImageLocation;
                }
            }

            return student;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text is null)
            {
                MessageBox.Show("You must set ID.\nBe careful, Id must be unique.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var student = SetAndGetStudentData();

            AddStudentDataToDataGridView(student);
            dataGridViewStudent.Refresh();

            SaveStudentAllDataInFile(student);

            MessageBox.Show($"Student with id {student.ID} is added succesfully.", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearDataControlsForNewData();
        }

        private void SaveStudentAllDataInFile(Student student)
        {
            string fileContent = $"Profil image path: {student.ProfilImagePath}\n" + 
                                 $"Name: {student.Name}\n" +
                                 $"Surname: {student.Surname}\n" + 
                                 $"Birthdate: {student.DateOfBirth}\n" + 
                                 $"Nationality: {student.Nationality}\n" +
                                 $"Gender: {student.Gender}\n" +
                                 $"Address: {student.Address}\n";

            File.WriteAllText($@"{myDbPath}\{student.ID}.txt" , fileContent);
        }

        private void ClearDataControlsForNewData()
        {
            foreach (Control formMember in Controls)
            {
                if (formMember is PictureBox)
                {
                    pictureBox_Profil_Image.Image = null;
                }
                else if (formMember is RadioButton)
                {
                    radioButton_Male.Checked = false;
                    radioButton_Female.Checked = false;
                }
                else if (((formMember is System.Windows.Forms.TextBox) || (formMember is DateTimePicker)) && (formMember != textBox_Search))
                {
                    formMember.ResetText();
                }
            }
        }


        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudent.CurrentRow.Cells[0].Value is null)
            {
                MessageBox.Show("Chosen row is empty.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pictureBox_Profil_Image.Image = (Image)dataGridViewStudent.CurrentRow.Cells[0].Value;
                textBox_ID.Text = dataGridViewStudent.CurrentRow.Cells[1].Value.ToString();
                textBox_Name.Text = dataGridViewStudent.CurrentRow.Cells[2].Value.ToString();
                textBox_Surname.Text = dataGridViewStudent.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker_Birthdate.Text = dataGridViewStudent.CurrentRow.Cells[4].Value.ToString();
                textBox_Nationality.Text = dataGridViewStudent.CurrentRow.Cells[5].Value.ToString();
                textBox_Address.Text = dataGridViewStudent.CurrentRow.Cells[7].Value.ToString();

                if (dataGridViewStudent.CurrentRow.Cells[6].Value.ToString() == "Male")
                {
                    radioButton_Male.PerformClick();
                }
                else
                {
                    radioButton_Female.PerformClick();
                }
            }
        }

        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dbDirectory = new DirectoryInfo(myDbPath);
            string targetStudentID = dataGridViewStudent.CurrentRow.Cells[1].Value.ToString();
            Student student = null;

            foreach (FileInfo file in dbDirectory.EnumerateFiles())
            {
                if (Path.GetFileNameWithoutExtension(file.FullName) == targetStudentID)
                {
                    string[] fileContent = File.ReadAllLines($@"{myDbPath}\{file.Name}");

                    student = new Student()
                    {
                        ProfilImagePath = fileContent[0].Split(": ")[1].Trim()
                    };

                    break;
                }
            }

            ProfilImage profilImage = new ProfilImage(student.ProfilImagePath);
            profilImage.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            pictureBox_Profil_Image.ImageLocation = FindStudentForProfilImagePath().ProfilImagePath;

            dataGridViewStudent.Rows.Remove(dataGridViewStudent.CurrentRow);

            var student = SetAndGetStudentData();

            AddStudentDataToDataGridView(student);
            dataGridViewStudent.Refresh();

            File.Delete($@"{myDbPath}\{student.ID}.txt");

            SaveStudentAllDataInFile(student);

            ClearDataControlsForNewData();
        }

        private Student FindStudentForProfilImagePath()
        {
            var dbDirectory = new DirectoryInfo(myDbPath);
            Student student = null;

            foreach (FileInfo file in dbDirectory.EnumerateFiles())
            {
                if (Path.GetFileNameWithoutExtension(file.FullName) == textBox_ID.Text)
                {
                    string[] fileContent = File.ReadAllLines($@"{myDbPath}\{file.Name}");

                    student = new Student()
                    {
                        ProfilImagePath = fileContent[0].Split(": ")[1].Trim()
                    };

                    break;
                }
            }

            return student;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.Rows.Remove(dataGridViewStudent.CurrentRow);

            var student = SetAndGetStudentData();

            File.Delete($@"{myDbPath}\{student.ID}.txt");

            ClearDataControlsForNewData();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridViewStudent.Rows.Clear();

            var dbDirectory = new DirectoryInfo(myDbPath);

            foreach (FileInfo file in dbDirectory.EnumerateFiles())
            {
                file.Delete();
            }
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
            var dbDirectory = new DirectoryInfo(myDbPath);
            Student student = null;

            foreach (FileInfo file in dbDirectory.EnumerateFiles())
            {
                if (Path.GetFileNameWithoutExtension(file.FullName) == textBox_Search.Text)
                {
                    string[] fileContent = File.ReadAllLines($@"{myDbPath}\{file.Name}");

                    student = new Student()
                    {
                        ID = int.Parse(Path.GetFileNameWithoutExtension(file.FullName)),
                        ProfilImagePath = fileContent[0].Split(": ")[1].Trim(),
                        Name = fileContent[1].Split(":")[1].Trim(),
                        Surname = fileContent[2].Split(":")[1].Trim(),
                        DateOfBirth = DateOnly.Parse(fileContent[3].Split(":")[1].Trim()),
                        Nationality = fileContent[4].Split(":")[1].Trim(),
                        Gender = fileContent[5].Split(":")[1].Trim(),
                        Address = fileContent[6].Split(":")[1].Trim(),
                    };

                    break;
                }
            }

            dataGridViewStudent.Rows.Clear();
            AddStudentDataToDataGridView(student);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "Search by ID";
            dataGridViewStudent.Rows.Remove(dataGridViewStudent.CurrentRow);

            ShowAllStudentDataInDataGridView();
        }
    }
}