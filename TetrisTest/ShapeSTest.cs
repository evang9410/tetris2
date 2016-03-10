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
            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(2, 0), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

            // Rotating
            ss.Rotate();

            // Second rotation
            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 0), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(1, 2), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            ss.MoveLeft();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.blocks[1] = new Block(Color.Tomato, new Point(3, 0), board);
            ss.blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.blocks[3] = new Block(Color.Tomato, new Point(2, 1), board);

            ss.MoveLeft();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(9, 0), board);
            ss.blocks[1] = new Block(Color.Tomato, new Point(10, 0), board);
            ss.blocks[2] = new Block(Color.Tomato, new Point(8, 1), board);
            ss.blocks[3] = new Block(Color.Tomato, new Point(9, 1), board);

            ss.MoveRight();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(9, 0), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(10, 0), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(8, 1), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(9, 1), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Moveright()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.blocks[1] = new Block(Color.Tomato, new Point(2, 0), board);
            ss.blocks[2] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.blocks[3] = new Block(Color.Tomato, new Point(1, 1), board);

            ss.MoveRight();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);
            ssE.blocks[1] = new Block(Color.Tomato, new Point(3, 0), board);
            ssE.blocks[2] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.blocks[3] = new Block(Color.Tomato, new Point(2, 1), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);

            ss.MoveDown();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 2), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 2), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(2, 1), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ssE.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            ss.MoveDown();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ssE.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeS ss = new ShapeS(board);
            ShapeS ssE = new ShapeS(board);

            ss.blocks[0] = new Block(Color.Tomato, new Point(0, 1), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 1), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(1, 0), board);
            ss.blocks[0] = new Block(Color.Tomato, new Point(2, 0), board);

            ss.Drop();

            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 19), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 19), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(1, 18), board);
            ssE.blocks[0] = new Block(Color.Tomato, new Point(2, 18), board);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ssE.blocks[i].Position);
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

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
    }
}
    

