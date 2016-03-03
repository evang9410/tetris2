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

        public Block(Color colour)
        {
            this.colour = colour;
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
            if (Position.Y == 0)
                return false;
            return true;
        }
        public bool tryMoveRight()
        {
            if (Position.Y == board.GetLength(1))
                return false;
            return true;
        }
        public bool tryMoveDown()
        {
            Color c = board[Position.X, Position.Y];
            if (c != Color.Black)
                return true;
            return false;
        }
        public void TryRotate(Point offset)
        {
               
        }

        public void MoveLeft()
        {
            if (tryMoveLeft())
            {
                pos.Y -= 1;
            }
        }

        public void MoveRight()
        {
            if (tryMoveRight())
            {
                pos.Y += 1;
            }
        }

        public void MoveDown()
        {
            if (tryMoveDown())
            {
                pos.X -= 1;
            }
        }

        public void Rotate(Point offset)
        {
            pos = new Point(offset.X - pos.X - 1, offset.Y - pos.Y - 1); 
        }
      
    }
}
