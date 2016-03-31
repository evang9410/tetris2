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
        public ShapeO(IBoard board)
            : base(board)
        {
            Blocks[0] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2, 0), Board);
            Blocks[1] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2 + 1, 0), Board);
            Blocks[2] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2, 1), Board);
            Blocks[3] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2 + 1, 1), Board);
        }

        public override void Reset()
        {
            Blocks[0] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2, 0), Board);
            Blocks[1] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2 + 1, 0), Board);
            Blocks[2] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2, 1), Board);
            Blocks[3] = new Block(Color.Yellow, new Point(Board.GetLength(0) / 2 + 1, 1), Board);

            currentRotation = 0;
        }

        public override void Rotate()
        {
            this.Reset();
        }
    }
}
