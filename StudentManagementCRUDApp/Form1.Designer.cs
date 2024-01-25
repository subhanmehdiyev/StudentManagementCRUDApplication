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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridViewStudent = new DataGridView();
            labelPeopleData = new Label();
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
            pictureBox_Profil_Image = new PictureBox();
            button_SelectImage = new Button();
            label_Profil_Image = new Label();
            openFileDialog_Profil_Image = new OpenFileDialog();
            button_RemoveImage = new Button();
            dateTimePicker_Birthdate = new DateTimePicker();
            radioButton_Male = new RadioButton();
            radioButton_Female = new RadioButton();
            button_Clear = new Button();
            Profil_Image = new DataGridViewImageColumn();
            ID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Profil_Image).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToOrderColumns = true;
            dataGridViewStudent.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Profil_Image, ID, NAME, Surname, DateOfBirth, Nationality, Gender, Address });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Firebrick;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewStudent.Location = new Point(12, 43);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowTemplate.Height = 29;
            dataGridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent.Size = new Size(1098, 188);
            dataGridViewStudent.TabIndex = 13;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            dataGridViewStudent.CellDoubleClick += dataGridViewStudent_CellDoubleClick;
            // 
            // labelPeopleData
            // 
            labelPeopleData.AutoSize = true;
            labelPeopleData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPeopleData.ForeColor = Color.FromArgb(192, 0, 0);
            labelPeopleData.Location = new Point(12, 13);
            labelPeopleData.Name = "labelPeopleData";
            labelPeopleData.Size = new Size(139, 24);
            labelPeopleData.TabIndex = 1;
            labelPeopleData.Text = "People's Data";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(291, 274);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(36, 22);
            label_ID.TabIndex = 2;
            label_ID.Text = "ID :";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.Location = new Point(260, 320);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(67, 22);
            label_Name.TabIndex = 2;
            label_Name.Text = "Name :";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(333, 320);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(168, 27);
            textBox_Name.TabIndex = 3;
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Surname.Location = new Point(234, 370);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(93, 22);
            label_Surname.TabIndex = 2;
            label_Surname.Text = "Surname :";
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(333, 370);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(168, 27);
            textBox_Surname.TabIndex = 4;
            // 
            // label_DateOfBirth
            // 
            label_DateOfBirth.AutoSize = true;
            label_DateOfBirth.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_DateOfBirth.Location = new Point(225, 418);
            label_DateOfBirth.Name = "label_DateOfBirth";
            label_DateOfBirth.Size = new Size(124, 22);
            label_DateOfBirth.TabIndex = 2;
            label_DateOfBirth.Text = "Date of Birth :";
            // 
            // label_Nationality
            // 
            label_Nationality.AutoSize = true;
            label_Nationality.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Nationality.Location = new Point(522, 274);
            label_Nationality.Name = "label_Nationality";
            label_Nationality.Size = new Size(108, 22);
            label_Nationality.TabIndex = 2;
            label_Nationality.Text = "Nationality :";
            // 
            // textBox_Nationality
            // 
            textBox_Nationality.Location = new Point(636, 273);
            textBox_Nationality.Name = "textBox_Nationality";
            textBox_Nationality.Size = new Size(168, 27);
            textBox_Nationality.TabIndex = 6;
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Gender.Location = new Point(551, 320);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(79, 22);
            label_Gender.TabIndex = 2;
            label_Gender.Text = "Gender :";
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Address.Location = new Point(543, 371);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(87, 22);
            label_Address.TabIndex = 2;
            label_Address.Text = "Address :";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(636, 370);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(168, 72);
            textBox_Address.TabIndex = 9;
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Add.Location = new Point(862, 266);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(248, 39);
            button_Add.TabIndex = 10;
            button_Add.Text = "Add";
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
            button_Delete.Location = new Point(862, 358);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(248, 39);
            button_Delete.TabIndex = 12;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Update
            // 
            button_Update.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_Update.Location = new Point(862, 312);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(248, 39);
            button_Update.TabIndex = 11;
            button_Update.Text = "Update";
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
            textBox_ID.Location = new Point(333, 273);
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
            // pictureBox_Profil_Image
            // 
            pictureBox_Profil_Image.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_Profil_Image.Location = new Point(19, 294);
            pictureBox_Profil_Image.Name = "pictureBox_Profil_Image";
            pictureBox_Profil_Image.Size = new Size(161, 111);
            pictureBox_Profil_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Profil_Image.TabIndex = 15;
            pictureBox_Profil_Image.TabStop = false;
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
            // label_Profil_Image
            // 
            label_Profil_Image.AutoSize = true;
            label_Profil_Image.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_Profil_Image.Location = new Point(47, 266);
            label_Profil_Image.Name = "label_Profil_Image";
            label_Profil_Image.Size = new Size(110, 22);
            label_Profil_Image.TabIndex = 2;
            label_Profil_Image.Text = "Profil Image";
            // 
            // openFileDialog_Profil_Image
            // 
            openFileDialog_Profil_Image.FileName = "openFileDialog1";
            // 
            // button_RemoveImage
            // 
            button_RemoveImage.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_RemoveImage.Location = new Point(99, 411);
            button_RemoveImage.Name = "button_RemoveImage";
            button_RemoveImage.Size = new Size(81, 36);
            button_RemoveImage.TabIndex = 1;
            button_RemoveImage.Text = "Delete";
            button_RemoveImage.UseVisualStyleBackColor = true;
            button_RemoveImage.Click += button_RemoveImage_Click;
            // 
            // dateTimePicker_Birthdate
            // 
            dateTimePicker_Birthdate.Location = new Point(355, 415);
            dateTimePicker_Birthdate.Name = "dateTimePicker_Birthdate";
            dateTimePicker_Birthdate.Size = new Size(250, 27);
            dateTimePicker_Birthdate.TabIndex = 5;
            // 
            // radioButton_Male
            // 
            radioButton_Male.AutoSize = true;
            radioButton_Male.Location = new Point(649, 321);
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
            radioButton_Female.Location = new Point(718, 321);
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
            button_Clear.Location = new Point(862, 403);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(248, 39);
            button_Clear.TabIndex = 13;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // Profil_Image
            // 
            Profil_Image.HeaderText = "Profil Image";
            Profil_Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Profil_Image.MinimumWidth = 6;
            Profil_Image.Name = "Profil_Image";
            Profil_Image.Width = 125;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Firebrick;
            ID.DefaultCellStyle = dataGridViewCellStyle1;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NAME
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Firebrick;
            NAME.DefaultCellStyle = dataGridViewCellStyle2;
            NAME.HeaderText = "Name";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 125;
            // 
            // Surname
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Firebrick;
            Surname.DefaultCellStyle = dataGridViewCellStyle3;
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // DateOfBirth
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Firebrick;
            DateOfBirth.DefaultCellStyle = dataGridViewCellStyle4;
            DateOfBirth.HeaderText = "Date of Birth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 125;
            // 
            // Nationality
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Firebrick;
            Nationality.DefaultCellStyle = dataGridViewCellStyle5;
            Nationality.HeaderText = "Nationality";
            Nationality.MinimumWidth = 6;
            Nationality.Name = "Nationality";
            Nationality.Width = 125;
            // 
            // Gender
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Firebrick;
            Gender.DefaultCellStyle = dataGridViewCellStyle6;
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // Address
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Firebrick;
            Address.DefaultCellStyle = dataGridViewCellStyle7;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 170;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 463);
            Controls.Add(button_Clear);
            Controls.Add(radioButton_Female);
            Controls.Add(radioButton_Male);
            Controls.Add(dateTimePicker_Birthdate);
            Controls.Add(button_RemoveImage);
            Controls.Add(button_SelectImage);
            Controls.Add(pictureBox_Profil_Image);
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
            Controls.Add(label_Profil_Image);
            Controls.Add(label_ID);
            Controls.Add(labelPeopleData);
            Controls.Add(dataGridViewStudent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management CRUD App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Profil_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPeopleData;
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
        private PictureBox pictureBox_Profil_Image;
        private Button button_SelectImage;
        private Label label_Profil_Image;
        private OpenFileDialog openFileDialog_Profil_Image;
        private Button button_RemoveImage;
        private DateTimePicker dateTimePicker_Birthdate;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_Female;
        private Button button_Clear;
        private DataGridViewImageColumn Profil_Image;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
    }
}