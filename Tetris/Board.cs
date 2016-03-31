using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class Board: IBoard
    {
        //2-d Arrary position 0,0 top-left, representing x,y
        private Color[,] board = new Color[10, 20];
        private IShape shape;
        private IShapeFactory shapeFactory;

        public Board()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    board[x, y] = Color.Black;
                }
            }
            
            shapeFactory = new ShapeProxy(this);
            shapeFactory.DeployNewShape();
            this.shape = (IShape)shapeFactory;

            shape.JoinPile += addToPile;
        }

        public event LinesClearedHandler LinesCleared;

        protected virtual void onLinesCleared(int lines)
        {    
            if (LinesCleared != null)
                LinesCleared(lines);
        }
      

        public event GameOverHandler GameOver;
        protected virtual void OnGameOver(bool isOver)
        {
            if (GameOver != null)
            {
                GameOver(isOver);
            }
        }

        public int GetLength(int rank)
        {
            if (rank == 0)
            {
                return board.GetLength(rank);
            }
            return board.GetLength(1);
           
            
        }

        private int linesToClear()
        {
           //call method that adds current shape to board
            addToPile(shape);
            int x = board.GetLength(0);
            int y = board.GetLength(1);
            int colored_blocks = 0;
            int lines = 0;
            for (; x >= 0 ; x--)
            {
               
                for (y = board.GetLength(1); y >= 0; y--)
                {
                    if (board[x, y] != Color.Black)
                    {
                        colored_blocks++;
                        
                    }
                }
                if (colored_blocks == board.GetLength(1))
                {
                    lines++;
                    clearLine(x);

                }
                colored_blocks = 0;
            }
            if(lines >= 1)
                onLinesCleared(lines);
            
           shapeFactory.DeployNewShape();
           return lines;
        }

        private void clearLine(int x)
        {
            for (; x >= 0; x--)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (x == 0)
                    {
                        board[x, y] = Color.Black;
                    }
                    else
                        //unsure if its x - 1 or y - 1
                        board[x, y] = board[x - 1, y];
                }
            }
        }

        IShape IBoard.Shape
        {
            get { return shape; }
        }

        Color IBoard.this[int x, int y]
        {
            get { return board[x, y]; }
        }

        private void addToPile(IShape shape)
        {
            bool placeable = true;

            for(int i = 0; i < shape.Length; i++)
            {
                if (!board[shape[i].Position.X, shape[i].Position.Y].Equals(Color.Black))
                {
                    placeable = false;
                    this.GameOver(!placeable);
                }
            }

            if (placeable)
            {
                linesToClear();
                
                shapeFactory.DeployNewShape();
                this.shape = (IShape)shapeFactory;

                shape.JoinPile += addToPile;
                
            }
        }
    }
}
