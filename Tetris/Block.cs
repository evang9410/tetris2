using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public class Block {
        private IBoard board;
        private Color color;
        private Point pos;
        private Color[,] col = new Color[10, 20];

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color"></param>
        /// <param name="pos"></param>
        /// <param name="board"></param>
        public Block(Color color, Point pos, IBoard board) {
            this.board = board;
            this.color = color;
            this.pos = pos;
        }

        /// <summary>
        /// Property accessor for color
        /// </summary>
        public Color Color
        {
            get { return color; }
        }

        /// <summary>
        /// Property accessor for position
        /// </summary>
        public Point Position
        {
            get { return pos; }
            set { pos = value; }
        }

        /// <summary>
        /// Method checking if block is able to move left
        /// </summary>
        /// <returns></returns>
        public bool tryMoveLeft() {
            // Bounds checking
            if (Position.X <= 0 || board[Position.X - 1, Position.Y] != Color.Black)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Method moving the block to the left
        /// </summary>
        public void MoveLeft() {
            if (tryMoveLeft()) {
                pos.X -= 1;
            }
        }

        /// <summary>
        /// Method checking if block is able to move right
        /// </summary>
        /// <returns></returns>
        public bool tryMoveRight() {
            // Bounds checking
            if (Position.X >= board.GetLength(0) - 1 || board[Position.X + 1, Position.Y] != Color.Black)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Method moving the block to the right
        /// </summary>
        public void MoveRight() {
            if (tryMoveRight()) {
                pos.X += 1;
            }
        }

        /// <summary>
        /// Method checking if block is able to move down
        /// </summary>
        /// <returns></returns>
        public bool tryMoveDown() {
            // Bounds checking
            if (Position.Y + 1 >= board.GetLength(1)) {
                return false;
            }

            // Check color under to know if it can move down or not
            if (board[Position.X, Position.Y + 1] == Color.Black)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method moving the block down
        /// </summary>
        public void MoveDown() {
            if (tryMoveDown()) {
                pos.Y += 1;
            }
        }
    }
}
