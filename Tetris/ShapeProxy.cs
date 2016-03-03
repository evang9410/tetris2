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

        public ShapeProxy(Board board,Shape current)
        {
            this.board = board;
            this.current = current;
            
        }

        public virtual void OnJoinPile()
        {

        }

        public void DeployNewShape()
        {
            throw new NotImplementedException();
        }

        public int Length
        {
            get { return rnd.Next(2, 6); }
        }

        public Block this[int i]
        {
            get;
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
