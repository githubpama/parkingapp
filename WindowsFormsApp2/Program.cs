using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program


    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startseite());

           

            //Console.WriteLine("The version of the currently executing assembly is: {0}",
            //Assembly.GetExecutingAssembly().GetName().Version);

            //Console.WriteLine("The version of mscorlib.dll is: {0}",
            //    typeof(String).Assembly.GetName().Version);

        }


    }
}