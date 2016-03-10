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
            ShapeI shapeI = new ShapeI(null);
            ShapeI shapeITest = new ShapeI(null);
            
            // First rotation
            shapeITest.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            shapeITest.blocks[1] = new Block(Color.Aquamarine, new Point(0, 1), null);
            shapeITest.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            shapeITest.blocks[3] = new Block(Color.Aquamarine, new Point(0, 3), null);

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(shapeITest.blocks[i].Position, shapeI.blocks[i].Position);
            }

            // Rotating
            shapeI.Rotate();

            // Second rotation
            shapeITest.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            shapeITest.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            shapeITest.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            shapeITest.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(shapeITest.blocks[i].Position, shapeI.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            si.MoveLeft();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), null);

            si.MoveLeft();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), null);

            si.MoveRight();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(4, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(5, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), null);

            si.MoveRight();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), null);
            
            Assert.AreEqual(siE.blocks[3].Position, si.blocks[3].Position);
            
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), board);

            si.MoveDown();

            ShapeI siE = new ShapeI(board);
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
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);

            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 19), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 19), board);

            si.MoveDown();

            ShapeI siE = new ShapeI(board);
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
            IBoard board = new Board();
            ShapeI si = new ShapeI(board);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), board);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), board);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), board);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), board);

            si.Drop();

            ShapeI siE = new ShapeI(board);
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
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            si.Reset();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        
    }
}
