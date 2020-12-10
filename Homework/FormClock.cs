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
    public partial class FormClock : Form
    {
        public FormClock()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            if (checkAlarm.Checked && xx == dateTimePicker1.Value.ToString())
            {
                MessageBox.Show("起床~~~~~~~~");                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dateTimePicker2.MinDate = DateTime.Now;
        }
        string xx;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已設定","提醒");
            xx = dateTimePicker2.Value.ToString();
        }
    }
}
