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
        public ShapeI(IBoard board)
            : base(board)
        {
            blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            blocks[1] = new Block(Color.Aquamarine, new Point(0, 1), board);
            blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), board);
            blocks[3] = new Block(Color.Aquamarine, new Point(0, 3), board);
            
            block = blocks;
        }

        public override void Reset()
        {
            blocks[0].Position = new Point(0, 0);
            blocks[1].Position = new Point(0, 1);
            blocks[2].Position = new Point(0, 2);
            blocks[3].Position = new Point(0, 3);

            currentRotation = 0;
            block = blocks;
        }

        public override void Rotate()
        {
            if (currentRotation == 0)
            {
                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y);
                blocks[1].Position = new Point(blocks[1].Position.X + 1, blocks[1].Position.Y - 1);
                blocks[2].Position = new Point(blocks[2].Position.X + 2, blocks[2].Position.Y - 2);
                blocks[3].Position = new Point(blocks[3].Position.X + 3, blocks[3].Position.Y - 3);

                currentRotation = 1;
                block = blocks;
            }
            else if (currentRotation == 1)
            {
                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y);
                blocks[1].Position = new Point(blocks[1].Position.X - 1, blocks[1].Position.Y + 1);
                blocks[2].Position = new Point(blocks[2].Position.X - 2, blocks[2].Position.Y + 2);
                blocks[3].Position = new Point(blocks[3].Position.X - 3, blocks[3].Position.Y + 3);

                currentRotation = 0;
                block = blocks;
            }            
        }
    }
}
