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

        public Shape(IBoard board) {
            this.board = board;
            blocks = new Block[4];
            currentRotation = 0;
        }

        public Block[] Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }

        public IBoard Board
        {
            get { return board; }
        }
        public int Length
        {
            get { return blocks.Length; }
        }

        public Block this[int i]
        {
            get { return blocks[i]; }
        }

        public event JoinPileHandler JoinPile;

        public void MoveLeft() {
            foreach (Block b in blocks) {
                if (!b.tryMoveLeft())
                    return;
            }

            foreach (Block b in blocks) {
                b.MoveLeft();
            }
        }

        public void MoveRight() {
            foreach (Block b in blocks) {
                if (!b.tryMoveRight())
                    return;
            }

            foreach (Block b in blocks) {
                b.MoveRight();
            }
        }

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

        protected virtual void onJoinPile(IShape current) {
            if (JoinPile != null) {
                JoinPile(current);
            }
        }
    }
}
