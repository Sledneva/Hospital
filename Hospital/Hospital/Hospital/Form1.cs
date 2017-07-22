using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        MD md;
        Man mn;
        Action act = new Action();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            act.Moving(pictureBox2, mn, md, timer1, timer2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += int.Parse(textBox3.Text);
                label1.Text = "Лечение " + progressBar1.Value;
            }
            catch
            {
                progressBar1.Value = 100;
                label1.Text = "Лечение " + progressBar1.Value;
                timer2.Stop();
                MessageBox.Show("Лечение закончено!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            md = new MD(int.Parse(textBox6.Text), int.Parse (textBox5.Text));
            Point pt = new Point(md.X(), md.Y());
            pictureBox1.Location = pt;
            progressBar1.Value = 0;
            label1.Text = "Лечение " + progressBar1.Value;
            mn = new Man(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            timer2.Stop();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
