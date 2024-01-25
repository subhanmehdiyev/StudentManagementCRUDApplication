using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementCRUDApp
{
    public partial class ProfilImage : Form
    {
        public string ImageFilePath { get; set; }

        public ProfilImage(string fileName)
        {
            InitializeComponent();
            ImageFilePath = fileName;
        }

        private void ProfilImage_Load(object sender, EventArgs e)
        {
            pictureBox_Image.Image = Image.FromFile(ImageFilePath);
        }
    }
}
