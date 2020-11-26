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
    public partial class a1FormHello : Form   //todo Hello完成
    {
        public a1FormHello()
        {
            InitializeComponent();
        }
        string myname ;
        string myEname ;
        string sex ;
        string star;
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            myname = textname.Text;
             myEname = textEname.Text;             
             star = textstar.Text;
            if (radiofemale.Checked)
                sex = radiofemale.Text;
            else
                sex = radiomale.Text;
            MessageBox.Show("Hello, 我是" + myname + "，\n我的英文名子是" + myEname + "，\n性別是"+sex + "，\n星座是"+star+"。\n很高興認識你!!","Hello");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            myname = textname.Text;
            myEname = textEname.Text;
            star = textstar.Text;
            if (radiofemale.Checked)
                sex = radiofemale.Text;
            else
                sex = radiomale.Text;
            MessageBox.Show("Hello, 我是" + myname + "，\n我的英文名子是" + myEname + "，\n性別是" + sex + "，\n星座是" + star + "。\n很高興認識你!!","Hello");
        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {
            if (radiomale.Checked)
                sex = radiomale.Text;
        }

        private void radiofemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radiofemale.Checked)
                sex = radiofemale.Text;
        }
    }
}
