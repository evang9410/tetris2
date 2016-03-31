using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeSTest
    { 
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            // First rotation
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(2, 0), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }

            // Rotating
            ss.Rotate();

            // Second rotation
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(0, 0), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(1, 2), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.Blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.Blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.Blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            ss.MoveLeft();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.Blocks[1] = new Block(Color.Tomato, new Point(3, 0), board);
            ss.Blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.Blocks[3] = new Block(Color.Tomato, new Point(2, 1), board);

            ss.MoveLeft();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(9, 0), board);
            ss.Blocks[1] = new Block(Color.Tomato, new Point(10, 0), board);
            ss.Blocks[2] = new Block(Color.Tomato, new Point(8, 1), board);
            ss.Blocks[3] = new Block(Color.Tomato, new Point(9, 1), board);

            ss.MoveRight();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(9, 0), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(10, 0), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(8, 1), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(9, 1), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Moveright()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.Blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.Blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.Blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            ss.MoveRight();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.Blocks[1] = new Block(Color.Tomato, new Point(3, 0), board);
            ssE.Blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.Blocks[3] = new Block(Color.Tomato, new Point(2, 1), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);

            ss.MoveDown();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(0, 2), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 2), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(2, 1), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ssE.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            ss.MoveDown();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ssE.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.Blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);

            ss.Drop();

            ssE.Blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ssE.Blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ssE.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.Rotate();
            ss.Reset();

            for (int i = 0; i < ss.Blocks.Length; i++)
            {
                Assert.AreEqual(ssE.Blocks[i].Position, ss.Blocks[i].Position);
            }
        }
    }
}
    

