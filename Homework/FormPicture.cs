using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            //在flowLayoutPanel1找出控制元件
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls )
            {
                if (control is PictureBox) //控制元件PicBox
                {
                    control.Click += PictureClick;
                }
            }
        }

        private void PictureClick(object sender, EventArgs e)
        {
            //建立新表單開啟圖片
            Form form = new Form();
            form.BackgroundImage = ((PictureBox)sender).Image;
            form.BackgroundImageLayout = ImageLayout.Zoom;
            form.Show();
        }
    }
}
