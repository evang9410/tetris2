using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Score
    {
        private int level;
        private int lines;
        private int scores;

        public Score(Board board)
        {    
            board.LinesCleared += incrementLinesCleared;
        }
        public int Level
        {
            get { return level; }
        }
        public int Lines
        {
            get { return lines; }
        }
        public int Scores
        {
            get { return scores; }
        }

        public void incrementLinesCleared(int num)
        {
            lines += num;
            scores += num * num;
            level = Math.Min(lines /10 + 1, 10);
        }
         
    }
}
