using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class a7FormMath : Form
    {
        public a7FormMath()
        {
            InitializeComponent();
        }

        private void btnmath1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textMath.Text, out a) == false)
            {
                MessageBox.Show("請輸入數字", "格式錯誤");
                textMath.Clear();
                textMath.Focus();
            }
            else
            {
                int x = a % 2;
                if (x == 0)
                {
                    labelresult.Text = "結果\n" + $"{a}  為偶數。";
                    textMath.Clear();
                    textMath.Focus();
                }
                else if (x != 0)
                    labelresult.Text = "結果\n" + $"{a}  為奇數。";
                textMath.Clear();
                textMath.Focus();

            }
        }  //奇數偶數


        int[] arr3(int LEN)  //建立arr3陣列的方法 (回傳長度)
        {
            Random ramnum = new Random();
            //陣列值1~LEN
            int[] result = new int[LEN]; //arr陣列長度[10]     
            for (int i = 1; i <= LEN; i++)
            {
                result[i - 1] = ramnum.Next(0, 999);

            }
            return result;
        }
        private void btnArr1_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(10); //arr3方法(長度回傳10)
            string newresult = "";
            string newresult2 = "";
            for (int i = 0; i < newarr.Length; i++)
            {
                newresult += $"{newarr[i]}、";
                int x = newarr[i] % 2;
                if (x != 0)
                {
                    newresult2 += newarr[i] + "、";
                }
            }
            labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n奇數有\n{newresult2.Substring(0, newresult2.Length - 1)}\n";
        }

        private void btnminmax_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(10);
            string newresult = "";


            for (int i = 0; i < newarr.Length; i++)  //最大最小
            {
                newresult += $"{newarr[i]}、";
            }
            var newmax = newarr.Max().ToString();
            var newmin = newarr.Min().ToString();
            labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n最大值\n{newmax}" + $"\n最小值\n{newmin}\n";
        }

        private void btnArr2_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(10);
            string newresult = "";
            string newresult2 = "";
            for (int i = 0; i < newarr.Length; i++)
            {
                newresult += $"{newarr[i]}、";
                int x = newarr[i] % 2;
                if (x == 0)
                {
                    newresult2 += newarr[i] + "、";
                }
            }
            labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n偶數有\n{newresult2.Substring(0, newresult2.Length - 1)}\n";

        }


        public string RamString() //亂數產生 字串
        {
            Random Rstring = new Random();
            int xx = Rstring.Next(1, 7);
            var str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var nextstring = new Random();
            string result = string.Empty;
            for (var i = 0; i < xx; i++)
            {
                result += str[nextstring.Next(0, str.Length)];
            }
            return result;
        }

        string resultstring = string.Empty;
        string[] newsarr = new string[10];

        private void button4_Click(object sender, EventArgs e)
        {
            string resultx = string.Empty;
            resultstring = string.Empty;
            labelresult.Text = string.Empty;
            for (int i = 0; i < 10; i++)
            {

                newsarr[i] = this.RamString();
                Thread.Sleep(30);
                resultstring += newsarr[i] + "，";
            }
            for (int i = 0; i < newsarr.Length - 1; i++)
            {
                if (newsarr[i].Length > newsarr[i + 1].Length)
                {
                    newsarr[i + 1] = newsarr[i];
                    resultx = newsarr[i];
                }
            }

            labelresult.Text = $"結果\n aRr[10]" + "{" + resultstring.Substring(0, resultstring.Length - 1) + "}\n" + "名字最長的人：" + resultx;
        }

        private void btnfindC_Click(object sender, EventArgs e)
        {
            int num = 0;
            resultstring = string.Empty;
            labelresult.Text = string.Empty;

            for (int i = 0; i < 10; i++)
            {

                newsarr[i] = this.RamString();
                Thread.Sleep(30);
                resultstring += newsarr[i] + "，";
                if (newsarr[i].IndexOf("C") != -1)
                    num++;

            }
            labelresult.Text = "結果\naRr[10]" + "{" + resultstring.Substring(0, resultstring.Length - 1) + "}\n" + "名字包含C的字串有 " + num + " 個";
        }

        private void btn1ox_Click(object sender, EventArgs e)
        {
            labelresult.Text = "結果\n";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if ((i == 0 || i == 9) || (j == 0 || j == 9))
                        labelresult.Text += "●";
                    else
                    { labelresult.Text += "○"; }

                }
                labelresult.Text += "\n";
            }
        }
        private void btn2ox_Click(object sender, EventArgs e)
        {
            labelresult.Text = "結果\n";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if ((i == 0 || i == 9) || (j == 0 || j == 9))
                        labelresult.Text += "○";
                    else
                    { labelresult.Text += "●"; }

                }
                labelresult.Text += "\n";
            }
        }

        private void btnOX_Click(object sender, EventArgs e)
        {
            labelresult.Text = "結果\n";
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {

                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                        {
                            labelresult.Text += "○";
                        }
                        else
                        {
                            labelresult.Text += "●";
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            labelresult.Text += "○";
                        }
                        else
                        {
                            labelresult.Text += "●";
                        }
                    }
                }
                labelresult.Text += "\n";
            }



        }


        bool swapcheck = false;
        int[] swaparr = new int[] { 000, 999 };
        private void btnswap_Click(object sender, EventArgs e)
        {
            int aa = swaparr[0];
            swaparr[0] = swaparr[1];
            swaparr[1] = aa;
            swapcheck = !swapcheck;
            labelresult.Text = $"結果\n再按一次切換位置\n[{swaparr[0]},{swaparr[1]}]";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(10);
            string newresult = "";
            for (int i = 0; i < newarr.Length; i++)
            {
                newresult += $"{newarr[i]}、";
            }
            labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n總合為：{newarr.Sum()}\n";

        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(10);
            string newresult = "";
            for (int i = 0; i < newarr.Length; i++)
            {
                newresult += $"{newarr[i]}、";
            }
            if (swapcheck)
            {
                labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n最大值：{newarr.Max()}\n";
                swapcheck = !swapcheck;
            }
            else
            {
                labelresult.Text = "結果\n" + "aRr[10]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"\n最小值：{newarr.Min()}\n";
                swapcheck = !swapcheck;
            }

        }
        Random lenran = new Random();
        private void btnLen_Click(object sender, EventArgs e)
        {
            int aa = lenran.Next(1, 10);
            int[] newarr = arr3(aa);
            string newresult = "";
            for (int i = 0; i < newarr.Length; i++)
            {
                newresult += $"{newarr[i]}、";
            }
            labelresult.Text = $"結果\naRr[X]" + "{" + newresult.Substring(0, newresult.Length - 1) + "}\n" + $"X={newarr.Length}\n";
        }

        private void btnBIG_Click(object sender, EventArgs e)
        {
            int[] BIG = new int[6];
            
            string newresult = "";
            for (int i = 0; i < BIG.Length; i++)
            {
                BIG[i] = lenran.Next(1, 50);
                for (int j=0;j<i;j++)
                {
                    
                    while (BIG[j] == BIG[i])
                    {
                        BIG[i] = lenran.Next(1, 50);
                        j = 0;
                    }
                }
                newresult += $"{BIG[i]}、";

            }

            
            labelresult.Text = $"本期大樂透中獎號碼：\n"  + newresult.Substring(0, newresult.Length - 1) + "\n祝您中獎!!!!!!!!!!!!!!";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labelresult.Text = string.Empty;
        }

        private void btndelta_Click(object sender, EventArgs e)
        {
            labelresult.Text = "結果\n";
            string result = string.Empty;
            int num ;
            
            if (int.TryParse(textINput.Text, out num) == false || (textINput.Text == string.Empty))
            {
                MessageBox.Show("請輸入數值", "錯誤");
                textINput.Clear();
                textINput.Focus();
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    
                    for (int k = num; k >= i+1; k--) 
                    {
                        result += "☆";
                    }
                    for (int j = 1; j <(i+1); j++)
                    {                        
                        result += "★";                       
                    }
                    for (int j = 2; j < (i + 1); j++)
                    {
                        result += "★";
                    }

                    result += "\n";
                    
                    
                }
                
            }
            labelresult.Text = result;

        }

        private void btn9981_Click(object sender, EventArgs e)
        {
            
            labelresult.Text = $"結果\n九九乘法表\n";
            
            for (int i=1;i<=9;i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string x = (i * j).ToString().Length==1?"  "+ (i * j).ToString() : (i * j).ToString();
                    labelresult.Text += $"{j}*{i}={x} | ";
                }
                labelresult.Text += "\n";
            }
        }
        
        private void btn2type_Click(object sender, EventArgs e) //todo 2進制
        {
            labelresult.Text = $"結果：\n{textINput.Text}的二進制：";
            int num;

            if (int.TryParse(textINput.Text, out num) == false || (textINput.Text == string.Empty))
            {
                MessageBox.Show("請輸入數值", "錯誤");
                textINput.Clear();
                textINput.Focus();
            }
            else
            {
                int x;//餘數
                List<int> result = new List<int>();
                while (num > 0)
                {
                    x = num % 2;
                    num = num / 2;
                    result.Add(x);
                }
                string resultx = string.Empty;
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    resultx += result[i].ToString();
                }
                labelresult.Text += resultx;
            }
        }

        private void btn8type_Click(object sender, EventArgs e)
        {
            labelresult.Text = $"結果：\n{textINput.Text}的八進制：";
            int num;

            if (int.TryParse(textINput.Text, out num) == false || (textINput.Text == string.Empty))
            {
                MessageBox.Show("請輸入數值", "錯誤");
                textINput.Clear();
                textINput.Focus();
            }
            else
            {                
                int x;//餘數
                List<int> result = new List<int>();
                while (num > 0)
                {
                    x = num % 8;
                    num = num / 8;
                    result.Add(x);
                }
                string resultx = string.Empty;
                for (int i = result.Count - 1; i >= 0; i--)
                {
                    resultx += result[i].ToString();
                }
                labelresult.Text += resultx;
            }
        }
    }
    }


