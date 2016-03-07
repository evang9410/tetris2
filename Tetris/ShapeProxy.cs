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

        public ShapeProxy(IBoard board, IShape current)
        {
            this.board = board;
            this.current = current;
            
        }

        public virtual void OnJoinPile()
        {
            if(JoinPile != null)
            {
                JoinPile();
            }

        }

        public void DeployNewShape()
        {
            int shape = rnd.Next(0, 7);

            switch (shape)
            {
                case 0: 
                    current = new ShapeI();
                    break;
                case 1:
                    current = new ShapeJ();
                    break;
                case 2:
                    current = new ShapeL();
                    break;
                case 3:
                    current = new ShapeO();
                    break;
                case 4:
                    current = new ShapeS();
                    break;
                case 5:
                    current = new ShapeT();
                    break;
                case 6:
                    current = new ShapeZ();
                    break;
            }
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

        public void MoveLeft()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveLeft();
            }
        }

        public void MoveRight()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveRight();
            }
        }

        public void MoveDown()
        {
            for (int i = 0; i < current.Length; i++)
            {
                current[i].MoveDown();
            }
        }

        public void Drop()
        {
            
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
