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
        private Block[] blocks = new Block[4];
        public ShapeO(IBoard board)
            : base(board)
        {
            // Initial pos
            blocks[0] = new Block(Color.Yellow, new Point(0, 0), board);
            blocks[1] = new Block(Color.Yellow, new Point(1, 0), board);
            blocks[2] = new Block(Color.Yellow, new Point(0, 1), board);
            blocks[3] = new Block(Color.Yellow, new Point(1, 1), board);

            block = blocks;
        }
        public override void Reset()
        {
            blocks[0].Position = new Point(0, 0);
            blocks[1].Position = new Point(1, 0);
            blocks[2].Position = new Point(0, 1);
            blocks[3].Position = new Point(1, 1);

            currentRotation = 0;
            block = blocks;
        }

        public override void Rotate()
        {
            this.Reset();
        }
    }
}
