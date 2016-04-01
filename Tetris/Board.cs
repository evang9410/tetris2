using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public class Board : IBoard {
        private Color[,] board = new Color[10, 20];
        private IShape shape;
        private IShapeFactory shapeFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        public Board() {
            // Filling the board with black blocks
            for (int x = 0; x < board.GetLength(0); x++) {
                for (int y = 0; y < board.GetLength(1); y++) {
                    board[x, y] = Color.Black;
                }
            }

            // Making new shapeproxy and subscribing to events
            shapeFactory = new ShapeProxy(this);
            shapeFactory.DeployNewShape();
            this.shape = (IShape)shapeFactory;

            shape.JoinPile += addToPile;
        }

        public event LinesClearedHandler LinesCleared;

        /// <summary>
        /// Method handling line clearing
        /// </summary>
        /// <param name="lines"></param>
        protected virtual void onLinesCleared(int lines) {
            if (LinesCleared != null) {
                LinesCleared(lines);
            } 
        }


        public event GameOverHandler GameOver;

        /// <summary>
        /// Method handling game over
        /// </summary>
        /// <param name="isOver"></param>
        protected virtual void OnGameOver(bool isOver) {
            if (GameOver != null) {
                GameOver(isOver);
            }
        }

        /// <summary>
        /// Method getting the lenght of the board the desired rank
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        public int GetLength(int rank) {
            if (rank == 0) {
                return board.GetLength(rank);
            }
            return board.GetLength(1);


        }

        /// <summary>
        /// Method figuring out how many lines to clear
        /// </summary>
        /// <returns></returns>
        private int linesToClear() {
            int lines = 0;

            // Trying for every line and clearing them and incrementing if it is able to
            for (int i = board.GetLength(1) - 1; i > 0; i--) {
                if (tryClearLine(i)) {
                    lines++;
                    i++;
                }
            }

            return lines;
        }

        /// <summary>
        /// Method trying to clear lines found full
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool tryClearLine(int y) {
            // Checking if all blocks in row are black
            for (int i = 0; i < board.GetLength(0); i++) {
                if (board[i, y] == Color.Black) {
                    return false;
                }
            }

            // "Crunching" rows down one since it found a full row
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = y; j > 0; j--) {
                    board[i, j] = board[i, j - 1];
                }
            }

            return true;
        }

        /// <summary>
        /// Property accessor for shape
        /// </summary>
        IShape IBoard.Shape
        {
            get { return shape; }
        }

        /// <summary>
        /// Indexer returning color on board position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        Color IBoard.this[int x, int y]
        {
            get { return board[x, y]; }
        }

        /// <summary>
        /// Method adding shape to board(pile)
        /// </summary>
        /// <param name="shape"></param>
        private void addToPile(IShape shape) {
            // Adding the colors to the board since it was added to the pile
            for (int i = 0; i < this.shape.Length; i++) {
                board[shape[i].Position.X, shape[i].Position.Y] = shape[i].Color;
            }

            // Checking for lines cleared and updating score
            onLinesCleared(linesToClear());

            // Deploying a new shape
            shapeFactory.DeployNewShape();
            this.shape = shapeFactory.CurrentShape;

            gameOver();
        }

        /// <summary>
        /// Method checking if the game is over
        /// </summary>
        private void gameOver() {
            // Checking if there is enough space to spawn a block
            bool placeable = true;

            for (int i = 0; i < shape.Length; i++) {
                if (board[shape[i].Position.X, shape[i].Position.Y] != Color.Black) {
                    placeable = false;
                }
            }

            if (!placeable) {
                onGameOver();
            }
        }

        /// <summary>
        /// Method handling when game is over
        /// </summary>
        protected virtual void onGameOver() {
            if (GameOver != null) {
                GameOver(true);
            }
        }
    }
}
