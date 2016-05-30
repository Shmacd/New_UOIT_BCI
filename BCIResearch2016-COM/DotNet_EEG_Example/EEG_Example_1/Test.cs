using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EEG 
{
    public partial class Test : Form 
    {
        EEG_Logger p = new EEG_Logger();
        String fn;

        int selector;
        int passCTR;

        public Test(int ctr, int sel) 
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            textBox2.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - 670 / 2;
            selector = sel;
            passCTR = ctr;
            this.ActiveControl = textBox2;
            fn = p.get() + ".responses";
        }

        // DELAY FOR ANSWERING QUESTIONS -> currently disabled, allowing user as much time as needed to enter password
        //int duration = 10;
        /*
        void textBox1_GotFocus(object sender, EventArgs e) 
        {
            this.AcceptButton = ProcessTextBox1;
        }
        */

        //Function for writing user inputted answer to file
        public void write(String line, String path) 
        {
            // This text is added only once to the file.
            if (!File.Exists(path)) 
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) {}
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path)) 
            {
                sw.WriteLine(line);
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path)) 
            {
                string s = "";
                while ((s = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(s);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (textBox2.Text != "")
            {
                write(textBox2.Text, fn);
            }
            else
            {
                write("-empty-", fn);
            }
            this.Hide();
            if (passCTR < 25)
            {
                Disp lol = new Disp(selector, p.get(), passCTR);
                lol.Visible = true;
                this.Hide();
            }
        }
    }
}
