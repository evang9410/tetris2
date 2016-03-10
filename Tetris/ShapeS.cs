using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeS : Shape
    {
        private IBoard board;
        private Block[][] rotations = new Block[2][];
        public ShapeS(IBoard board)
            : base(board)
        {
            for (int i = 0; i < rotations.Length; i++)
                rotations[i] = new Block[4];

            rotations[0][0] = new Block(Color.Tomato, new Point(0, 1), board);
            rotations[0][1] = new Block(Color.Tomato, new Point(1, 1), board);
            rotations[0][2] = new Block(Color.Tomato, new Point(1, 0), board);
            rotations[0][3] = new Block(Color.Tomato, new Point(2, 0), board);

            rotations[1][0] = new Block(Color.Tomato, new Point(0, 0), board);
            rotations[1][1] = new Block(Color.Tomato, new Point(0, 1), board);
            rotations[1][2] = new Block(Color.Tomato, new Point(1, 1), board);
            rotations[1][3] = new Block(Color.Tomato, new Point(1, 2), board);

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
            else
            {
                block = rotations[0];
                currentRotation = 0;
            }
        }
    }
}
