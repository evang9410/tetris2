using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeL : Shape
    {
        private Block[][] rotations = new Block[4][];
        public ShapeL()
            : base()
        {
            for (int i = 0; i < rotations.Length; i++)
                rotations[i] = new Block[4];

            rotations[0][0] = new Block(Color.Orange, new Point(0, 0));
            rotations[0][1] = new Block(Color.Orange, new Point(0, 1));
            rotations[0][2] = new Block(Color.Orange, new Point(0, 2));
            rotations[0][3] = new Block(Color.Orange, new Point(1, 2));

            rotations[1][0] = new Block(Color.Orange, new Point(0, 0));
            rotations[1][1] = new Block(Color.Orange, new Point(0, 1));
            rotations[1][2] = new Block(Color.Orange, new Point(1, 0));
            rotations[1][3] = new Block(Color.Orange, new Point(2, 0));

            rotations[2][0] = new Block(Color.Orange, new Point(1, 0));
            rotations[2][1] = new Block(Color.Orange, new Point(2, 0));
            rotations[2][2] = new Block(Color.Orange, new Point(2, 1));
            rotations[2][3] = new Block(Color.Orange, new Point(2, 2));

            rotations[3][0] = new Block(Color.Orange, new Point(2, 0));
            rotations[3][1] = new Block(Color.Orange, new Point(2, 1));
            rotations[3][2] = new Block(Color.Orange, new Point(1, 1));
            rotations[3][3] = new Block(Color.Orange, new Point(0, 1));

            block = rotations[0];
        }
        public override void Reset()
        {
            block = rotations[0];
        }

        public override void Rotate()
        {
            if (currentRotation == 0)
            {
                block = rotations[1];
                currentRotation = 1;
            }
            else if (currentRotation == 1)
            {
                block = rotations[2];
                currentRotation = 2;
            }
            else if (currentRotation == 2)
            {
                block = rotations[3];
                currentRotation = 3;
            }
            else if (currentRotation == 3)
            {
                block = rotations[0];
                currentRotation = 0;
            }
            else
            {
                block = rotations[0];
                currentRotation = 0;
            }
        }
    }
}
