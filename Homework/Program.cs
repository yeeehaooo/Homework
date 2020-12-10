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
            Application.Run(new a0FormIndex());  //OK
            //Application.Run(new a1FormHello());  //OK
            //Application.Run(new a2FormLoan());   //OK
            //Application.Run(new a3FormPOS());    //OK
            //Application.Run(new a4FormGuess());  //OK
            //Application.Run(new a5FormScreen());  //XXXX
            //Application.Run(new a6FormStudent()); //OK 
            //Application.Run(new a7FormMath());    //OK
            //Application.Run(new a9FormOOXX());   //OK
            //Application.Run(new FormSignIn99()); //OK
            //Application.Run(new FormNote());      //OK
            //Application.Run(new FormClock());     //OK
            //Application.Run(new a8FormCalc1());   // 90%
            //Application.Run(new FormPainter()); //XXXX
            //Application.Run(new FormPicture());
        }
    }
}
