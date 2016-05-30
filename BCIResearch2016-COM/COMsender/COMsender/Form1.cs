using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace COMsender {
    public partial class Form1 : Form {


        SerialPort sPort = new SerialPort("COM10", 9600, Parity.None, 8, StopBits.One);

        public Form1() {
            InitializeComponent();

            sPort.Open();


        }

        private void button1_Click(object sender, EventArgs e) {
            //Thread.Sleep(5000);
            writee(99);
        }

        private void writee(byte f) {
            byte[] data = new byte[1] { f };

            if (sPort.IsOpen)
                sPort.Write(data, 0, 1);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            sPort.Close();
        }

    }
}
