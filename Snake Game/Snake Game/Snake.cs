using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Snake{

        public int Length { get; private set; }

        public Point[] Location { get; private set; }

        public void Reset(){
            Length = 5;
            for(int i = 0; i < Length; i++){
                Location[i] = new Point(12, 12);
            }
        }

        public Snake() {
            Location = new Point[28 * 28];
            Reset();
        }

        public void Follow(){
            for(int i = Length - 1; i > 0; i--){
                Location[i] = Location[i - 1];
            }
        }

        public void up() {
            Follow();
            Location[0].Y--;
            if (Location[0]. Y < 0){
                Location[0].Y += 28;
            }
        }

        public void down() {
            Follow();
            Location[0].Y++;
            if (Location[0].Y > 27){
                Location[0].Y -= 28;
            }
        }

        public void left() {
            Follow();
            Location[0].X--;
            if (Location[0].X < 0){
                Location[0].X += 28;
            }
        }

        public void right() {
            Follow();
            Location[0].X++;
            if (Location[0].X > 27){
                Location[0].X -= 28;
            }
        }

        public void eat(){
            Length++;
        }
    }
}
