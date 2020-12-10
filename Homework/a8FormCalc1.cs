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
    public partial class a8FormCalc1 : Form
    {
        public a8FormCalc1()
        {
            InitializeComponent();
        }

        private void numclick(object sender, EventArgs e)  //數字鍵
        {

            Button btnnum = (Button)sender;
            if (labelnum2.Text == string.Empty && labelsign.Text == string.Empty)
            {
                labelnum1.Text += btnnum.Text;
                labelresult.Text = labelnum1.Text;
            }
            else if (labelnum1.Text != string.Empty && labelsign.Text == string.Empty)
                labelnum1.Text += btnnum.Text;
            else if (labelnum1.Text != string.Empty && labelsign.Text != string.Empty)
            {
                labelresult.Text =string.Empty;
                labelnum2.Text += btnnum.Text;
               labelresult.Text += btnnum.Text;
            }
            
        }
        

        private void btncount(object sender, EventArgs e)  //計算
        {
            
            Button sender_btn = (Button)sender;
            labelresult.Text = string.Empty;
            string sign = sender_btn.Text;
            if (labelnum1.Text == string.Empty && labelnum2.Text == string.Empty)
            { }
            else if (labelnum2.Text == string.Empty)
            {
                labelsign.Text = string.Empty;

                Init_Btn();
                sender_btn.BackColor = Color.Red;
                labelsign.Text = sign;
            }

            else if (labelnum1.Text != string.Empty && labelnum2.Text != string.Empty)
            {
                labelresult.Text = string.Empty;
                string signx = labelsign.Text;
                labelresult.Text += labelnum2.Text;
                double num1 = double.Parse(labelnum1.Text);
                double num2 = double.Parse(labelnum2.Text);
                if (signx == "+")
                {
                    Init_Btn();
                    sender_btn.BackColor = Color.Red;
                    labelresult.Text = (num1 + num2).ToString();
                    labelnum1.Text = (num1 + num2).ToString();
                    labelnum2.Text = string.Empty;
                    labelsign.Text = sign;
                }
                if (signx == "-")
                {
                    Init_Btn();
                    sender_btn.BackColor = Color.Red;
                    labelresult.Text = (num1 - num2).ToString();
                    labelnum1.Text = (num1 - num2).ToString();
                    labelnum2.Text = string.Empty;
                    labelsign.Text = sign;
                }
                if (signx == "*")
                {
                    Init_Btn();
                    sender_btn.BackColor = Color.Red;
                    labelresult.Text = (num1 * num2).ToString();
                    labelnum1.Text = (num1 * num2).ToString();
                    labelnum2.Text = string.Empty;
                    labelsign.Text = sign;
                }
                if (signx == "/")
                {
                    Init_Btn();
                    sender_btn.BackColor = Color.Red;
                    labelresult.Text = (num1 / num2).ToString();
                    labelnum1.Text = (num1 / num2).ToString();
                    labelnum2.Text = string.Empty;
                    labelsign.Text = sign;
                }
            }
        }
        private void Init_Btn()  //todo 變色方法
        {
            btnchia.BackColor = Color.Transparent;
            btngen.BackColor = Color.Transparent;
            btnchen.BackColor = Color.Transparent;
            btntrue.BackColor = Color.Transparent;
            btnpercent.BackColor = Color.Transparent;
            btnpercent.BackColor = Color.Transparent;
            btnpow.BackColor = Color.Transparent;
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            double x = double.Parse(labelnum1.Text);
            if (labelnum2.Text == string.Empty )
            {
                labelnum1.Text = (x / 100).ToString();
                labelsign.Text = string.Empty;
                labelresult.Text = labelnum1.Text;
            }
            
            else if (labelnum2.Text != string.Empty)
            {
                string signx = labelsign.Text;
                double num1 = double.Parse(labelnum1.Text);
                double num2 = double.Parse(labelnum2.Text);
                if (signx == "+")
                {
                    Init_Btn();
                    labelresult.Text = ((num1 + num2) / 100).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "-")
                {
                    Init_Btn();
                    labelresult.Text = ((num1 - num2) / 100).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "*")
                {
                    Init_Btn();
                    labelresult.Text = ((num1 * num2) / 100).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "/")
                {
                    Init_Btn();
                    labelresult.Text = ((num1 / num2) / 100).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)  //C
        {
            Init_Btn();
            labelnum1.Text = string.Empty;
            labelnum2.Text = string.Empty;
            labelsign.Text = string.Empty;
            labelresult.Text = string.Empty;

        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            if (labelnum2.Text == string.Empty)
            {
                labelnum1.Text = Math.Pow(double.Parse(labelnum1.Text),2).ToString();
                labelsign.Text = string.Empty;
            }
            if (labelnum2.Text != string.Empty)
            {
                string signx = labelsign.Text;
                double num1 = double.Parse(labelnum1.Text);
                double num2 = double.Parse(labelnum2.Text);
                if (signx == "+")
                {
                    Init_Btn();
                    labelresult.Text = Math.Pow((num1 + num2),2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "-")
                {
                    Init_Btn();
                    labelresult.Text = Math.Pow((num1 - num2), 2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "*")
                {
                    Init_Btn();
                    labelresult.Text = Math.Pow((num1 * num2), 2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "/")
                {
                    Init_Btn();
                    labelresult.Text = Math.Pow((num1 / num2), 2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
            }
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            double num;
            if (labelnum1.Text == string.Empty || labelnum2.Text ==string.Empty)
            {
                
            } 
             else
            { 
            if (labelnum2.Text == string.Empty)
            {
                labelresult.Text = double.Parse(labelnum1.Text).ToString();
                labelnum1.Text = string.Empty;
                labelsign.Text = string.Empty;
            }
            if (labelnum2.Text != string.Empty)
            {
                string signx = labelsign.Text;
                double num1 = double.Parse(labelnum1.Text);
                double num2 = double.Parse(labelnum2.Text);
                if (signx == "+")
                {
                    Init_Btn();
                    labelresult.Text = (num1 + num2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "-")
                {
                    Init_Btn();
                    labelresult.Text = (num1 - num2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "*")
                {
                    Init_Btn();
                    labelresult.Text = (num1 * num2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
                if (signx == "/")
                {
                    Init_Btn();
                    labelresult.Text = (num1 / num2).ToString();
                    labelnum1.Text = string.Empty;
                    labelnum2.Text = string.Empty;
                    labelsign.Text = string.Empty;
                }
            }
            }
        }
    }
}
