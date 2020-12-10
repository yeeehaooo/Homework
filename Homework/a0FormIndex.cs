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

            {

            }
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

        private void btnGuess_Click(object sender, EventArgs e)
        {
            a4FormGuess myForm = new a4FormGuess();//建立實體
            btnpanel(myForm);
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            a5FormScreen myForm = new a5FormScreen();//建立實體
            myForm.Show();
        }

        private void bntStSH_Click(object sender, EventArgs e)
        {
            a6FormStudent myForm = new a6FormStudent();//建立實體
            btnpanel(myForm);
        }


        private void btnMathCal_Click(object sender, EventArgs e)
        {
            a7FormMath myForm = new a7FormMath();//建立實體
            btnpanel(myForm);
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            a8FormCalc1 myForm = new a8FormCalc1();//建立實體
            btnpanel(myForm);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnOXgame_Click(object sender, EventArgs e)
        {
            a9FormOOXX myForm = new a9FormOOXX() ;//建立實體
            btnpanel(myForm);
        }
        
        private void btnSING_Click(object sender, EventArgs e)
        {
            FormSignIn99 myForm = new FormSignIn99(this);
            btnpanel(myForm);
        }



        private void btnSING_TextChanged(object sender, EventArgs e)
        {
            if (btnSING.Text == "已登入")
            {
                foreach (Button control in splitContainer2.Panel1.Controls)  //todo  在同一個groupBox1底下 使用 control同時控制
                {
                    control.Enabled = true;
                }
            }
        }



        private void btnnote_Click(object sender, EventArgs e)
        {
            FormNote myForm = new FormNote();
            btnpanel(myForm);
        }

        private void btnalarm_Click(object sender, EventArgs e)
        {
            FormClock myForm = new FormClock();
            btnpanel(myForm);
        }

        private void btnpainter_Click(object sender, EventArgs e)
        {
            FormPainter myForm = new FormPainter();
            btnpanel(myForm);
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            FormPicture myForm = new FormPicture();
            btnpanel(myForm);
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1FormHello myForm = new a1FormHello();//建立實體
            btnpanel(myForm);
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a2FormLoan myForm = new a2FormLoan(); //建立實體
            btnpanel(myForm);
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a3FormPOS myForm = new a3FormPOS();//建立實體
            btnpanel(myForm);
        }

        private void guessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a4FormGuess myForm = new a4FormGuess();//建立實體
            btnpanel(myForm);
        }

        private void screenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a5FormScreen myForm = new a5FormScreen();//建立實體
            myForm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a6FormStudent myForm = new a6FormStudent();//建立實體
            btnpanel(myForm);
        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a7FormMath myForm = new a7FormMath();//建立實體
            btnpanel(myForm);
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a8FormCalc1 myForm = new a8FormCalc1();//建立實體
            btnpanel(myForm);
        }

        private void oOXXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a9FormOOXX myForm = new a9FormOOXX();//建立實體
            btnpanel(myForm);
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote myForm = new FormNote();
            btnpanel(myForm);
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClock myForm = new FormClock();
            btnpanel(myForm);
        }

        private void painterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPainter myForm = new FormPainter();
            btnpanel(myForm);
        }

        private void pictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPicture myForm = new FormPicture();
            btnpanel(myForm);
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
        }
    }
    

}
