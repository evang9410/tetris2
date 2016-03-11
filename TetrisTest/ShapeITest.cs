using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeITest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            // Rotating
            si.Rotate();

            // First rotation
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }

            // Rotating
            si.Rotate();

            // Second rotation (initial)
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(0, 1), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(0, 3), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            si.MoveLeft();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), board);

            si.MoveLeft();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {

            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), board);

            si.MoveRight();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(4, 0), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(5, 0), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), board);

            si.MoveRight();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
            
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), board);

            si.MoveDown();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 1), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 1), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 19), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 19), board);

            si.MoveDown();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 19), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 19), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            si.Drop();

            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19), board);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19), board);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 19), board);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 19), board);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            ShapeI siE = new ShapeI(board);

            si.Rotate();
            si.Reset();

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
    }
}
