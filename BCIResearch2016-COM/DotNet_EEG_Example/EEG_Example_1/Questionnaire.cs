using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EEG {
    public partial class Questionnaire : Form {

        String fn;
        String output;

        EEG_Logger p = new EEG_Logger();

        public Questionnaire() {
            InitializeComponent();
            fn = p.get() + ".passwords";
            output = p.get() + ".responses";

            passwords = read(fn);
            label2.Text = "When you saw " + passwords[1] + " presented, did you have doubts that you won't be able to memorize it?";
            radioButton1.Text = passwords[0];
            radioButton2.Text = passwords[1];
            radioButton3.Text = passwords[2];

        }

        List<String> passwords = new List<String>();



        public List<String> read(String filename) {
            List<String> pws = new List<String>();
            string line;
            int counter = 0;
            // Read the file and display it line by line.
            try {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);
                while ((line = file.ReadLine()) != null) {
                    pws.Add(line);
                    counter++;
                }

                file.Close();

            } catch (IOException) {
                Console.WriteLine("File not found");
            }

            return pws;
        }

        public void write(String line, String path) {

            // This text is added only once to the file.
            if (!File.Exists(path)) {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine();
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine(line);

            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path)) {
                string s = "";
                while ((s = sr.ReadLine()) != null) {
                    Console.WriteLine(s);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {



        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                write(passwords[0], output);
            } else if (radioButton2.Checked == true) {
                write(passwords[1], output);
            } else if (radioButton3.Checked == true) {
                write(passwords[2], output);
            }

            if (radioButton4.Checked == true) {
                write(radioButton4.Text, output);
            } else if (radioButton5.Checked == true) {
                write(radioButton5.Text, output);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e) {

        }



    }
}
