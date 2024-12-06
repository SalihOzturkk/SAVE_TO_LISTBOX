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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Text ="Form2 ye git";
            this.Text = "İSMAİL ZORMAN";
        }
    }
}
