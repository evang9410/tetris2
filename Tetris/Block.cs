using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class Block
    {
        /// <summary>
        /// ShapeO = Color.Yellow
        /// ShapeI = Color.Aquamarine
        /// ShapeS = Color.Tomato
        /// ShapeZ = Color.DarkGreen
        /// ShapeL = Color.Orange
        /// ShapeJ = Color.HotPink
        /// ShapeT = Color.Purple
        /// </summary>
        private IBoard board;
        private Color colour;
        private Point pos;
        private Color[,] col = new Color[10, 20];

        public Block(Color colour, Point pos, IBoard board)
        {
            this.board = board;
            this.colour = colour;
            this.pos = pos;
        }

        public Color Colour
        {
            get { return colour; }
        }

        public Point Position
        {
            get { return pos; }
            set { pos = value; }
        }

        public bool tryMoveLeft()
        {
            if (Position.X <= 0)
                return false;
            else
                return true;
        }
        public bool tryMoveRight()
        {
            if (Position.X >= 10)
                return false;
            else
                return true;
        }
        public bool tryMoveDown()
        {
            if (Position.Y >= 19)
            {
                return false;
            }

            Color blockUnder = board[Position.X, Position.Y + 1];

            if (blockUnder == Color.Black)
                return true;
            else
                return false;
        }
        public void TryRotate(Point offset)
        {

        }

        public void MoveLeft()
        {
            if (tryMoveLeft())
            {
                pos.X -= 1;
            }
        }

        public void MoveRight()
        {
            if (tryMoveRight())
            {
                pos.X += 1;
            }
        }

        public void MoveDown()
        {
            if (tryMoveDown())
            {
                pos.Y += 1;
            }
        }

        public void Rotate(Point offset)
        {
            pos = new Point(offset.X - pos.X - 1, offset.Y - pos.Y - 1);
        }
        public override bool Equals(object obj)
        {
            return true;//base.Equals(obj);
        }
    }
}
