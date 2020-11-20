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
    public partial class a1FormHello : Form
    {
        public a1FormHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string myname = textname.Text;
            string myEname = textEname.Text;
            string sex = textsex.Text;
            string star = textstar.Text;

            MessageBox.Show("Hello, 我是" + myname + "，\n我的英文名子是" + myEname + "，\n性別是"+sex + "，\n星座是"+star+"。\n很高興認識你!!","Hello");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string myname = textname.Text;
            string myEname = textEname.Text;
            string sex = textsex.Text;
            string star = textstar.Text;

            MessageBox.Show("Hello, 我是" + myname + "，\n我的英文名子是" + myEname + "，\n性別是" + sex + "，\n星座是" + star + "。\n很高興認識你!!","Hello");
        }
    }
}
