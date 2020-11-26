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
    public partial class a9FormOOXX : Form
    {
        public a9FormOOXX()
        {
            InitializeComponent();        
        }      //todo OX-GAME 完成
        void btnend() //獲勝結束  
        {
            foreach (Button control in groupBox1.Controls)  //todo  在同一個groupBox1底下 使用 control同時控制
            {
                control.Enabled = false;
            }
        }
        void btnreset() //平手結束
        {
            foreach (Button control in groupBox1.Controls)
            {
                    control.Text = string.Empty;
                    control.Enabled = true;
                    control.BackColor = Color.Transparent;
                count = 0;
                }
        }

        int count = 0;
        bool x33 =false;
        private void btn3x3(object sender, EventArgs e) //九宮格控制
        {
            Button btn3x3 = (Button)sender;
            count += 1;
                if (x33) // 按下時交換 SWAP
                {
                    btn3x3.Text = "※";
                buttonX.Text = "○";
                if (btn3x3.Text != "")
                    btn3x3.Enabled = false;
                else btn3x3.Enabled = true;
                }
                else
                {
                    btn3x3.Text = "○";
                buttonX.Text = "※";
                if (btn3x3.Text != "")
                    btn3x3.Enabled = false;
                else btn3x3.Enabled = true;
            }
                x33 = !x33;
            if (btn00.Text != "" && btn01.Text != "" && btn02.Text != "" && btn00.Text == btn01.Text && btn01.Text == btn02.Text) 
            {
                
                btn00.BackColor = Color.Red;
                btn01.BackColor = Color.Red;
                btn02.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn00.Text} 獲勝");
                btnend();
            }//橫排1獲勝
            else if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" && btn10.Text == btn11.Text && btn11.Text == btn12.Text) 
            {
                
                btn10.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn10.Text} 獲勝");
                btnend();
            }//橫排2獲勝
            else if (btn20.Text != "" && btn21.Text != "" && btn22.Text != "" && btn20.Text == btn21.Text && btn21.Text == btn22.Text)
            {
                
                btn20.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn20.Text} 獲勝");
                btnend();

            }//橫排3獲勝
            else if (btn00.Text != "" && btn10.Text != "" && btn20.Text != "" && btn00.Text == btn10.Text && btn10.Text == btn20.Text)
            {
                
                btn00.BackColor = Color.Red;
                btn10.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn00.Text} 獲勝");
                btnend();

            }//直排1獲勝
            else if (btn01.Text != "" && btn11.Text != "" && btn21.Text != "" && btn01.Text == btn11.Text && btn11.Text == btn21.Text)
            {
                
                btn01.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn21.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn01.Text} 獲勝");
                btnend();

            }//直排2獲勝
            else if (btn02.Text != "" && btn12.Text != "" && btn22.Text != "" && btn02.Text == btn12.Text && btn12.Text == btn22.Text)
            {
                
                btn02.BackColor = Color.Red;
                btn12.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn02.Text} 獲勝");
                btnend();

            }//直排3獲勝
            else if (btn00.Text != "" && btn11.Text != "" && btn22.Text != "" && btn00.Text == btn11.Text && btn11.Text == btn22.Text)
            {
                
                btn00.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn22.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn00.Text} 獲勝");
                btnend();

            }//  左斜獲勝
            else if (btn02.Text != "" && btn11.Text != "" && btn20.Text != "" && btn02.Text == btn11.Text && btn11.Text == btn20.Text)
            {
                btn02.BackColor = Color.Red;
                btn11.BackColor = Color.Red;
                btn20.BackColor = Color.Red;
                MessageBox.Show($"玩家 {btn02.Text} 獲勝");
                btnend();

            }//  右斜獲勝
            else if (count ==9)
            {
                MessageBox.Show("平手!");
                btnreset();
            }//平手
        }

        private void button1_Click(object sender, EventArgs e) //再來一次
        {
            btnreset();
        }
    }
}

