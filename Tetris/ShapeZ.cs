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
        private Block[] blocks = new Block[4];
        public ShapeZ(IBoard board)
            : base(board)
        {
            // Initial pos
            blocks[0] = new Block(Color.DarkGreen, new Point(0, 0), board);
            blocks[1] = new Block(Color.DarkGreen, new Point(1, 0), board);
            blocks[2] = new Block(Color.DarkGreen, new Point(1, 1), board);
            blocks[3] = new Block(Color.DarkGreen, new Point(2, 1), board);

            block = blocks;
        }
        public override void Reset()
        {
            blocks[0].Position = new Point(0, 0);
            blocks[1].Position = new Point(1, 0);
            blocks[2].Position = new Point(1, 1);
            blocks[3].Position = new Point(2, 1);

            currentRotation = 0;
            block = blocks;
        }

        public override void Rotate()
        {
            if (currentRotation == 0)
            {
                //blocks[1][0] = new Block(Color.DarkGreen, new Point(block[0].Position.X, block[0].Position.Y + 1), board);//0,1
                //blocks[1][1] = new Block(Color.DarkGreen, new Point(block[1].Position.X - 1, block[1].Position.Y + 2), board);//0,2
                //blocks[1][2] = new Block(Color.DarkGreen, new Point(block[2].Position.X, block[2].Position.Y), board);//1,1
                //blocks[1][3] = new Block(Color.DarkGreen, new Point(block[3].Position.X - 1, block[3].Position.Y - 1), board);//1,0

                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y + 1);
                blocks[1].Position = new Point(blocks[1].Position.X - 1, blocks[1].Position.Y + 2);
                blocks[2].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y);
                blocks[3].Position = new Point(blocks[3].Position.X - 1, blocks[3].Position.Y - 1);

                currentRotation = 1;
                block = blocks;
            }
            else if (currentRotation == 1)
            {
                //blocks[2][0] = new Block(Color.DarkGreen, new Point(block[0].Position.X, block[0].Position.Y - 1), board);//0,0
                //blocks[2][1] = new Block(Color.DarkGreen, new Point(block[1].Position.X + 1, block[1].Position.Y - 2), board);//1,0
                //blocks[2][2] = new Block(Color.DarkGreen, new Point(block[2].Position.X, block[2].Position.Y), board);//1,1
                //blocks[2][3] = new Block(Color.DarkGreen, new Point(block[3].Position.X + 1, block[3].Position.Y), board);//2,1

                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y - 1);
                blocks[1].Position = new Point(blocks[1].Position.X + 1, blocks[1].Position.Y - 2);
                blocks[2].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y);
                blocks[3].Position = new Point(blocks[3].Position.X + 1, blocks[3].Position.Y);

                currentRotation = 0;
                block = blocks;
            }
        }
    }
}
