using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public abstract class Shape: IShape
    {
        private IBoard board;
        protected Block[] block;
        protected Point[,] rotationOffset;
        protected int currentRotation;
        public Shape(IBoard board)
        {
            this.board = board;
            block = new Block[4];
            currentRotation = 0;
        }
        public Block[] blocks
        {
            get { return block; }
            set { block = value; }
        }
        public int Length
        {
            get { return block.Length; }
        }

        public Block this[int i]
        {
            get { return block[i]; }
        }

        public event JoinPileHandler JoinPile;

        public void MoveLeft() 
        {
            /*for(int i = 0; i <block.Length;i++)
            {
                if (block[i].tryMoveLeft())
                {
                    block[i].MoveLeft();
                }
                else
                    break;
            }*/
            foreach (Block b in blocks)
            {
                if (!b.tryMoveLeft())
                    return;
            }
            foreach (Block b in blocks)
            {
                b.MoveLeft();
            }
        }

        public void MoveRight()
        {
            foreach (Block b in blocks)
            {
                if (!b.tryMoveRight())
                    return;
            }
            foreach (Block b in blocks)
            {
                b.MoveRight();
            }
        }

        public void MoveDown()
        {
            foreach (Block b in blocks)
            {
                if (!b.tryMoveDown())
                    return;
            }
            foreach (Block b in blocks)
            {
                b.MoveDown();
            }
            
        }

        public void Drop() 
        {
            bool movedown = true;

            foreach (Block b in blocks)
            {
                if (!b.tryMoveDown())
                {
                    movedown = false;
                }
            }

            if (movedown)
            {
                foreach (Block b in blocks)
                {
                    b.MoveDown();
                }

                this.Drop();
            }
        }

        public abstract void Rotate();

        public abstract void Reset();
    }
}
