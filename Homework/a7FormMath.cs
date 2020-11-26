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
                    MessageBox.Show($"{a}  為偶數。", "結果");
                    textMath.Clear();
                    textMath.Focus();
                }                    
                else if (x  != 0)
                    MessageBox.Show($"{a}  為奇數。","結果");
                textMath.Clear();
                textMath.Focus();
            }   
           
            
        }  //奇數偶數


        int[] arr3(int LEN)  //建立arr3陣列的方法 (回傳長度)
        {
            //陣列值1~LEN
            int[] result = new int[LEN]; //arr陣列長度[10]     顯示arr[0~9] =1~10
            for (int i = 1; i <= LEN; i++)
            {
                result[i-1] = i ;

            }
            return result;
        }
        private void btnArr1_Click(object sender, EventArgs e)
        {
            int[] newarr = arr3(100); //arr3方法(長度回傳100)
            string newresult = "";
            string newresult2= "";
            for (int i = 1; i <= newarr.Length; i++)
            {
                int x = i % 2;
                if (x == 0)
                {
                    newresult +=  "，"+i;
                }
            }
            MessageBox.Show($"\n1~100的偶數有" +newresult,"結果");
            for (int i = 1; i <= newarr.Length; i++)
            {
                int x = i % 2;
                if (x != 0)
                {
                    newresult2 += "，"+i ;
                }
            }
            MessageBox.Show($"\n1~100的奇數有" + newresult2,"結果");
        }

        private void btnminmax_Click(object sender, EventArgs e)
        {
            //int[] newarr = arr3(10){ 77,55,66,,44,33,22,11,88,99,1}
            //newarr.Min;
        }
    }
    }

