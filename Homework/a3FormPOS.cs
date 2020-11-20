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
    public partial class a3FormPOS : Form
    {
        

        private void btnBMclk_Click(object sender, EventArgs e)
        {
            //ok
            DataGridViewRowCollection rows = dataGridView1.Rows;
            string i = rows[2].ToString ();
            int i1 = int.Parse(i);
            string j = rows[3].ToString();
            int j1 =Convert.ToInt32(j);
           
            rows.Insert(new Object[] { "BM", 120, i, j });
            i += 1;
        }
        //private void a3FormPOS_Load(object sender, EventArgs e)
        //{ 

        //}

    }
}
