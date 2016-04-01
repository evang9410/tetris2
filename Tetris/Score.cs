using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris {
    public class Score {
        private int level;
        private int lines;
        private int points;

        public Score(Board board) {
            board.LinesCleared += incrementLinesCleared;
            level = 1;
            lines = 0;
            points = 0;
        }
        public int Level
        {
            get { return level; }
        }
        public int Lines
        {
            get { return lines; }
        }
        public int Points
        {
            get { return points; }
        }

        /// <summary>
        /// Method incrementing the score
        /// </summary>
        /// <param name="num"></param>
        public void incrementLinesCleared(int num) {
            lines += num;
            points += num * num;
            level = Math.Min(lines / 10 + 1, 10);
        }

    }
}
