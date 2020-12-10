using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Homework
{
    public partial class FormPainter : Form
    {
        public Graphics graph1;
        public Pen pen1;
        public Point points;
        //public List points = new List();
        bool isMouseDown = false;               // 紀錄滑鼠是否按下
        
        
        public FormPainter()
        {
            InitializeComponent();
            graph1 = this.CreateGraphics();
            pen1 = new Pen(Color.Black,3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            pen1.Color = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen1.Width = trackBar1.Value;
        }

        private void FormPainter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPainter_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            points.X = e.X;
            points.Y = e.Y;
            //points.Add(new Point(e.X, e.Y)); // e.Location 另一種寫法
            // points.Add(e.Location);
            //graph1.DrawLine(pen1, points.X, points.Y, e.X, e.Y);

        }

        private void FormPainter_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                graph1.DrawLine(pen1, points.X, points.Y, e.X, e.Y);
                points.X = e.X;
                points.Y = e.Y;
                //points.Add(e.Location);
               //this.Invalidate(); // 在滑鼠移動的時候，不斷的即時更新畫面
            }
        }

        private void FormPainter_MouseUp(object sender, MouseEventArgs e)
        {
           // points.Add(new Point(-1, -1)); // 紀錄-1,-1在滑鼠軌跡點，表示滑鼠放開
            isMouseDown = false;
        }

        private void FormPainter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // points.Clear();    // 清空 滑鼠軌跡點
            //  this.Invalidate(); // 必須更新畫面
            //label1.Text = string.Concat(trackBar1.Value);
            
        }
    }
}
