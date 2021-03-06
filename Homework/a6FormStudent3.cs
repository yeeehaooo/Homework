﻿using System;
using System.Collections;
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
    public partial class a6FormStudent3 : Form
    {
        public a6FormStudent3()
        {
            InitializeComponent();
        }

        //double ch1, eng1, mat1; //接 成績
        public void checknull() //成績格式CHECK
        {
            if (textname.Text == string.Empty)
            {
                MessageBox.Show("請輸入", "姓名");
                textname.Text = "";
                textname.Focus();
            }
            else if (textchinese.Text == string.Empty)
            {
                MessageBox.Show("請輸入數字", "國文成績");
                textchinese.Text = "";
                textchinese.Focus();
            }
            else if (textenglish.Text == string.Empty)
            {
                MessageBox.Show("請輸入數字", "英文成績");
                textenglish.Text = "";
                textenglish.Focus();
            }
            else if (textmath.Text == string.Empty)
            {
                MessageBox.Show("請輸入數字", "數學成績");
                textmath.Text = "";
                textmath.Focus();
            }
        }

        BindingList<a6StuCls> studentlist = new BindingList<a6StuCls>();

        private void StudentForm_Load(object sender, EventArgs e) //LISTBOX 
        {
            listsubject.Items.AddRange(new object[]
                           {
                    new SUBJECTListItem("國文"),
                    new SUBJECTListItem("英文"),
                    new SUBJECTListItem("數學")
                           });
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            //dataGridView1.DataSource = studentlist;
        }
        public class SUBJECTListItem   //LISTBOX
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public SUBJECTListItem(string name)
            {
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }
        private void btnkeyIN_Click(object sender, EventArgs e)//輸入成績
        {
            checknull();
            bool check = false;
            double schinese, smath, seng;
            if (double.TryParse(textchinese.Text, out schinese) == false)
            {
                MessageBox.Show("請輸入數字", "國文成績");
                textchinese.Text = "";
                textchinese.Focus();

            }  //輸入國文成績判斷格式
            else if (double.TryParse(textenglish.Text, out smath) == false)
            {
                MessageBox.Show("請輸入數字", "英文成績");
                textenglish.Text = "";
                textenglish.Focus();
            }  //輸入英文成績判斷格式
            else if (double.TryParse(textmath.Text, out seng) == false)
            {
                MessageBox.Show("請輸入數字", "數學成績");
                textmath.Text = "";
                textmath.Focus();
            }   //輸入數學成績判斷格式
            foreach (a6StuCls x in studentlist)
            {
                if (x.stuName == textname.Text)
                {
                    MessageBox.Show("重複輸入", "學生成績");
                    check = !check;
                    break;
                }
            }
            if (check == false)
            {
                checknull();
                a6StuCls student = new a6StuCls();
                student.stuName = textname.Text;
                student.stuChinese = double.Parse(textchinese.Text);
                student.stuMath = double.Parse(textmath.Text);
                student.stuEnglish = double.Parse(textenglish.Text);

                studentlist.Add(student);

                dataGridView1.Refresh();
                dataGridView1.DataSource = studentlist;
            }
        }  //else 結尾



        private void btnsearch_Click(object sender, EventArgs e)
        {
            a6StuCls student = new a6StuCls();
            if (textname.Text == string.Empty)
            {
                MessageBox.Show("請輸入", "姓名");
                textname.Text = "";
                textname.Focus();
            }
            string subch="";
            string subeng="";
            string subma ="";
            bool check = false;
            foreach (a6StuCls x in studentlist)// x在studentlist裡
            {

                if (x.stuName == textname.Text)
                {
                    student.stuName = x.stuName;
                    student.stuChinese = x.stuChinese;
                    student.stuEnglish = x.stuEnglish;
                    student.stuMath = x.stuMath;
                    check = !check;
                    break;
                }
            }
            if (check && student.stuName == textname.Text)
            {
                if (student.stuChinese<60)
                {
                     subch = "，不及格";
                }
                if (student.stuEnglish < 60)
                {
                     subeng = "，不及格";
                }
                if (student.stuMath < 60)
                {
                     subma = "，不及格";
                }
                
                labelsingle.Text = $"\n查詢結果：\n" +
                                   $"姓名：{student.stuName}\n" +
                                   $"國文：{student.stuChinese}{subch}\n" +
                                   $"英文：{student.stuEnglish}{subeng}\n" +
                                   $"數學：{student.stuMath}{subma}" +
                                   $"\n平均：{Math.Round((student.stuMath + student.stuChinese + student.stuEnglish) / 3)}" +
                                   $"\n------------------------------------------\n";
            }
            else
            {
                MessageBox.Show("找不到學生成績", "錯誤");
            }


        }

        private void btn20_Click(object sender, EventArgs e)  //加入預設20筆資料
        {
            //
            //student.stuName = textname.Text;
            //student.stuChinese = double.Parse(textchinese.Text);
            //student.stuEnglish = double.Parse(textenglish.Text);
            //student.stuMath = double.Parse(textmath.Text);
            studentlist.Add(new a6StuCls() { stuName = "AA", stuChinese = 47, stuEnglish = 88, stuMath = 100 });
            studentlist.Add(new a6StuCls() { stuName = "BB", stuChinese = 52, stuEnglish = 75, stuMath = 70 });
            studentlist.Add(new a6StuCls() { stuName = "CC", stuChinese = 99, stuEnglish = 97, stuMath = 60 });
            studentlist.Add(new a6StuCls() { stuName = "DD", stuChinese = 87, stuEnglish = 49, stuMath = 50 });
            studentlist.Add(new a6StuCls() { stuName = "EE", stuChinese = 74, stuEnglish = 52, stuMath = 43 });
            studentlist.Add(new a6StuCls() { stuName = "FF", stuChinese = 38, stuEnglish = 66, stuMath = 98 });
            studentlist.Add(new a6StuCls() { stuName = "GG", stuChinese = 65, stuEnglish = 77, stuMath = 45 });
            studentlist.Add(new a6StuCls() { stuName = "HH", stuChinese = 43, stuEnglish = 88, stuMath = 78 });
            studentlist.Add(new a6StuCls() { stuName = "II", stuChinese = 60, stuEnglish = 90, stuMath = 33 });
            studentlist.Add(new a6StuCls() { stuName = "JJ", stuChinese = 61, stuEnglish = 100, stuMath = 100 });
            studentlist.Add(new a6StuCls() { stuName = "KK", stuChinese = 75, stuEnglish = 30, stuMath = 66 });
            studentlist.Add(new a6StuCls() { stuName = "LL", stuChinese = 88, stuEnglish = 28, stuMath = 75 });
            studentlist.Add(new a6StuCls() { stuName = "MM", stuChinese = 93, stuEnglish = 37, stuMath = 90 });
            studentlist.Add(new a6StuCls() { stuName = "NN", stuChinese = 100, stuEnglish = 66, stuMath = 88 });
            studentlist.Add(new a6StuCls() { stuName = "OO", stuChinese = 0, stuEnglish = 60, stuMath = 99 });
            studentlist.Add(new a6StuCls() { stuName = "PP", stuChinese = 85, stuEnglish = 70, stuMath = 78 });
            studentlist.Add(new a6StuCls() { stuName = "QQ", stuChinese = 64, stuEnglish = 80, stuMath = 84 });
            studentlist.Add(new a6StuCls() { stuName = "RR", stuChinese = 59, stuEnglish = 54, stuMath = 65 });
            studentlist.Add(new a6StuCls() { stuName = "SS", stuChinese = 70, stuEnglish = 57, stuMath = 59 });
            studentlist.Add(new a6StuCls() { stuName = "TT", stuChinese = 78, stuEnglish = 99, stuMath = 63 });
            dataGridView1.Refresh();
            dataGridView1.DataSource = studentlist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

        }//todo 選取列刪除學生資料

        public int lbx; //todo Listbox選取索引
        private void listsubject_SelectedIndexChanged(object sender, EventArgs e)//Listbox選取索引
        {
            if (listsubject.SelectedIndex == 0)
            {
                MessageBox.Show("國文", "選取科目");
                lbx = 0;
            }
            else if (listsubject.SelectedIndex == 1)
            {
                MessageBox.Show("英文", "選取科目");
                lbx = 1;
            }
            else if (listsubject.SelectedIndex == 2)
            {
                MessageBox.Show("數學", "選取科目");
                lbx = 2;
            }


        }


        private void btnsearch1_Click(object sender, EventArgs e)  //todo 依科目搜尋X~X範圍學生成績
        {
            double z;
            if (double.TryParse(textdown.Text, out z) == false || textdown.Text == string.Empty)
            {
                MessageBox.Show("請輸入數字", "分數");
                textdown.Text = "";
                textdown.Focus();

            }  //輸入分數1判斷格式
            else if (double.TryParse(textup.Text, out z) == false || textup.Text == string.Empty)
            {
                MessageBox.Show("請輸入數字", "分數");
                textup.Text = "";
                textup.Focus();
            }  //輸入分數2判斷格式
            else
            { 
            int lbdown = int.Parse(textdown.Text);
            int lbup = int.Parse(textup.Text);

            labelresult.Text = string.Empty;
            string zz = "";
            int cou = 0;
            
            
            switch (lbx)
            {
                case 0:
                    for (int i = 0; i < studentlist.Count; i++)
                    {
                        if (studentlist[i].stuChinese >= lbdown && studentlist[i].stuChinese <= lbup)
                        {
                            cou += 1;
                            zz += $"姓名：{studentlist[i].stuName}，國文：{studentlist[i].stuChinese}" +
                                          //$"英文：{studentlist[i].stuEnglish}\n" +
                                          //$"數學：{studentlist[i].stuMath}" +                                   
                                          $"\n------------------------------------------\n";
                            labelresult.Text = $"\n查詢結果：共{cou}人\n" + zz;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < studentlist.Count; i++)
                    {
                        if (studentlist[i].stuEnglish >= lbdown && studentlist[i].stuEnglish <= lbup)
                        {
                            cou += 1;
                            zz += $"姓名：{studentlist[i].stuName}，英文：{studentlist[i].stuEnglish}" +
                                          //$"英文：{studentlist[i].stuEnglish}\n" +
                                          //$"數學：{studentlist[i].stuMath}" +                                   
                                          $"\n------------------------------------------\n";
                            labelresult.Text = $"\n查詢結果：共{cou}人\n" + zz;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < studentlist.Count; i++)
                    {
                        if (studentlist[i].stuMath >= lbdown && studentlist[i].stuMath <= lbup)
                        {
                            cou += 1;
                            zz += $"姓名：{studentlist[i].stuName}，數學：{studentlist[i].stuMath}" +
                                          //$"英文：{studentlist[i].stuEnglish}\n" +
                                          //$"數學：{studentlist[i].stuMath}" +                                   
                                          $"\n------------------------------------------\n";
                            labelresult.Text = $"\n查詢結果：共{cou}人\n" + zz;
                        }
                    }
                    break;
            }




        }
        }
        double avgch, avgen, avgma;

        private void btnlie_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("資料匯出", "確定",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("這是MessageBox練習","騙你的~");
            }
            else
            {
                MessageBox.Show("BINGO答對了");
            }

        }

        int ch1, eng1, ma1;
        private void btncount_Click(object sender, EventArgs e) //todo各科平均、不及格人數
        {
            labelresult.Text = "查詢結果：";
            avgch=0; avgen = 0; avgma=0 ;
            ch1 = 0; eng1 = 0; ma1 = 0;
            string avgch1 = string.Empty;
            string avgen1 = string.Empty;
            string avgma1 = string.Empty;
            //string sch = string.Empty;
            //string seng = string.Empty;
            //string sma = string.Empty;
            for (int i = 0; i < studentlist.Count; i++)
            {
                avgch += studentlist[i].stuChinese;
                avgch1 = $"全班國文平均：{Math.Round((avgch/ studentlist.Count)).ToString()}";            
                avgen += studentlist[i].stuEnglish;
                avgen1 = $"全班英文平均：{Math.Round((avgen / studentlist.Count)).ToString()}";           
                avgma += studentlist[i].stuMath;
                avgma1 = $"全班數學平均：{Math.Round((avgma / studentlist.Count)).ToString()}";
            }//計算各科平均


            for (int i = 0,j=0,k=0; i < studentlist.Count; i++,j++,k++)
            {
                if (studentlist[i].stuChinese<60)
                {
                    ch1 += 1;                    
                }
                if (studentlist[i].stuEnglish < 60)
                {
                    eng1 += 1;                    
                }
                if (studentlist[i].stuMath < 60)
                {
                    ma1 += 1;                  
                }

            }//計算各科不及格人數
            //顯示結果
            labelresult.Text = $"\n查詢結果：\n" +
                                   $"{avgch1}\n" +
                                   $"{avgen1}\n" +
                                   $"{avgma1}" +
                                   $"\n------------------------------------------\n" +
                                   $"國文： {ch1} 人不及格\n"+
                                   $"英文： {eng1} 人不及格\n"+
                                   $"數學： {ma1} 人不及格\n";
        }
    }
}




    

