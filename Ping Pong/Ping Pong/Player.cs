using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        private int brojac = 0;

        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void BotMove()
        {
            if(brojac % 2 == 0)
            {
                if(this.Y >= 330)
                {
                    brojac++;
                }
                MoveDown();
            }
            else
            {
                if(this.Y <= 20)
                {
                    brojac++;
                }
                MoveUp();
            }
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, this.X, this.Y, 25, 100);
        }

        void MoveUp()
        {
            this.Y -= 10;
        }

        void MoveDown()
        {
            this.Y += 10;
        }
    }
}
