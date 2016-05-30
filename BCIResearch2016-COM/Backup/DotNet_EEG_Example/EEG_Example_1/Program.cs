using System;
using System.Collections.Generic;

using System.IO;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace EEG {
    public class EEG_Logger {


        static string tf;

        public string get() {
            return tf;
        }

        [STAThread]
        public static void Main(string[] args) {
            Console.WriteLine("Please specify participant ID: ");
            tf = Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

        }

    }
}
