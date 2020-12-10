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
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }



        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void FormNote_Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.InitialDirectory = @"C:\Users";
            ofd.Multiselect = true;
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            
            ofd.ShowDialog();

            string path = ofd.FileName;

           // list.Add(path);

            string fileName = Path.GetFileName(path);
            //将文件名赋值给listBox
           // listBox1.Items.Add(fileName);
            //判断路径是否为空
            if (path == "")
            {
                return;
            }
            //如果路径不为空
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //读到字节数组当中
                byte[] buffer = new byte[1024 * 1024 * 5];
                //调用读取的方法
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //开始解码，解码后赋值给textBox
                richTextBox1.Text = Encoding.UTF8.GetString(buffer, 0, r);
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\TEST.txt", FileMode.Create); //@"write.txt"
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(richTextBox1.Text);
            sw.Close();
            fs.Close();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
    }
}
