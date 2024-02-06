using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = Soma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show($"O resultado da soma foi: {resultado}");
        }

        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
