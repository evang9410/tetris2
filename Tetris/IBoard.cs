using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public delegate void LinesClearedHandler(int lines);
    public delegate bool GameOverHandler(bool isOver);

    public interface IBoard {
        IShape Shape
        {
            get;
        }

        Color this[int x, int y]
        {
            get;
        }

        event LinesClearedHandler LinesCleared;
        event GameOverHandler GameOver;

        int GetLength(int rank);
    }

}
