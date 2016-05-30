using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EEG {
    public partial class Instructions : Form {
        public Instructions() {
            InitializeComponent();
            richTextBox1.Text = "In the next screen you will be presented with a word, and will be given 10 seconds to try to memorize that word, when the 10 seconds are over you will be redirected to another screen with a different word and will be given another 10 seconds to try to memorize that word. When the 10 seconds are over you will be asked to enter both words (or any part you remember from these words).";
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            this.Hide();
        }
    }
}
