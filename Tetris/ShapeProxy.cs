using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeProxy: IShape, IShapeFactory
    {
        private static Random rnd;
        private IShape current;
        private IBoard board;

        public ShapeProxy(IBoard board)
        {
            this.board = board;
            rnd = new Random();
        }

        public IShape CurrentShape
        {
            get { return current; }
        }

        public void DeployNewShape()
        {
            int shape = rnd.Next(0, 7);
            
            switch (shape)
            {
                case 0: 
                    current = new ShapeI(board);
                    break;
                case 1:
                    current = new ShapeJ(board);
                    break;
                case 2:
                    current = new ShapeL(board);
                    break;
                case 3:
                    current = new ShapeO(board);
                    break;
                case 4:
                    current = new ShapeS(board);
                    break;
                case 5:
                    current = new ShapeT(board);
                    break;
                case 6:
                    current = new ShapeZ(board);
                    break;
            }

            current.JoinPile += onJoinPile;
        }

        public int Length
        {
            get { return current.Length; }
        }

        public Block this[int i]
        {
            get { return current[i]; }
        }

        public event JoinPileHandler JoinPile;
        protected virtual void onJoinPile(IShape current)
        {
            if (JoinPile != null)
            {
                JoinPile(current);
            }
        }

        public void MoveLeft()
        { 
            current.MoveLeft();
        }

        public void MoveRight()
        {
           current.MoveRight();
 
        }

        public void MoveDown()
        {
            current.MoveDown();
        }

        public void Drop()
        {
            current.Drop();
        }

        public void Rotate()
        {
            current.Rotate();
        }

        public void Reset()
        {
            current.Reset();
        }
    }
}
