using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuglica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int x, y;
        int r = 20;
        SolidBrush cetka = new SolidBrush(Color.Green);

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cetka.Color = colorDialog1.Color;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            y += 3;
            
            g.FillEllipse(cetka, x - r, y - r, 2 * r, 2 * r);
            if (y > ClientRectangle.Height - r) timer1.Stop();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            r =Convert.ToInt32( textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor=Color.Black;

        }
    }
}
