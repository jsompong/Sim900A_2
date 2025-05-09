using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sim900A_2
{
    public partial class Form1 : Form
    {
        
        //SerialPort mySerialPort = new SerialPort( );
        SerialPort mySerialPort = new SerialPort("COM6",9600);
        //mySerialPort.BaudRate(9600);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_UnLoad(object sender, EventArgs e)
        {
           timer.Enabled = false;
           mySerialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string message = ((char)13).ToString();
            byte[] command = new byte[] { 0x13, 0x10 };
            try
            {
                mySerialPort.Open();
                mySerialPort.Write("RING\r\n");
                // mySerialPort.WriteLine(message);
              // mySerialPort.Write(new byte[] { 13 }, 0, 1);
               // mySerialPort.Write(command);
                timer.Enabled=true;             
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
                //SentBox.Text = ex.ToString();
                //Console.WriteLine(ex);
            }
        }

        private void SentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
             mySerialPort.Write("RING\r\n");
        }
    }
}
