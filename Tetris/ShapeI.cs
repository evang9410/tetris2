using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeI : Shape
    {
        private Block[][] rotations = new Block[3][];
        private Block[] reset;
        public ShapeI(IBoard board)
            : base(board)
        {
            for(int i = 0 ; i < 3; i++)
                rotations[i] = new Block[4];

            rotations[0][0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            rotations[0][1] = new Block(Color.Aquamarine, new Point(0, 1), board);
            rotations[0][2] = new Block(Color.Aquamarine, new Point(0, 2), board);
            rotations[0][3] = new Block(Color.Aquamarine, new Point(0, 3), board);
            block = rotations[0];
            reset = rotations[0];

            rotations[1][0] = new Block(Color.Aquamarine, new Point(block[0].Position.X, block[0].Position.Y), board); //0,0
            rotations[1][1] = new Block(Color.Aquamarine, new Point(block[1].Position.X + 1, block[1].Position.Y - 1), board);//1,0
            rotations[1][2] = new Block(Color.Aquamarine, new Point(block[2].Position.X + 2, block[2].Position.Y - 2), board);//2,0
            rotations[1][3] = new Block(Color.Aquamarine, new Point(block[3].Position.X + 3, block[3].Position.Y - 3), board);//3,0
            
            //back to normal.
            rotations[2][0] = new Block(Color.Aquamarine, new Point(block[0].Position.X, block[0].Position.Y), board);//0,0
            rotations[2][1] = new Block(Color.Aquamarine, new Point(block[1].Position.X - 1, block[1].Position.Y + 1), board);//0,1
            rotations[2][2] = new Block(Color.Aquamarine, new Point(block[2].Position.X - 2, block[2].Position.Y + 2), board);//0,2
            rotations[2][3] = new Block(Color.Aquamarine, new Point(block[3].Position.X - 3, block[3].Position.Y + 3), board);//0,3

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
            else if (currentRotation == 1)
            {
                block = rotations[2];
                currentRotation = 0;
            }
            else
            {
                block = rotations[2];
                currentRotation = 0;
            }
            
        }

    }
}
