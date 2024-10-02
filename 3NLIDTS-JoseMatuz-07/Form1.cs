using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_JoseMatuz_07
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort {  get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += FrmMain_FormClosing;
            this.btnapagar.Click += btnapagar_Click;
            this.btnencender.Click += btnencender_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnencender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
        private void FrmMain_FormClosing(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
        private void btnapagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    }
}
