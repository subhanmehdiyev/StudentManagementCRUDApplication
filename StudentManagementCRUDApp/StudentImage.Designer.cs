namespace StudentManagementCRUDApp
{
    partial class StudentImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Image
            // 
            pictureBox_Image.Dock = DockStyle.Fill;
            pictureBox_Image.Location = new Point(0, 0);
            pictureBox_Image.Name = "pictureBox_Image";
            pictureBox_Image.Size = new Size(741, 571);
            pictureBox_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Image.TabIndex = 0;
            pictureBox_Image.TabStop = false;
            // 
            // StudentImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 571);
            Controls.Add(pictureBox_Image);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Image";
            Load += StudentImage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_Image;
    }
}