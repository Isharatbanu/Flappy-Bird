using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }
        int gravity = 15;
        int speed = 15;
        int score = 0;

        Random rndm = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxBird.Top += gravity;
            pictureBoxPipeDown.Left -= speed;
            pictureBoxPipeDown2.Left -= speed;
            pictureBoxPipeUp.Left -= speed;
            pictureBoxPipeUp2.Left -= speed;
            pictureBoxPipeUp3.Left -= speed;

            PictureBoxCloud1.Left -= speed;
            PictureBoxCloud2.Left -= speed;

            //sun.Left -= speed;
            labelScore.Text = $"Score : {score}";

            //updating Score
            if(pictureBoxPipeDown.Left < -210)
            {
                pictureBoxPipeDown.Left = rndm.Next(100,600);
                score++;
            }
            if (pictureBoxPipeDown2.Left < -210)
            {
                pictureBoxPipeDown2.Left = rndm.Next(600, 900);
                score++;
            }
            if (pictureBoxPipeUp.Left < -210)
            {
                int r = rndm.Next(100, 700);
                pictureBoxPipeUp.Left = rndm.Next(100,500);
                score++;
                
                PictureBoxCloud1.Left = rndm.Next(r + 50, 800);
            }
            if (pictureBoxPipeUp2.Left < -210)
            {
                pictureBoxPipeUp2.Left = rndm.Next(50, 800);
                score++;
            }
            if (pictureBoxPipeUp3.Left < -210)
            {
                int r = rndm.Next(30, 700);
                PictureBoxCloud2.Left = rndm.Next(r + 30, 800);
                pictureBoxPipeUp3.Left = rndm.Next(600, 900);
                score++;
            }
            
            if (
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeDown.Bounds) 
                ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeDown2.Bounds)
                ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeUp.Bounds)
                ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeUp2.Bounds)
                ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeUp3.Bounds)
                ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxGround.Bounds)
                )

            {
                timer1.Stop();
                labelScore.Text += "\t\t Game Over !! ";
                
                score = 0;
            }
            if (score > 20)
            {
                speed += 1;
            }
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {

        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

            else if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
                pictureBoxBird.Location = new Point(32, 64);
                pictureBoxPipeDown.Location = new Point(265, 0);
                
            }
        }
        
    }
}
