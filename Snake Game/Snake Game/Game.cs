using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Timer = System.Windows.Forms.Timer;

namespace Snake_Game
{
    class Game{
        public Keys direction { get; set; }
        public Keys Arrow { get; set; }
        private Timer frame { get; set; }
        private Label LbScore { get; set; }
        private Panel panelScreen { get; set; }

        private int score = 0;

        private Food food;
        private Snake snake;

        private Bitmap offScreenBitmap;
        private Graphics bitmapGraph;
        private Graphics screenGraph;

        public Game(ref Timer timer, ref Label label, ref Panel panel){
            panelScreen = panel;
            frame = timer;
            LbScore = label;

            offScreenBitmap = new Bitmap(428, 428);
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = panelScreen.CreateGraphics();

            snake = new Snake();
            food = new Food();
            direction = Keys.Left;
            Arrow = direction;
        }

        public void StartGame(){
            snake.Reset();
            food.CreateFood();
            direction = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = panelScreen.CreateGraphics();
            frame.Enabled = true;
        }

        public void CheckCollision() {
            if (snake.Location[0] == food.Location) {
                snake.eat();
                food.CreateFood();
                score += 10;
                LbScore.Text = "Score: " + score;
            }
        }

        public void GameOver(){
            frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            LbScore.Text = "Score: 0";
            MessageBox.Show("Game Over!");
        }

        public void Tick()
        {
            if (((Arrow == Keys.Up) && (direction != Keys.Down)) ||
               ((Arrow == Keys.Down) && (direction != Keys.Up)) ||
               ((Arrow == Keys.Left) && (direction != Keys.Right)) ||
               ((Arrow == Keys.Right) && (direction != Keys.Left)))
            {
                direction = Arrow;
            }

            switch (direction)
            {
                case Keys.Up:
                    snake.up();
                    break;
                case Keys.Down:
                    snake.down();
                    break;
                case Keys.Left:
                    snake.left();
                    break;
                case Keys.Right:
                    snake.right();
                    break;
            }

            using (MemoryStream ms = new MemoryStream(Properties.Resources.food))
            {
                bitmapGraph.Clear(ColorTranslator.FromHtml("#A9F5A9"));
                Bitmap foodImage = new Bitmap(ms);
                bitmapGraph.DrawImage(foodImage, (food.Location.X * 15), (food.Location.Y * 15), 15, 15);
            }

            SolidBrush headBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush bodyBrush = new SolidBrush(Color.Green);

            bool gameOver = false;

            for (int i = 0; i < snake.Length; i++)
            {
                if (i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(Color.DarkGreen), (snake.Location[i].X * 15), (snake.Location[i].Y * 15), 15, 15);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(Color.Green), (snake.Location[i].X * 15), (snake.Location[i].Y * 15), 15, 15);
                }

                if ((snake.Location[i] == snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }
            screenGraph.DrawImage(offScreenBitmap, 0, 0);
            CheckCollision();

            if (gameOver){
                GameOver();
            }
        }

    }
}
