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
        public ShapeS(IBoard board)
            : base(board)
        {
            blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            blocks[1] = new Block(Color.Tomato, new Point(1, 1), board);
            blocks[2] = new Block(Color.Tomato, new Point(1, 0), board);
            blocks[3] = new Block(Color.Tomato, new Point(2, 0), board);

            block = blocks;
        }

        public override void Reset()
        {
            blocks[0].Position = new Point(0, 1);
            blocks[1].Position = new Point(1, 1);
            blocks[2].Position = new Point(1, 0);
            blocks[3].Position = new Point(2, 0);

            currentRotation = 0;
            block = blocks;
        }

        public override void Rotate()
        {
            if (currentRotation == 0)
            {
                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y - 1);
                blocks[1].Position = new Point(blocks[1].Position.X - 1, blocks[1].Position.Y);
                blocks[2].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y + 1);
                blocks[3].Position = new Point(blocks[3].Position.X - 1, blocks[3].Position.Y + 2);

                currentRotation = 1;
                block = blocks;
            }
            else if (currentRotation == 1)
            {
                blocks[0].Position = new Point(blocks[0].Position.X, blocks[0].Position.Y + 1);
                blocks[1].Position = new Point(blocks[1].Position.X + 1, blocks[1].Position.Y);
                blocks[2].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y - 1);
                blocks[3].Position = new Point(blocks[3].Position.X + 1, blocks[3].Position.Y - 2);

                currentRotation = 0;
                block = blocks;
            }
        }
    }
}
