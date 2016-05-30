using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace EEG 
{
    public partial class Main : Form 
    {
        //CHANGE FOR DISPLAY TIME...  is this even used?
        static int inputTime = 10;
        static int finalTime = inputTime * 100;
        int ezCounter = 0;
        int hardCounter = 0;
        int ezorhard = 0;

        EEG_Logger p = new EEG_Logger();

        public Main() 
        {
            InitializeComponent();
        }

        //Starts test using simple password
        private void button1_Click(object sender, EventArgs e) 
        {
            String fn = p.get();
            Disp lol = new Disp(0, fn, ezCounter);
            lol.Visible = true;
            ezCounter++;
        }

        //Starts test using complex password
        private void button3_Click(object sender, EventArgs e) 
        {
            String fn = p.get();
            Disp lol = new Disp(1, fn, hardCounter);
            lol.Visible = true;
            hardCounter++;
        }

        //Sets up a white screen on subject's monitor to reduce distractions
        private void button5_Click(object sender, EventArgs e) 
        {
            TestSpace t = new TestSpace();
            t.Visible = true;
        } 
        
        //Allows user to add a marker to the EEG data, not currently being used
        private void button2_Click(object sender, EventArgs e) 
        {
            /*
            p.marker(0);
            */
        }

        //Will compare user responses to shown words and store the number of currect responses to a new file
        private void btnTally_Click(object sender, EventArgs e)
        {
            String fn = p.get();
            int ctrTotal = 0;
            int ctrCorrect = 0;
            List<String> userEntered = new List<String>();
            List<String> stored = new List<String>();
            userEntered = read(fn + ".responses", 1);
            stored = read(fn + ".passwords", 1);

            for (int i = 0; i < stored.Count; i++ )
            {
                if (userEntered[ctrTotal] == stored[ctrTotal])
                {
                    ctrCorrect++;
                }
                ctrTotal++;
            }
            write("Number of passwords shown: " + ctrTotal + "     Number of correct responses: " + ctrCorrect, fn);
        }

        //Function to read passwords from file
        public List<String> read(String filename, int a)
        {
            List<String> pws = new List<String>();
            string line;
            int counter = 0;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                pws.Add(line);
                counter++;
            }
            file.Close();
            return pws;
        }

        //Function to write results to a new file
        public void write(String line, String filename)
        {
            string path = filename + ".results";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) { }
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
    }
}
