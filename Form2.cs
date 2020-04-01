using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimyapimiodev1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string [] harfler = { "A", "E", "I", "İ", "O", "Ö", "U", "Ü", "B", "C", "Ç", "D", "F", "G", "Ğ", "H", "J", "K", "L", "M", "N", "P", "R", "S", "Ş", "T", "V", "Y", "Z" };
            string uret = "";
            for (int i = 0; i < 8; i++)
            {
                uret += harfler[rand.Next(harfler.Length)];
            }
            textBox1.Text = uret;
            
        }
    }
}
