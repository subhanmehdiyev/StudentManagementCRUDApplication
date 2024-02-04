namespace StudentManagementCRUDApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewStudent = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student_Image = new DataGridViewImageColumn();
            Student_Name = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            label_StudentData = new Label();
            label_ID = new Label();
            label_Name = new Label();
            textBox_Name = new TextBox();
            label_Surname = new Label();
            textBox_Surname = new TextBox();
            label_DateOfBirth = new Label();
            label_Nationality = new Label();
            textBox_Nationality = new TextBox();
            label_Gender = new Label();
            label_Address = new Label();
            textBox_Address = new TextBox();
            button_Add = new Button();
            textBox_Search = new TextBox();
            button_Delete = new Button();
            button_Update = new Button();
            button_Search = new Button();
            textBox_ID = new TextBox();
            button_Refresh = new Button();
            pictureBox_Image = new PictureBox();
            button_SelectImage = new Button();
            label_Image = new Label();
            openFileDialog_Student_Image = new OpenFileDialog();
            button_DeleteImage = new Button();
            dateTimePicker_Birthdate = new DateTimePicker();
            radioButton_Male = new RadioButton();
            radioButton_Female = new RadioButton();
            button_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToOrderColumns = true;
            dataGridViewStudent.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { ID, Student_Image, Student_Name, Surname, Birthdate, Nationality, Gender, Address });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Firebrick;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewStudent.Location = new Point(19, 52);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowTemplate.Height = 29;
            dataGridViewStudent.ScrollBars = ScrollBars.None;
            dataGridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent.Size = new Size(1108, 188);
            dataGridViewStudent.TabIndex = 13;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            dataGridViewStudent.CellContentDoubleClick += dataGridViewStudent_CellContentDoubleClick;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Student_Image
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "System.Drawing.Bitmap";
            Student_Image.DefaultCellStyle = dataGridViewCellStyle1;
            Student_Image.HeaderText = "Image";
            Student_Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Student_Image.MinimumWidth = 6;
            Student_Image.Name = "Student_Image";
            Student_Image.Width = 125;
            // 
            // Student_Name
            // 
            Student_Name.HeaderText = "Name";
            Student_Name.MinimumWidth = 6;
            Student_Name.Name = "Student_Name";
            Student_Name.Width = 125;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // Birthdate
            // 
            Birthdate.HeaderText = "Birthdate";
            Birthdate.MinimumWidth = 6;
            Birthdate.Name = "Birthdate";
            Birthdate.Width = 125;
            // 
            // Nationality
            // 
            Nationality.HeaderText = "Nationality";
            Nationality.MinimumWidth = 6;
            Nationality.Name = "Nationality";
            Nationality.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 180;
            // 
            // label_StudentData
            // 
            label_StudentData.AutoSize = true;
            label_StudentData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_StudentData.ForeColor = Color.FromArgb(192, 0, 0);
            label_StudentData.Location = new Point(19, 13);
            label_StudentData.Name = "label_StudentData";
            label_StudentData.Size = new Size(149, 24);
            label_StudentData.TabIndex = 1;
            label_StudentData.Text = "Students' Data";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(307, 275);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 22);
            label_ID.TabIndex = 2;
            label_ID.Text = "ID :";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.Location = new Point(276, 321);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(67, 22);
            label_Name.TabIndex = 2;
            label_Name.Text = "Name :";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(349, 321);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(168, 27);
            textBox_Name.TabIndex = 3;
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Surname.Location = new Point(250, 371);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(93, 22);
            label_Surname.TabIndex = 2;
            label_Surname.Text = "Surname :";
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(349, 371);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(168, 27);
            textBox_Surname.TabIndex = 4;
            // 
            // label_DateOfBirth
            // 
            label_DateOfBirth.AutoSize = true;
            label_DateOfBirth.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_DateOfBirth.Location = new Point(241, 419);
            label_DateOfBirth.Name = "label_DateOfBirth";
            label_DateOfBirth.Size = new Size(124, 22);
            label_DateOfBirth.TabIndex = 2;
            label_DateOfBirth.Text = "Date of Birth :";
            // 
            // label_Nationality
            // 
            label_Nationality.AutoSize = true;
            label_Nationality.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nationality.Location = new Point(538, 275);
            label_Nationality.Name = "label_Nationality";
            label_Nationality.Size = new Size(108, 22);
            label_Nationality.TabIndex = 2;
            label_Nationality.Text = "Nationality :";
            // 
            // textBox_Nationality
            // 
            textBox_Nationality.Location = new Point(652, 274);
            textBox_Nationality.Name = "textBox_Nationality";
            textBox_Nationality.Size = new Size(168, 27);
            textBox_Nationality.TabIndex = 6;
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Gender.Location = new Point(567, 326);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(79, 22);
            label_Gender.TabIndex = 2;
            label_Gender.Text = "Gender :";
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Address.Location = new Point(559, 372);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(87, 22);
            label_Address.TabIndex = 2;
            label_Address.Text = "Address :";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(652, 371);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(168, 72);
            textBox_Address.TabIndex = 9;
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Add.Location = new Point(879, 267);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(248, 39);
            button_Add.TabIndex = 10;
            button_Add.Text = "Add Student";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(771, 10);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(125, 27);
            textBox_Search.TabIndex = 14;
            textBox_Search.Text = "Search by ID ";
            textBox_Search.Click += textBox_Search_Click;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // button_Delete
            // 
            button_Delete.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Delete.Location = new Point(879, 358);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(248, 39);
            button_Delete.TabIndex = 12;
            button_Delete.Text = "Delete Student";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Update
            // 
            button_Update.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Update.Location = new Point(879, 313);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(248, 39);
            button_Update.TabIndex = 11;
            button_Update.Text = "Update Student";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Search
            // 
            button_Search.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Search.Location = new Point(902, 8);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(94, 29);
            button_Search.TabIndex = 15;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(349, 274);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(168, 27);
            textBox_ID.TabIndex = 2;
            // 
            // button_Refresh
            // 
            button_Refresh.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Refresh.Location = new Point(1002, 8);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(94, 29);
            button_Refresh.TabIndex = 16;
            button_Refresh.Text = "Refresh";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // pictureBox_Image
            // 
            pictureBox_Image.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Image.Location = new Point(19, 294);
            pictureBox_Image.Name = "pictureBox_Image";
            pictureBox_Image.Size = new Size(161, 111);
            pictureBox_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Image.TabIndex = 15;
            pictureBox_Image.TabStop = false;
            pictureBox_Image.DoubleClick += pictureBox_Image_DoubleClick;
            // 
            // button_SelectImage
            // 
            button_SelectImage.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_SelectImage.Location = new Point(19, 411);
            button_SelectImage.Name = "button_SelectImage";
            button_SelectImage.Size = new Size(74, 36);
            button_SelectImage.TabIndex = 0;
            button_SelectImage.Text = "Select";
            button_SelectImage.UseVisualStyleBackColor = true;
            button_SelectImage.Click += button_SelectImage_Click;
            // 
            // label_Image
            // 
            label_Image.AutoSize = true;
            label_Image.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Image.Location = new Point(71, 266);
            label_Image.Name = "label_Image";
            label_Image.Size = new Size(60, 22);
            label_Image.TabIndex = 2;
            label_Image.Text = "Image";
            // 
            // openFileDialog_Student_Image
            // 
            openFileDialog_Student_Image.FileName = "openFileDialog1";
            // 
            // button_DeleteImage
            // 
            button_DeleteImage.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_DeleteImage.Location = new Point(99, 411);
            button_DeleteImage.Name = "button_DeleteImage";
            button_DeleteImage.Size = new Size(81, 36);
            button_DeleteImage.TabIndex = 1;
            button_DeleteImage.Text = "Delete";
            button_DeleteImage.UseVisualStyleBackColor = true;
            button_DeleteImage.Click += button_DeleteImage_Click;
            // 
            // dateTimePicker_Birthdate
            // 
            dateTimePicker_Birthdate.Location = new Point(371, 416);
            dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            dateTimePicker_Birthdate.Size = new Size(250, 27);
            dateTimePicker_Birthdate.TabIndex = 5;
            // 
            // radioButton_Male
            // 
            radioButton_Male.AutoSize = true;
            radioButton_Male.Location = new Point(652, 326);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(63, 24);
            radioButton_Male.TabIndex = 7;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            radioButton_Female.AutoSize = true;
            radioButton_Female.Location = new Point(742, 326);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(78, 24);
            radioButton_Female.TabIndex = 8;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            button_Clear.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Clear.Location = new Point(879, 403);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(248, 39);
            button_Clear.TabIndex = 13;
            button_Clear.Text = "Clear Input Data";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 463);
            Controls.Add(button_Clear);
            Controls.Add(radioButton_Female);
            Controls.Add(radioButton_Male);
            Controls.Add(dateTimePicker_Birthdate);
            Controls.Add(button_DeleteImage);
            Controls.Add(button_SelectImage);
            Controls.Add(pictureBox_Image);
            Controls.Add(button_Refresh);
            Controls.Add(button_Search);
            Controls.Add(textBox_Search);
            Controls.Add(button_Update);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(label_DateOfBirth);
            Controls.Add(textBox_Surname);
            Controls.Add(label_Surname);
            Controls.Add(textBox_Name);
            Controls.Add(label_Name);
            Controls.Add(textBox_Address);
            Controls.Add(label_Address);
            Controls.Add(textBox_ID);
            Controls.Add(label_Gender);
            Controls.Add(textBox_Nationality);
            Controls.Add(label_Nationality);
            Controls.Add(label_Image);
            Controls.Add(label_ID);
            Controls.Add(label_StudentData);
            Controls.Add(dataGridViewStudent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_StudentData;
        private Label label_ID;
        private Label label_Name;
        private TextBox textBox_Name;
        private Label label_Surname;
        private TextBox textBox_Surname;
        private Label label_DateOfBirth;
        private Label label_Nationality;
        private TextBox textBox_Nationality;
        private Label label_Gender;
        private Label label_Address;
        private TextBox textBox_Address;
        private Button button_Add;
        private TextBox textBox_Search;
        private Button button_Delete;
        private Button button_Update;
        private Button button_Search;
        private TextBox textBox_ID;
        private DataGridView dataGridViewStudent;
        private Button button_Refresh;
        private PictureBox pictureBox_Image;
        private Button button_SelectImage;
        private Label label_Image;
        private OpenFileDialog openFileDialog_Student_Image;
        private Button button_DeleteImage;
        private DateTimePicker dateTimePicker_Birthdate;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private Button button_Clear;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewImageColumn Student_Image;
        private DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
    }
}