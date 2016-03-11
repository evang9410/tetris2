using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeZ : Shape
    {
        private Block[][] rotations = new Block[3][];
        private IBoard board;
        private Block[] reset;
        public ShapeZ(IBoard board)
            : base(board)
        {
            for (int i = 0; i < rotations.Length; i++)
                rotations[i] = new Block[4];

            rotations[0][0] = new Block(Color.DarkGreen, new Point(0, 0), board);
            rotations[0][1] = new Block(Color.DarkGreen, new Point(1, 0), board);
            rotations[0][2] = new Block(Color.DarkGreen, new Point(1, 1), board);
            rotations[0][3] = new Block(Color.DarkGreen, new Point(2, 1), board);
            block = rotations[0];
            reset = rotations[0];
            
            rotations[1][0] = new Block(Color.DarkGreen, new Point(block[0].Position.X, block[0].Position.Y + 1), board);//0,1
            rotations[1][1] = new Block(Color.DarkGreen, new Point(block[1].Position.X - 1, block[1].Position.Y + 2), board);//0,2
            rotations[1][2] = new Block(Color.DarkGreen, new Point(block[2].Position.X, block[2].Position.Y), board);//1,1
            rotations[1][3] = new Block(Color.DarkGreen, new Point(block[3].Position.X - 1, block[3].Position.Y - 1), board);//1,0

            rotations[2][0] = new Block(Color.DarkGreen, new Point(block[0].Position.X, block[0].Position.Y - 1), board);//0,0
            rotations[2][1] = new Block(Color.DarkGreen, new Point(block[1].Position.X + 1, block[1].Position.Y -2), board);//1,0
            rotations[2][2] = new Block(Color.DarkGreen, new Point(block[2].Position.X, block[2].Position.Y), board);//1,1
            rotations[2][3] = new Block(Color.DarkGreen, new Point(block[3].Position.X + 1, block[3].Position.Y), board);//2,1
            
        }
        public override void Reset()
        {
            block = reset;
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
