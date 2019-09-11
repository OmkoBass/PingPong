using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        Keys key;
        Ball ball = new Ball(350, 250);
        Player player = new Player(50, 20);
        Player bot = new Player(710, 20);

        int playerPts = 0;
        int botPts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void movePlayer()
        {
            switch (key)
            {
                case Keys.Up:
                    if(player.Y >= 20)
                        player.Y -= 10;
                    break;
                case Keys.Down:
                    if(player.Y <= 330)
                        player.Y += 10;
                    break;
            }
        }

        public void Riochet()
        {
            if (ball.Y <= 0) { ball.speedY *= -1; }
            else if (ball.Y >= 430) { ball.speedY *= -1; }
            else if (ball.X == player.X && player.Y < ball.Y && ball.Y < player.Y + 100)
            {
                ball.speedX *= -1;
            }
            else if (ball.X == bot.X && bot.Y < ball.Y && ball.Y < bot.Y + 100)
            {
                ball.speedX *= -1;
            }
        }

        public void Victory()
        {
            if(ball.X <= 0) { botPts++; BotScore.Text = botPts.ToString(); ball.Reset(); }
            else if(ball.X >= 720) { playerPts++; PlayerScore.Text = playerPts.ToString(); ball.Reset(); }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gameTimer.Start();
            player.Draw(e);
            bot.Draw(e);
            bot.BotMove();
            ball.Draw(e);
            ball.Move();
            Riochet();
            Victory();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            movePlayer();

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
        }
    }
}
