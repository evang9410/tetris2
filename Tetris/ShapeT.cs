using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public class ShapeT : Shape {
        public ShapeT(IBoard board)
            : base(board) {
            Blocks[0] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2, 0), Board);
            Blocks[1] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 1, 0), Board);
            Blocks[2] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 2, 0), Board);
            Blocks[3] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 1, 1), Board);
        }

        public override void Reset() {
            Blocks[0] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2, 0), Board);
            Blocks[1] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 1, 0), Board);
            Blocks[2] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 2, 0), Board);
            Blocks[3] = new Block(Color.Purple, new Point(Board.GetLength(0) / 2 + 1, 1), Board);

            currentRotation = 0;
        }

        public override void Rotate() {
            if (currentRotation == 0 && Blocks[0].Position.Y <= Board.GetLength(1) - 2) {
                Blocks[0].Position = new Point(Blocks[0].Position.X + 1, Blocks[0].Position.Y);
                Blocks[1].Position = new Point(Blocks[1].Position.X, Blocks[1].Position.Y + 1);
                Blocks[2].Position = new Point(Blocks[2].Position.X - 1, Blocks[2].Position.Y + 2);
                Blocks[3].Position = new Point(Blocks[3].Position.X - 1, Blocks[3].Position.Y);

                currentRotation = 1;
            } else if (currentRotation == 1 && Blocks[0].Position.X <= Board.GetLength(0) - 2) {
                Blocks[0].Position = new Point(Blocks[0].Position.X + 1, Blocks[0].Position.Y + 1);
                Blocks[1].Position = new Point(Blocks[1].Position.X, Blocks[1].Position.Y);
                Blocks[2].Position = new Point(Blocks[2].Position.X - 1, Blocks[2].Position.Y - 1);
                Blocks[3].Position = new Point(Blocks[3].Position.X + 1, Blocks[3].Position.Y - 1);

                currentRotation = 2;
            } else if (currentRotation == 2 && Blocks[0].Position.Y <= Board.GetLength(1) - 3) {
                Blocks[0].Position = new Point(Blocks[0].Position.X - 2, Blocks[0].Position.Y + 1);
                Blocks[1].Position = new Point(Blocks[1].Position.X - 1, Blocks[1].Position.Y);
                Blocks[2].Position = new Point(Blocks[2].Position.X, Blocks[2].Position.Y - 1);
                Blocks[3].Position = new Point(Blocks[3].Position.X, Blocks[3].Position.Y + 1);

                currentRotation = 3;
            } else if (currentRotation == 3 && Blocks[0].Position.X <= Board.GetLength(0) - 3) {
                Blocks[0].Position = new Point(Blocks[0].Position.X, Blocks[0].Position.Y - 2);
                Blocks[1].Position = new Point(Blocks[1].Position.X + 1, Blocks[1].Position.Y - 1);
                Blocks[2].Position = new Point(Blocks[2].Position.X + 2, Blocks[2].Position.Y);
                Blocks[3].Position = new Point(Blocks[3].Position.X, Blocks[3].Position.Y);

                currentRotation = 0;
            }
        }
    }
}
