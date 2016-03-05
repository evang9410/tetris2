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
            throw new NotImplementedException();
        }

        public void MovdRight()
        {
            throw new NotImplementedException();
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
