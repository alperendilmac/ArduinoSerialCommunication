using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardo
{
    public partial class Form1 : Form
    {
        SerialPort serialcomm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialcomm = new SerialPort("COM1");
            serialcomm.BaudRate = 9600;
            textBox1.ReadOnly = true;
            textBox2.Text = serialcomm.PortName;
            durdur.Enabled = false;


        }
        private void serialcomm_start()
        {
            serialcomm.Open();
            serialcomm.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string derece = serialcomm.ReadLine() + "\n";
            SetText(derece);
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                serialcomm_start();
                baslat.Enabled = false;
                durdur.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            try
            {
                serialcomm.Close();
                baslat.Enabled = true;
                durdur.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }

        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
           
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text + textBox1.Text;
            }
        }
    }
}
