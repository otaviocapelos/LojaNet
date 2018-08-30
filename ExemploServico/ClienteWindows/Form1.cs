using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wcf = new ServiceReference1.Servico01Client();
            string msg = wcf.Mensagem();
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wcf = new ServiceReference1.Servico01Client();
            string msg = wcf.Somar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            MessageBox.Show(msg);
        }
    }
}
