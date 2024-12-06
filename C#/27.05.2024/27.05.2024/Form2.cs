using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._05._2024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int soru;
            soru = Convert.ToInt32(MessageBox.Show("ÇıkışYapılsın Mı?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2));
            if (soru == 6) {
                Application.Exit();
            }
            /*int soru;
            soru =MessageBox.Show("ÇıkışYapılsın Mı?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (soru ==DialogResult.Yes)
            {
                Application.Exit();
            }*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button3_Click(sender, e);
            button3.PerformClick();
        }
    }
}
