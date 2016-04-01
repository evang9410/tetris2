using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris {
    public class ShapeProxy : IShape, IShapeFactory {
        private static Random rnd;
        private IShape current;
        private IBoard board;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="board"></param>
        public ShapeProxy(IBoard board) {
            this.board = board;
            rnd = new Random();
        }

        /// <summary>
        /// Property accessor for current shape
        /// </summary>
        public IShape CurrentShape
        {
            get { return current; }
        }

        /// <summary>
        /// Method making new shape to interact with
        /// </summary>
        public void DeployNewShape() {
            // Get random number to get a shape
            int shape = rnd.Next(0, 7);

            switch (shape) {
                case 0:
                    current = new ShapeI(board);
                    break;
                case 1:
                    current = new ShapeJ(board);
                    break;
                case 2:
                    current = new ShapeL(board);
                    break;
                case 3:
                    current = new ShapeO(board);
                    break;
                case 4:
                    current = new ShapeS(board);
                    break;
                case 5:
                    current = new ShapeT(board);
                    break;
                case 6:
                    current = new ShapeZ(board);
                    break;
            }

            current.JoinPile += onJoinPile;
        }

        /// <summary>
        /// Property accessor for shape array lenght
        /// </summary>
        public int Length
        {
            get { return current.Length; }
        }

        /// <summary>
        /// Indexer to get block in shape
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Block this[int i]
        {
            get { return current[i]; }
        }

        public event JoinPileHandler JoinPile;

        /// <summary>
        /// Method handling when shape joins the pile
        /// </summary>
        /// <param name="current"></param>
        protected virtual void onJoinPile(IShape current) {
            if (JoinPile != null) {
                JoinPile(current);
            }
        }

        /// <summary>
        /// Method moving current shape to the left
        /// </summary>
        public void MoveLeft() {
            current.MoveLeft();
        }

        /// <summary>
        /// Method moving current shape to the right
        /// </summary>
        public void MoveRight() {
            current.MoveRight();

        }

        /// <summary>
        /// Method moving current shape down
        /// </summary>
        public void MoveDown() {
            current.MoveDown();
        }

        /// <summary>
        /// Method moving current shape to the bottom of the board
        /// </summary>
        public void Drop() {
            current.Drop();
        }

        /// <summary>
        /// Method rotating current shape
        /// </summary>
        public void Rotate() {
            current.Rotate();
        }

        /// <summary>
        /// Method reseting current shape
        /// </summary>
        public void Reset() {
            current.Reset();
        }
    }
}
