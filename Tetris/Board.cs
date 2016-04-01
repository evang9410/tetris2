using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public class Board : IBoard {
        //2-d Arrary position 0,0 top-left, representing x,y
        private Color[,] board = new Color[10, 20];
        private IShape shape;
        private IShapeFactory shapeFactory;

        public Board() {
            for (int x = 0; x < board.GetLength(0); x++) {
                for (int y = 0; y < board.GetLength(1); y++) {
                    board[x, y] = Color.Black;
                }
            }

            shapeFactory = new ShapeProxy(this);
            shapeFactory.DeployNewShape();
            this.shape = (IShape)shapeFactory;

            shape.JoinPile += addToPile;
        }

        public event LinesClearedHandler LinesCleared;

        protected virtual void onLinesCleared(int lines) {
            if (LinesCleared != null)
                LinesCleared(lines);
        }


        public event GameOverHandler GameOver;
        protected virtual void OnGameOver(bool isOver) {
            if (GameOver != null) {
                GameOver(isOver);
            }
        }

        public int GetLength(int rank) {
            if (rank == 0) {
                return board.GetLength(rank);
            }
            return board.GetLength(1);


        }

        private int linesToClear() {
            int lines = 0;

            for (int i = board.GetLength(1) - 1; i > 0; i--) {
                if (tryClearLine(i)) {
                    lines++;
                    i++;
                }
            }

            return lines;
        }

        private bool tryClearLine(int y) {
            for (int i = 0; i < board.GetLength(0); i++) {
                if (board[i, y] == Color.Black) {
                    return false;
                }
            }

            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = y; j > 0; j--) {
                    board[i, j] = board[i, j - 1];
                }
            }

            return true;
        }

        IShape IBoard.Shape
        {
            get { return shape; }
        }

        Color IBoard.this[int x, int y]
        {
            get { return board[x, y]; }
        }

        private void addToPile(IShape shape) {
            for (int i = 0; i < this.shape.Length; i++) {
                board[shape[i].Position.X, shape[i].Position.Y] = shape[i].Color;
            }

            onLinesCleared(linesToClear());

            shapeFactory.DeployNewShape();
            this.shape = shapeFactory.CurrentShape;

            gameOver();
        }

        private void gameOver() {
            bool placeable = true;
            for (int i = 0; i < shape.Length; i++) {
                if (!board[shape[i].Position.X, shape[i].Position.Y].Equals(Color.Black)) {
                    placeable = false;
                }
            }
            if (!placeable) {
                onGameOver();
            }
        }

        protected virtual void onGameOver() {
            if (GameOver != null) {
                GameOver(true);
            }
        }
    }
}
