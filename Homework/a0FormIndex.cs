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
    public partial class a0FormIndex : Form
    {
        
        public void btnpanel(Form myForm)  //todo 使用btnpanel方法共用Panel2設定
        {

            splitContainer2.Panel2.Controls.Clear();  // 清空PANEL2
            myForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(myForm);
            myForm.Show();
        }
        public a0FormIndex()
        {
            InitializeComponent();

        }
        //todo  splitcontainer使用
        //動態分隔線控件 > splitcontainer >orientation > 調整垂直或水平
        //啟動視窗最大化 > WindowState > Maximize
        //跑馬燈新增設定 timer，Enable = ture，Interval 預設 100(數字越大越跑馬燈快)
        //功能視窗預設在右下Panel 開啟，開啟前先設定清空panel，不然會開一堆重覆視窗。

        private void btnHello_Click(object sender, EventArgs e)
        {

            a1FormHello myForm = new a1FormHello();//建立實體
            btnpanel(myForm);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            a2FormLoan myForm = new a2FormLoan(); //建立實體
            btnpanel(myForm);

        }
        private void btnpos_Click(object sender, EventArgs e)
        {
            a3FormPOS myForm = new a3FormPOS();//建立實體
            btnpanel(myForm);
        }

        private void btnstudent1_Click(object sender, EventArgs e)
        {
            a4FormStudent1 myForm = new a4FormStudent1();//建立實體
            btnpanel(myForm);
        }

        private void btnStudent2_Click(object sender, EventArgs e)
        {
            a5FormStudent2 myForm = new a5FormStudent2();//建立實體
            btnpanel(myForm);
        }

        private void bntStSH_Click(object sender, EventArgs e)
        {
            a6FormStudent3 myForm = new a6FormStudent3();//建立實體
            btnpanel(myForm);
        }


        private void btnMathCal_Click(object sender, EventArgs e)
        {
            a7FormMath myForm = new a7FormMath();//建立實體
            btnpanel(myForm);
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            a8FormCalc myForm = new a8FormCalc();//建立實體
            btnpanel(myForm);
        }
    }
    

}
