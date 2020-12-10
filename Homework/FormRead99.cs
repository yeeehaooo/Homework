using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormRead99 : Form
    {
        private FormSignIn99 a99;
            public FormRead99(FormSignIn99 formSignIn99)
        {
            InitializeComponent();
                a99 = formSignIn99;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            a99.checkBox1.Checked = true;
            Close();
        }

        private void FormRead99_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("使用條款.txt", Encoding.UTF8);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\使用條款範本.txt", FileMode.Create); //@"write.txt"
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("已下載至桌面","成功");
        }
    }
}
