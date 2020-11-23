using System;
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
    public partial class a8FormCalc : Form
    {

        public a8FormCalc()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)  //"C"清除按鍵
        {
            Init_Btn();
            labelresult.Text = "";
            Num1.Text = "";

        }



        private void btnresult_Click(object sender, EventArgs e) //"="按鍵
        {


            if (((Button)sender).Text == "=")
            {
                Init_Btn();
            }
            string result = Num1.Text; //目前的運算式 

            if (result.Contains("+") == true)//檢查有無"+"符號
            {               
                string[] Numbers = result.Split('+'); //Split資料分割 Nums =[123,456]
                double tempNumber1 = double.Parse(Numbers[0]);//123
                double tempNumber2 = double.Parse(Numbers[Numbers.Length-1]);//456
                labelresult.Text = (tempNumber1 + tempNumber2).ToString();
                Num1.Text = labelresult.Text ;
            }
            else if (result.Contains("*") == true)
            {
                string[] Numbers = result.Split('*'); //Split資料分割 Nums =[123,456]
                double tempNumber1 = double.Parse(Numbers[0]);//123
                double tempNumber2 = double.Parse(Numbers[Numbers.Length - 1]);//456
                labelresult.Text = (tempNumber1 * tempNumber2).ToString();
                Num1.Text = labelresult.Text;
            }
            else if (result.Contains("/") == true)
            {
                string[] Numbers = result.Split('/'); //Split資料分割 Nums =[123,456]
                double tempNumber1 = double.Parse(Numbers[0]);//123
                double tempNumber2 = double.Parse(Numbers[Numbers.Length - 1]);//456
                labelresult.Text = (tempNumber1 / tempNumber2).ToString();
                Num1.Text = labelresult.Text;
            }
            else if (result.Contains("-") == true)
            {
                string[] Numbers = result.Split('-'); //Split資料分割 Nums =[123,456]
                if (Numbers[0] == string.Empty)
                {
                    double tempNumber1 = 0;//123
                    double tempNumber2 = double.Parse(Numbers[Numbers.Length - 1]);//456
                    labelresult.Text = (tempNumber1 - tempNumber2).ToString();
                    Num1.Text = labelresult.Text;
                }
            }
            


        }



        private void btnClick(object sender, EventArgs e)//運算字元
        {
            if (Num1.Text == string.Empty)
            {
                //直接按下符號不做處理
            }
            else
            {
                Button sender_btn = (Button)sender;
                Init_Btn();
                sender_btn.BackColor = Color.Red;
                
                string lasttext = Num1.Text.Substring(Num1.Text.Length - 1, 1);
                

                double tempdb1;
                if (double.TryParse(lasttext, out tempdb1) == true)
                {
                    char[] symbols = new char[] { '+', '*', '/', '-', '%' };
                    bool check_symbol = false;
                    for (int i = 0; i < symbols.Length; i++)
                    {
                        if (check_symbol == false)
                        {
                            check_symbol = Num1.Text.Contains(symbols[i]);                           
                        }
                        else
                        {
                            break;
                        }                                                                                              
                    }

                    if (check_symbol == true)
                    {
                        //3. 123+123 
                        btnresult_Click(sender, new EventArgs());
                        Num1.Text += sender_btn.Text;
                        
                    }
                    else
                    {
                        //1.正常情況 輸入數字 EX:123
                        Num1.Text += sender_btn.Text;
                    }                                                        
                }
                else
                {
                    //2.最後一個字元替換
                    string originaltxt = Num1.Text.Substring(0, Num1.Text.Length - 1);
                    Num1.Text = originaltxt + sender_btn.Text;
                }
                
            }
        }
        private void btnnumberClick(object sender, EventArgs e)
        {
            Button btnnum = (Button)sender;
            Num1.Text += btnnum.Text;
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
            if (((Button)sender).Text == "%")
            {
                Init_Btn();
            }

            if (Num1.Text == string.Empty)
            { 

            }
            else
            {
                string textpercent = Num1.Text.Substring(Num1.Text.Length - 1, 1);
                Button persender_btn = (Button)sender;
                double tempdb1;
                double tempdb2;
                if (double.TryParse(textpercent, out tempdb1) == true)  //最後一碼為數字
                {
                                        
                    if (double.TryParse(Num1.Text, out tempdb2) == false) //最後一碼為數字且該組字串是否有包含符號
                    {
                        char[] symbols = new char[] { '+', '*', '/', '-' };
                        bool check_symbol = false;
                        char a = ' '; 
                        for (int i = 0; i < symbols.Length; i++)
                        {
                            if (check_symbol == false)
                            {
                                check_symbol = Num1.Text.Contains(symbols[i]);
                                a = symbols[i];
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (check_symbol == true)
                        {
                            //3. 123+123 
                            btnresult_Click(sender, new EventArgs());  //num1.text=3-3

                            string[] Numbers = Num1.Text.Split(a); //Split資料分割 Nums =[123,456]
                            double tempNumber1 = double.Parse(Numbers[0]);//123
                            double tempNumber2 = double.Parse(Numbers[Numbers.Length - 1]);//456
                            if (a=='+')
                            {
                                Num1.Text = (tempNumber1 + tempNumber2).ToString();
                                labelresult.Text = Num1.Text;
                            }
                            else if (a == '-')
                            {
                                Num1.Text = (tempNumber1 - tempNumber2).ToString();
                                labelresult.Text = Num1.Text;
                            }
                            else if (a == '*')
                            {
                                Num1.Text = (tempNumber1 * tempNumber2).ToString();
                                labelresult.Text = Num1.Text;
                            }
                            else if (a == '/')
                            {
                                Num1.Text = (tempNumber1 / tempNumber2).ToString();
                                labelresult.Text = Num1.Text;
                            }
                            if (Num1.Text == "0")
                            {

                            }
                            else
                            {
                                double x = double.Parse(Num1.Text);
                                labelresult.Text = (x / 100).ToString();
                                Num1.Text = labelresult.Text;
                            }
                            
                            

                        }
                        else
                        {
                            //1.正常情況 輸入數字 EX:123
                            Num1.Text += persender_btn.Text;
                            double x = double.Parse(Num1.Text);
                            labelresult.Text = (x / 100).ToString();
                            Num1.Text = labelresult.Text;
                        }
                    

                    }
                    else 
                    {

                        double x = double.Parse(Num1.Text);
                        labelresult.Text = (x / 100).ToString();
                        Num1.Text = labelresult.Text;

                    }
                }
                else
                {
                    //string symbol_a = (Button).sender;
                    string textper = Num1.Text.Remove(Num1.Text.Length - 1, 1); // 輸入555* 變成 555
                    double perresult = double.Parse(textper) / 100;
                    labelresult.Text = perresult.ToString();
                    Num1.Text = perresult.ToString();
                    

                }
            }
            

        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "^")
            {
                Init_Btn();
            }

            if (Num1.Text == string.Empty)
            {                
            }
            else
            {
                string textpercent = Num1.Text.Substring(Num1.Text.Length - 1, 1);
                Button persender_btn = (Button)sender;
                double tempdb1;
                double tempdb2;
                if (double.TryParse(textpercent, out tempdb1) == true)  //最後一碼為數字
                {

                    if (double.TryParse(Num1.Text, out tempdb2) == false) //最後一碼為數字且該組字串是否有包含符號
                    {
                        char[] symbols = new char[] { '+', '*', '/', '-' };
                        bool check_symbol = false;
                        for (int i = 0; i < symbols.Length; i++)
                        {
                            if (check_symbol == false)
                            {
                                check_symbol = Num1.Text.Contains(symbols[i]);
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (check_symbol == true)
                        {
                            //3. 123+123 
                            btnresult_Click(sender, new EventArgs());
                            //Num1.Text += persender_btn.Text;
                            double x = double.Parse(Num1.Text);
                            labelresult.Text = Math.Pow(x,2).ToString();
                            Num1.Text = labelresult.Text;


                        }
                        else
                        {
                            //1.正常情況 輸入數字 EX:123
                            Num1.Text += persender_btn.Text;
                            double x = double.Parse(Num1.Text);
                            labelresult.Text = Math.Pow(x, 2).ToString();
                            Num1.Text = labelresult.Text;
                        }


                    }
                    else
                    {

                        double x = double.Parse(Num1.Text);
                        labelresult.Text = Math.Pow(x,2).ToString();
                        Num1.Text = labelresult.Text;

                    }
                }
                else
                {
                    //string symbol_a = (Button).sender;
                    string textper = Num1.Text.Remove(Num1.Text.Length - 1, 1); // 輸入555* 變成 555
                    double perresult = Math.Pow(double.Parse(textper), 2);
                    labelresult.Text = perresult.ToString();
                    Num1.Text = perresult.ToString();


                }
            
        }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {

            if (((Button)sender).Text == "+/-")
                {
                    Init_Btn();
                }
            double xx;
            if (Num1.Text == string.Empty)  //空
            {
                string numsign = btnSign.Text.Substring(btnSign.Text.Length - 1, 1);

            }
            //else if (Num1.Text == "-") //"-"
            //{

            //}
            //字串123
            else if (double.TryParse(Num1.Text, out xx) == true)
            {
                Num1.Text = (0 - xx).ToString();
            }
            else if (double.TryParse(Num1.Text.Substring(Num1.Text.Length - 1, 1), out xx) == false)
            {
                Num1.Text += ((Button)sender).Text.Substring(((Button)sender).Text.Length - 1, 1);
            }
            //123+123
            else if (double.TryParse(Num1.Text, out xx) == false)
            {
                char[] symbols = new char[] { '+', '*', '/', '-' };

                bool check_symbol = false;
                char db_check = ' ';
                for (int i = 0; i < symbols.Length; i++)
                {
                    if (check_symbol == false)
                    {
                        check_symbol = Num1.Text.Contains(symbols[i]);
                        db_check = symbols[i];
                    }
                    else
                    {
                        break;
                    }
                }

                if (check_symbol == true)
                {

                    string[] Numbers = Num1.Text.Split(db_check); //Split資料分割 Nums =[123,456]
                    double tempNumber1 = double.Parse(Numbers[0]);//123
                    double tempNumber2 = 0 - double.Parse(Numbers[1]);//456
                    if (db_check == '+')
                    {
                        labelresult.Text = (tempNumber1 + tempNumber2).ToString();
                        Num1.Text = labelresult.Text;

                    }
                    else if (db_check == '*')
                    {
                        labelresult.Text = (tempNumber1 * tempNumber2).ToString();
                        Num1.Text = labelresult.Text;

                    }
                    else if (db_check == '/')
                    {
                        labelresult.Text = (tempNumber1 / tempNumber2).ToString();
                        Num1.Text = labelresult.Text;

                    }
                    else if (db_check == '-')
                    {
                        labelresult.Text = (tempNumber1 - tempNumber2).ToString();
                        Num1.Text = labelresult.Text;

                    }


                }
            }
        }
    }
    }
    







