using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public delegate void JoinPileHandler();
    public interface IShape
    {
        

        int Length
        {
            get; 
        }

        Block this[int i]
        {
            get;
        }

        event JoinPileHandler JoinPile;

        void MoveLeft();
        void MoveRight();
        void MoveDown();
        void Drop();
        void Rotate();
        void Reset();
    }
}
