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
    public partial class FormSignIn99 : Form
    {
        private a0FormIndex a0f;

        public FormSignIn99(a0FormIndex a0FormIndex)
        {
            InitializeComponent();
            a0f = a0FormIndex;

        }
        private void FormSignIn99_Load(object sender, EventArgs e)
        {

            labelXXXX.Text = RamString();
            checkBox1.Enabled = false;
            mem.memberName = "張佑晨";
            mem.memberPWD = "張佑晨";

        }

        private void textXXXX_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (textXXXX.Text == labelXXXX.Text)
            //    btnSignin.Enabled = true;            
        }

        private void textXXXX_KeyUp(object sender, KeyEventArgs e)
        {
            if (textXXXX.Text == labelXXXX.Text)
                btnSignin.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelXXXX.Text = RamString();
            if (textXXXX.Text != labelXXXX.Text)
            {
                btnSignin.Enabled = false;
                textXXXX.Clear();
                textXXXX.Focus();
            }
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
        member mem = new member();
        private void btnADD_Click(object sender, EventArgs e)
        {
            mem.memberName = textuser.Text;
            mem.memberPWD = textpwd.Text;
            label3.Text = mem.memberName +"\n"+ mem.memberPWD;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (textuser.Text == mem.memberName && textpwd.Text == mem.memberPWD && labelXXXX.Text == textXXXX.Text && checkBox1.Checked ==true)
            {
                a0f.btnSING.Text = "已登入";
                a0f.label1.Text = $"您好：{mem.memberName}";
                a0f.btnSING.Enabled = false;
                Close();                
            }
            else 
            {
                
                textuser.Focus();
                textuser.Clear();
                textpwd.Clear();
                MessageBox.Show($"1.驗證碼錯誤。\n2.閱讀使用條款","登入失敗");

            }
            
                
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRead99 myForm = new FormRead99(this);
            myForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textuser.Text = mem.memberName;
            textpwd.Text = mem.memberPWD;
        }
    }
}
