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
    public partial class a4FormGuess : Form
    {
        public a4FormGuess()   //todo 終極密碼 完成
        {
            InitializeComponent();
        }
        Random R = new Random();
        int keyIn = 0;
        int min=1;
        int max=100;
        int number1 = 0;
        bool checknum;
        int x = 0;
        private void butGuess_Click(object sender, EventArgs e)
        {
            x += 1;
            checknum = true;
            labelresult.Text = "";  
            int a;

            if (int.TryParse(textInt.Text, out a) == false || textInt.Text == string.Empty)
            {
                MessageBox.Show($"請輸入數字{min}～{max}", "錯誤");
                textInt.Clear();
                textInt.Focus();
            }
            else
            {
                if (int.Parse(textInt.Text) < min || int.Parse(textInt.Text) > max)
                {
                    MessageBox.Show($"範圍{min}～{max}", "範圍");
                    textInt.Clear();
                    textInt.Focus();
                    checknum = !checknum;
                    labelresult.Text = $"範圍{ min}～{ max}";
                }
                if (int.Parse(textInt.Text) == min)
                {
                    MessageBox.Show($"請輸入{min+1}～{max}", "範圍");
                    textInt.Clear();
                    textInt.Focus();
                    checknum = !checknum;
                    labelresult.Text = $"範圍{ min}～{ max}";
                }
                else if (int.Parse(textInt.Text) == max)
                {
                    MessageBox.Show($"請輸入{min}～{max-1}", "範圍");
                    textInt.Clear();
                    textInt.Focus();
                    checknum = !checknum;
                    labelresult.Text = $"範圍{ min}～{ max}";
                }
                    if (checknum == true)
                {
                    if (int.Parse(textInt.Text) < number1)
                    {

                        labelresult.Text = $"範圍 {int.Parse(textInt.Text)} ~ {max}";
                        min = int.Parse(textInt.Text);
                        textInt.Clear();
                        textInt.Focus();

                    }
                    else if (int.Parse(textInt.Text) > number1)
                    {
                        labelresult.Text = $"範圍 {min} ~ {int.Parse(textInt.Text)}";
                        max = int.Parse(textInt.Text);
                        textInt.Clear();
                        textInt.Focus();

                    }
                    else if (int.Parse(textInt.Text) == number1)
                    {
                        labelresult.Text = $"恭喜答對!!!";
                        timerTest.Enabled = true;
                    }
                }
            }
        }

        private void a4FormGuess_Load(object sender, EventArgs e)
        {
             number1 = R.Next(0, 100);
            //label1.Text = number1.ToString();    //測試用，顯示答案
        }
        bool Flag = true;
        private void timerTest_Tick(object sender, EventArgs e)
        {
            
                labelresult.BackColor = Flag ? Color.Red : Color.Black;
                labelresult.ForeColor = Flag ? Color.Black : Color.White;
            label1.BackColor = Flag ? Color.Red : Color.Black;
            label1.ForeColor = Flag ? Color.Black : Color.White;
            Flag = !Flag;
            
        }

        private void btngiveup_Click(object sender, EventArgs e)
        {
            if (keyIn == number1)
                MessageBox.Show($"答案：{number1}，您已答對。","恭喜");
            else
                MessageBox.Show($"答案：{number1}\n嫩，猜了{x}次還猜不到!!","7414");
        }
    }
}
