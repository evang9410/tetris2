using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeO : Shape
    {
        private Block[][] rotations;
        public ShapeO()
            : base()
        {
            rotations[0][0] = new Block(Color.Yellow, new Point(0, 0));
            rotations[0][1] = new Block(Color.Yellow, new Point(1, 0));
            rotations[0][2] = new Block(Color.Yellow, new Point(0, 1));
            rotations[0][3] = new Block(Color.Yellow, new Point(1, 1));

            block = rotations[0];
        }
        public override void Reset()
        {
            block = rotations[0];
        }

        public override void Rotate()
        {
            this.Reset();
        }
    }
}
