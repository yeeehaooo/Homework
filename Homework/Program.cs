using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new a0FormIndex());
            //Application.Run(new a1FormHello());
            //Application.Run(new a2FormLoan());
            //Application.Run(new a3FormPOS());
            //Application.Run(new a4FormGuess());
            //Application.Run(new a5FormScreen());
            //Application.Run(new a6FormStudent());  
            //Application.Run(new a7FormMath());
            //Application.Run(new a8FormCalc());
           
        }
    }
}
