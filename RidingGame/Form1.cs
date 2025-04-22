using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Bogus.DataSets;
using NAudio.Wave;


namespace RidingGame
{
    public partial class Form1: Form
    {
        private bool lose = false;

        public Form1()
        {
            InitializeComponent();

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;
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
            int speed = 15;
            bg1.Top += speed;
            bg2.Top += speed;

            int enemy_speed = 10;
            enemy1.Top += enemy_speed;
            enemy2.Top += enemy_speed;
            enemy3.Top += enemy_speed;
            enemy4.Top += enemy_speed;

            if (bg1.Top >= 1005)
            {
                bg1.Top = 0;
                bg2.Top = -1005;
            }

            if (enemy1.Top >= 1005)
            {
                enemy1.Top = -240;
                Random rand = new Random();
                enemy1.Left = rand.Next(0, 150);
            }

            if (enemy2.Top >= 1005)
            {
                enemy2.Top = -600;
                Random rand = new Random();
                enemy2.Left = rand.Next(250, 400);
            }

            if (enemy3.Top >= 1005)
            {
                enemy3.Top = -900;
                Random rand = new Random();
                enemy3.Left = rand.Next(500, 650);
            }

            if (enemy4.Top >= 1005)
            {
                enemy4.Top = -300;
                Random rand = new Random();
                enemy4.Left = rand.Next(750, 900);
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds)
                || player.Bounds.IntersectsWith(enemy3.Bounds) || player.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;

                lose = true;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose == true) 
                return;
            else 
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -240;
            enemy2.Top = -600;
            enemy3.Top = -900;
            enemy4.Top = -300;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer1.Enabled = true;
            lose = false;
        }
    }
}
