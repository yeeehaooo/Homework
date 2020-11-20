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
    public partial class a2FormLoan : Form
    {
        public a2FormLoan()
        {
            InitializeComponent();

        }

        private void btncalculate_Click(object sender, EventArgs e)    //按下計算
        {
            //todo 使用int.TryParse 
            //處理 textbox 資料型態不為int 報錯處理
            String money = textmoney.Text;
            decimal money1 = 0.00m;
            String percent = textpercent.Text;
            double percent1 = (double)0.00m;
            String mon = textmon.Text;
            double mon1 = 0;

            if (decimal.TryParse(money, out money1) != true)
            {
                MessageBox.Show("請輸入數字", "貸款金額輸入錯誤");
            }
            else if (double.TryParse(percent, out percent1) != true)
            {
                MessageBox.Show("請輸入數字", "年利率輸入錯誤");
            }
            else if (double.TryParse(mon, out mon1) != true)
            {
                MessageBox.Show("請輸入數字", "貸款期數輸入錯誤");
            }    
            else
            {
                //todo 計算利息

                double total = Convert.ToDouble(money);                 //貸款金額
                double year = Convert.ToDouble(mon)/12;                //年
                double Rate = Convert.ToDouble(percent) / 100;     //年利率
                double[] moneyEachMonth;
                double totalMonth = year * 12;//总月份
                double minMoneyEachMonth = total / totalMonth;//每月本金
                moneyEachMonth = new double[(int)totalMonth];//每月还款数组

                int i;
                for (i = 0; i < totalMonth; i++)
                {
                    moneyEachMonth[i] = ((total - i * minMoneyEachMonth) * Rate / 12) + minMoneyEachMonth;//等本降息 等于 每月还的本金固定不变 利息逐渐降低
                }

                textotal.Text = "";//先清空

                for (i = 0; i < totalMonth; i++)
                {
                    textotal.Text += "第" + (i + 1) + "月(本期應繳金額：" + Math.Round(moneyEachMonth[i]) +"\r\n";
                }
                //'textallloan.Text= 
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            textmoney.Clear();
            textmon.Clear();
            textpercent.Clear();
            textotal.Clear();
        }
    }
}
