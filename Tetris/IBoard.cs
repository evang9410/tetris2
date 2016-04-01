using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public delegate void LinesClearedHandler(int lines);
    public delegate bool GameOverHandler(bool isOver);

    /// <summary>
    /// Properties
    /// </summary>
    public interface IBoard {
        IShape Shape
        {
            get;
        }
        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Color this[int x, int y]
        {
            get;
        }
        /// <summary>
        /// Events
        /// </summary>
        event LinesClearedHandler LinesCleared;
        event GameOverHandler GameOver;

        /// <summary>
        /// Methods
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        int GetLength(int rank);

    }

}
