using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int spd = 10;
        int moveX;
        int moveY;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY = -spd;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveY = spd;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveX = -spd;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveX = spd;
            }
            if (e.KeyCode == Keys.Space)
            {
                pictureBox2.Left = pictureBox1.Left;
                pictureBox2.Top = pictureBox1.Top;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveY = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveX = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveX = 0;
            }
        }
    }
}
