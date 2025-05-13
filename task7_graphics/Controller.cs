using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_graphics
{
    public class Controller
    {
        private Ball ball;

        public Controller(Graphics graphics, Size clientSize) 
        {
            ball = new Ball(new Point(5, 5), new Point(100, 100), Color.White, graphics, clientSize);
        }

        public void Run()
        {
            ball.Move();
            ball.Draw();
            ball.BounceSide();
        }
    }
}
