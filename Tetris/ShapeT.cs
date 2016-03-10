using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeT: Shape
    {
        private IBoard board;
        private Block[][] rotations = new Block[4][];
        public ShapeT(IBoard board)
            : base(board)
        {
            for (int i = 0; i < rotations.Length; i++)
                rotations[i] = new Block[4];

            rotations[0][0] = new Block(Color.Purple, new Point(0, 0), board);
            rotations[0][1] = new Block(Color.Purple, new Point(1, 0), board);
            rotations[0][2] = new Block(Color.Purple, new Point(2, 0), board);
            rotations[0][3] = new Block(Color.Purple, new Point(1, 1), board);

            rotations[1][0] = new Block(Color.Purple, new Point(0, 1), board);
            rotations[1][1] = new Block(Color.Purple, new Point(1, 0), board);
            rotations[1][2] = new Block(Color.Purple, new Point(1, 1), board);
            rotations[1][3] = new Block(Color.Purple, new Point(1, 2), board);

            rotations[2][0] = new Block(Color.Purple, new Point(1, 0), board);
            rotations[2][1] = new Block(Color.Purple, new Point(0, 1), board);
            rotations[2][2] = new Block(Color.Purple, new Point(1, 1), board);
            rotations[2][3] = new Block(Color.Purple, new Point(2, 1), board);

            rotations[3][0] = new Block(Color.Purple, new Point(0, 0), board);
            rotations[3][1] = new Block(Color.Purple, new Point(0, 1), board);
            rotations[3][2] = new Block(Color.Purple, new Point(1, 1), board);
            rotations[3][3] = new Block(Color.Purple, new Point(0, 2), board);

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
                block = rotations[4];
                currentRotation = 4;
            }
            else
            {
                block = rotations[0];
                currentRotation = 0;
            }
        }
    }
}
