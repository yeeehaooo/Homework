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
    public partial class a3FormPOS : Form //todo 買飯 完成
    {
        public a3FormPOS()
        {
            InitializeComponent();
        }

		private int bmPr = 120; //A價格
		private int bhPr = 150; // B價格
		private int mtPr= 200; // C價格
		private int liPr = 180; // D價格		
		private int a = 0; // A數量
		private int b = 0; // B數量
		private int c = 0; // C數量
		private int d = 0; // D數量
		private string bml; // A清單
		private string bhl; // B清單
		private string mtl; // C清單
		private string lil; // D清單
		private int Total = 0; // 總金額



		int z;
		string x;//用來接數字按鍵
		private void btnNumber_Click(object sender, EventArgs e)//BTN 數字
		{
			
			textPay.Text = "";
			Button btnnum = (Button)sender;
			x +=btnnum.Text;
			z = int.Parse(x);
			textPay.Text = $"NT$ {z.ToString()}";
		}
		
		private void btnPay_Click(object sender, EventArgs e)//BTN現金
        {
			
			z = int.Parse(x);
			if (z < Total)
			{
				Total = Math.Abs(z - Total);
				textresult.Text = $"還差 NT$ {Total} 元";

				texttotal.Text = $"NT$ {Total}";
				text09total.Text = "";
				textPay.Text = string.Empty;
				z = 0;
				x = "";
				
			}
			else
			{
				textresult.Text = $"找您 NT$ {z - Total} 元";
			}
		}
		
        private void btnvisa_Click(object sender, EventArgs e) //BTN信用卡
        {
			textresult.Text = $"信用卡付款 NT$ {Total*0.9} 元";
		}

        private void btnBMclk_MouseDown(object sender, MouseEventArgs e)//單品A
		{
			MouseEventArgs Mouse_e = (MouseEventArgs)e;
			if (Mouse_e.Button == MouseButtons.Left)
			{
				a++; // 數量 + 1
				Total += 120; // 累加總金額
				texttotal.Text = "NT$ " + Total; // 秀出總金額
				text09total.Text = "NT$ " + Total * 0.9;
				// 設定品項數量金額清單
				bml = $"{btnBMclk.Text.Substring(0, btnBMclk.Text.Length - 6).Replace("\r", "")}* {a} ，共NT$ {bmPr * a} 元\n";
				labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
			}
			else
			{
				if (a <1)
				{
					bml = "";
					labelList.Text = bml+bhl + mtl + lil;
				}									
				else
				{
					a--; // 數量 - 1
					Total -= 120; // 累加總金額
					texttotal.Text = "NT$ " + Total; // 秀出總金額
					text09total.Text = "NT$ " + Total * 0.9;
					// 設定品項數量金額清單
					bml = $"{btnBMclk.Text.Substring(0, btnBMclk.Text.Length - 6).Replace("\r", "")}* {a} ，共NT$ {bmPr * a} 元\n";
					labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
				}
				
			}
		}

        private void btnbh_MouseDown(object sender, MouseEventArgs e)//單品B
		{
			MouseEventArgs Mouse_e = (MouseEventArgs)e;
			if (Mouse_e.Button == MouseButtons.Left)
			{
				b++; // 數量 + 1
				Total += 150; // 累加總金額
				texttotal.Text = "NT$ " + Total; // 秀出總金額
				text09total.Text = "NT$ " + Total * 0.9;
				// 設定品項數量金額清單
				bhl = $"{btnbh.Text.Substring(0, btnbh.Text.Length - 6).Replace("\r", "")}* {b} ，共NT$ {bhPr*b} 元\n";
				labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
			}
			else
			{
				if (b< 1)
				{
					bhl = "";
					labelList.Text = bml +bhl+ mtl + lil;
				}
				else
				{
					b--; // 數量 - 1
					Total -= 150 ; // 累加總金額
					texttotal.Text = "NT$ " + Total; // 秀出總金額
					text09total.Text = "NT$ " + Total * 0.9;
					// 設定品項數量金額清單
					bhl = $"{btnbh.Text.Substring(0, btnbh.Text.Length - 6).Replace("\r", "")}* {b} ，共NT$ {bhPr * b} 元\n";
					labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
				}

			}
		}

        private void btnmt_MouseDown(object sender, MouseEventArgs e) //單品C 
		{
			MouseEventArgs Mouse_e = (MouseEventArgs)e;
			if (Mouse_e.Button == MouseButtons.Left)
			{
				c++; // 數量 + 1
				Total += 200; // 累加總金額
				texttotal.Text = "NT$ " + Total; // 秀出總金額
				text09total.Text = "NT$ " + Total * 0.9;
				// 設定品項數量金額清單
				mtl = $"{btnmt.Text.Substring(0, btnmt.Text.Length - 6).Replace("\r", "")}* {c} ，共NT$ {mtPr * c} 元\n";
				labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
			}
			else
			{
				if (c < 1)
				{
					mtl = "";
					labelList.Text = bml + bhl + mtl + lil;
				}
				else
				{
					c--; // 數量 - 1
					Total -= 200; // 累加總金額
					texttotal.Text = "NT$ " + Total; // 秀出總金額
					text09total.Text = "NT$ " + Total * 0.9;
					// 設定品項數量金額清單
					mtl = $"{btnmt.Text.Substring(0, btnmt.Text.Length - 6).Replace("\r", "")}* {c} ，共NT$ {mtPr * c} 元\n";
					labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
				}

			}
		}

        private void btnli_MouseDown(object sender, MouseEventArgs e)//單品D
		{
			MouseEventArgs Mouse_e = (MouseEventArgs)e;
			if (Mouse_e.Button == MouseButtons.Left)
			{
				d++; // 數量 + 1
				Total += 180; // 累加總金額
				texttotal.Text = "NT$ " + Total; // 秀出總金額
				text09total.Text = "NT$ " + Total * 0.9;
				// 設定品項數量金額清單
				lil = $"{btnli.Text.Substring(0, btnli.Text.Length - 6).Replace("\r", "")}* {d} ，共NT$ {liPr * d} 元\n";
				labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
			}
			else
			{
				if (d < 1)
				{
					lil = "";
					labelList.Text = bml + bhl + mtl + lil;
				}
				else
				{
					d--; // 數量 - 1
					Total -= 180; // 累加總金額
					texttotal.Text = "NT$ " + Total; // 秀出總金額
					text09total.Text = "NT$ " + Total * 0.9;
					// 設定品項數量金額清單
					lil = $"{btnli.Text.Substring(0, btnli.Text.Length - 6).Replace("\r", "")}* {b} ，共NT$ {liPr * d} 元\n";
					labelList.Text = bml + bhl + mtl + lil; // 加總所有品項清單並秀出
				}

			}
		}

        private void btnClear_Click(object sender, EventArgs e)//BTN C
        {
			x = "0";
			z = 0;
			textPay.Text = z.ToString();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
			text09total.Text = string.Empty;
			textPay.Text = string.Empty;
			textresult.Text = string.Empty;
			texttotal.Text = string.Empty;
			x = string.Empty;
			z = 0;
			labelList.Text = "List";


		}
    }
    }

