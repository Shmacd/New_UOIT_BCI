using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emotiv;
using System.Threading;
using EEG;

namespace EEG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("EEG Data Reader Example");

            EEG_Logger p = new EEG_Logger();


            // or p.engine.DataSetMarker();

            while (true)
            {
                p.marker();
                p.Run();
                Thread.Sleep(100);
            }
        }



    }
}
