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
    public partial class StudentImage : Form
    {
        public Image Image{ get; set; }

        public StudentImage(Image image)
        {
            InitializeComponent();
            Image = image;
        }

        private void StudentImage_Load(object sender, EventArgs e)
        {
            pictureBox_Image.Image = Image;
        }
    }
}
