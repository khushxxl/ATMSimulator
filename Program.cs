using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            Thread threadRaceForm = new Thread(() =>
            {
                Application.Run((new Form1(true)));
            });
           
            Thread threadNonRaceForm = new Thread(() =>
                 {
                     Application.Run((new Form1(false)));
             });

            threadRaceForm.Start();
            threadNonRaceForm.Start();


        }
    }
}
