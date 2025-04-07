using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidingGame
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 14;
            bg1.Top += speed;
            bg2.Top += speed;

            if (bg1.Top >= 1005)
            {
                bg1.Top = 0;
                bg2.Top = -1005;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 24)
            {
                player.Left -= speed;
            }

            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 1000)
            {
                player.Left += speed;
            }

            else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && player.Top > 0)
            {
                player.Top -= speed;
            }

            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && player.Top < 800)
            {
                player.Top += speed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
