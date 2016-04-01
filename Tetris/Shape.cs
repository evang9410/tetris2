using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public abstract class Shape : IShape {
        private IBoard board;
        protected Block[] blocks;
        protected int currentRotation;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="board"></param>
        public Shape(IBoard board) {
            this.board = board;
            blocks = new Block[4];
            currentRotation = 0;
        }

        /// <summary>
        /// Property accessor for blocks
        /// </summary>
        public Block[] Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }

        /// <summary>
        /// Property accessor for board
        /// </summary>
        public IBoard Board
        {
            get { return board; }
        }

        /// <summary>
        /// Property accessor for lenght of blocks array
        /// </summary>
        public int Length
        {
            get { return blocks.Length; }
        }

        /// <summary>
        /// Indexer returning block in shape
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Block this[int i]
        {
            get { return blocks[i]; }
        }

        public event JoinPileHandler JoinPile;

        /// <summary>
        /// Method moving shape to the left
        /// </summary>
        public void MoveLeft() {
            foreach (Block b in blocks) {
                if (!b.tryMoveLeft())
                    return;
            }

            foreach (Block b in blocks) {
                b.MoveLeft();
            }
        }

        /// <summary>
        /// Method moving shape to the right
        /// </summary>
        public void MoveRight() {
            foreach (Block b in blocks) {
                if (!b.tryMoveRight())
                    return;
            }

            foreach (Block b in blocks) {
                b.MoveRight();
            }
        }

        /// <summary>
        /// Method moving shape down
        /// </summary>
        public void MoveDown() {
            foreach (Block b in blocks) {
                if (!b.tryMoveDown()) {
                    onJoinPile(this);
                    return;
                }
            }

            foreach (Block b in blocks) {
                b.MoveDown();
            }
        }

        /// <summary>
        /// Method moving shape to the bottom of the board
        /// </summary>
        public void Drop() {
            foreach (Block b in blocks) {
                if (!b.tryMoveDown()) {
                    return;
                }
            }

            foreach (Block b in blocks) {
                b.MoveDown();
            }

            this.Drop();
        }

        public abstract void Rotate();

        public abstract void Reset();

        /// <summary>
        /// Method handling when shape joins pile
        /// </summary>
        /// <param name="current"></param>
        protected virtual void onJoinPile(IShape current) {
            if (JoinPile != null) {
                JoinPile(current);
            }
        }
    }
}
