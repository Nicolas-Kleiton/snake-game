using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Food{

        public Point Location { get; private set; }

        public void CreateFood() {
            Random random = new Random();
            Location = new Point(random.Next(0, 27), random.Next(0, 27));
        }
    }
}
