//Air Hockey
//Charles Sarichith
//March 11, 2021
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

namespace Air_Hockey_Game
{
    public partial class Form1 : Form
    {
        SoundPlayer hitsound = new SoundPlayer(Properties.Resources.Hitsound);
        SoundPlayer score = new SoundPlayer(Properties.Resources.score);
        SoundPlayer gamewin = new SoundPlayer(Properties.Resources.Usecrowd);

        int player1Score = 0;
        int player2Score = 0;

        int player1X = 245;
        int player1Y = 60;

        int player2X = 245;
        int player2Y = 470;

        int playerWidth = 55;
        int playerHeight = 55;
        int playerSpeed = 4;

        int puckX = 255;
        int puckY = 267;
        int puckXSpeed = 6;
        int puckYSpeed = 6;
        int puckWidth = 35;
        int puckHeight = 35;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush borderBBrush = new SolidBrush(Color.PowderBlue);
        SolidBrush borderGBrush = new SolidBrush(Color.LightGray);
        SolidBrush goalBrush = new SolidBrush(Color.White);
        SolidBrush midBrushfill = new SolidBrush(Color.DarkGray);
        Pen circPen = new Pen(Color.DarkGray);

        public Form1()
        {
            InitializeComponent();
            winLabel.Hide();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //middle
            e.Graphics.FillRectangle(midBrushfill, 0, 280, 550, 10);
            e.Graphics.DrawEllipse(circPen, 222, 236, 100, 100);
            //border
            e.Graphics.FillRectangle(borderGBrush, 0, 0, 550, 30);
            e.Graphics.FillRectangle(borderGBrush, 0, 569, 550, 30);
            e.Graphics.FillRectangle(borderBBrush, 0, 0, 45, 600);
            e.Graphics.FillRectangle(borderBBrush, 505, 0, 45, 600);
            //goal
            e.Graphics.FillRectangle(goalBrush, 225, 0, 100, 30);
            e.Graphics.FillRectangle(goalBrush, 225, 569, 100, 30);
            //Puck
            e.Graphics.FillEllipse(blackBrush, puckX, puckY, puckWidth, puckHeight);
            //players
            e.Graphics.FillEllipse(blueBrush, player1X, player1Y, playerWidth, playerHeight);
            e.Graphics.FillEllipse(redBrush, player2X, player2Y, playerWidth, playerHeight);

            //e.Graphics.FillRectangle(redBrush, puckX + 5, puckY, 35, puckHeight);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Console.Write(player1X);
            //player 1 movement and collision border
            if (wDown == true && player1Y > 30)
            {
                player1Y -= playerSpeed;
            }
            if (sDown == true && player1Y < 222)
            {
                player1Y += playerSpeed;
            }
            if (aDown == true && player1X > 45)
            {
                player1X -= playerSpeed;
            }
            if (dDown == true && player1X < 449)
            {
                player1X += playerSpeed;
            }

            //player 2
            if (upArrowDown == true && player2Y > 290)
            {
                player2Y -= playerSpeed;
            }
            if (downArrowDown == true && player2Y < 512)
            {
                player2Y += playerSpeed;
            }
            if (leftArrowDown == true && player2X > 45)
            {
                player2X -= playerSpeed;
            }
            if (rightArrowDown == true && player2X < 449)
            {
                player2X += playerSpeed;
            }

            //Puck movement
            puckX += puckXSpeed;
            puckY += puckYSpeed;

            if (puckY < 30 || puckY > this.Height - 30 - puckWidth)
            {
                puckYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }
            if (puckX > this.Width - 45 - puckWidth || puckX < 45)
            {
                puckXSpeed *= -1;
            }

            Rectangle player1mal = new Rectangle(player1X, player1Y, playerWidth, playerHeight);
            Rectangle player2mal = new Rectangle(player2X, player2Y, playerWidth, playerHeight);
            Rectangle puck = new Rectangle(puckX + 17, puckY, 5, puckHeight);
            Rectangle puckleft = new Rectangle(puckX + 2, puckY, 2, puckHeight);
            Rectangle puckright = new Rectangle(puckX + 33, puckY, 2, puckHeight);
            Rectangle player1goal = new Rectangle(225, 0, 100, 30);
            Rectangle player2goal = new Rectangle(225, 569, 100, 30);

            if (player1mal.IntersectsWith(puck))
            {
                hitsound.Play();
                    puckXSpeed *= -1;
                    puckX = player1X + playerWidth + 1;
            }
            else if (player1mal.IntersectsWith(puckleft) || player1mal.IntersectsWith(puckright))
            {
                puckYSpeed *= -1;
        
            }
            if (player2mal.IntersectsWith(puck))
            {
                hitsound.Play();
                puckXSpeed *= -1;
            
            }
            else if (player2mal.IntersectsWith(puckleft) || player2mal.IntersectsWith(puckright))
            {
                puckXSpeed *= -1;
            
            }
            if (puck.IntersectsWith(player1goal))
            {
                score.Play();
                player2Score++;

                player2scorelabel.Text = $"{player2Score}";
                puckX = 255;
                puckY = 267;
            }
            if (puck.IntersectsWith(player2goal))
            {
                score.Play();
                player1Score++;
                player1scorelabel.Text = $"{player1Score}";
                puckX = 255;
                puckY = 267;
            }
            if (player1Score == 3)
            {
                gamewin.Play();
                gameTimer.Enabled = false;
                winLabel.Show();
                winLabel.Text = "Player1 Wins!";
            }
            if (player2Score == 3)
            {
                gamewin.Play();
                gameTimer.Enabled = false;
                winLabel.Show();
                winLabel.Text = "Player2 Wins!";
            }
           
            Refresh();
        }   
    }   
}
