using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }


        public BindingList<StudentModel> studentlist = new BindingList<StudentModel>();
        private void StudentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            //dataGridView1.DataSource = studentlist;



        }

        private void btnkeyIN_Click(object sender, EventArgs e)
        {
            bool check = false;
            int schinese, smath, seng;
            if (int.TryParse(textchinese.Text, out schinese) == false)
            {
                MessageBox.Show("請輸入數字", "國文成績");
                textchinese.Text = "";
                textchinese.Focus();

            }  //輸入國文成績判斷格式
            else if (int.TryParse(textmath.Text, out smath) == false)
            {
                MessageBox.Show("請輸入數字", "數學成績");
                textmath.Text = "";
                textmath.Focus();
            }  //輸入數學成績判斷格式
            else if (int.TryParse(textmath.Text, out seng) == false)
            {
                MessageBox.Show("請輸入數字", "英文成績");
                textenglish.Text = "";
                textenglish.Focus();
            }   //輸入英文成績判斷格式
            else
            {

                foreach (StudentModel x in studentlist)
                {
                    if (x.stuName == textname.Text)
                    {
                        MessageBox.Show("重複輸入");
                        check = !check;
                        break;
                    }
                }
                if (check == false)
                {
                    StudentModel student = new StudentModel();
                    student.stuName = textname.Text;
                    student.stuChinese = int.Parse(textchinese.Text);
                    student.stuMath = int.Parse(textmath.Text);
                    student.stuEnglish = int.Parse(textenglish.Text);

                    studentlist.Add(student);

                    dataGridView1.Refresh();
                    dataGridView1.DataSource = studentlist;
                }


            }  //else 結尾
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            StudentModel student = new StudentModel();
            student.stuName = textname.Text;
            student.stuChinese = int.Parse(textchinese.Text);
            student.stuMath = int.Parse(textmath.Text);
            student.stuEnglish = int.Parse(textenglish.Text);

            if (true)//student.stuName == textname.Text
            {
                labelresult.Text = $"\n查詢結果：\n" +
                                                 $"姓名：{student.stuName}\n" +
                                                 $"國文：{student.stuChinese}\n" +
                                                 $"數學：{student.stuMath}\n" +
                                                 $"英文：{student.stuEnglish}" +
                                                 $"\n------------------------------------------\n";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)  //DVG內容值修改 回傳 studentlist
        {
           
         }



        }
    }
