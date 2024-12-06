using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc;
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            sonuc = ad + " " + soyad;
            listBox1.Items.Add(sonuc);
            textBox3.Text = sonuc;
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
            textBox1.BackColor = Color.DarkBlue;
            
        }
    }
}
;