using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeLTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeL sl = new ShapeL(board);
            ShapeL slE = new ShapeL(board);

            // First rotation
            slE.blocks[0] = new Block(Color.Orange, new Point(0, 0), board);
            slE.blocks[1] = new Block(Color.Orange, new Point(0, 1), board);
            slE.blocks[2] = new Block(Color.Orange, new Point(0, 2), board);
            slE.blocks[3] = new Block(Color.Orange, new Point(1, 2), board);

            for (int i = 0; i < sl.blocks.Length; i++)
            {
                Assert.AreEqual(slE.blocks[i].Position, sl.blocks[i].Position);
            }

            // Rotating
            sl.Rotate();

            // Second rotation
            slE.blocks[0] = new Block(Color.Orange, new Point(0, 0), board);
            slE.blocks[1] = new Block(Color.Orange, new Point(0, 1), board);
            slE.blocks[2] = new Block(Color.Orange, new Point(1, 0), board);
            slE.blocks[3] = new Block(Color.Orange, new Point(2, 0), board);

            for (int i = 0; i < sl.blocks.Length; i++)
            {
                Assert.AreEqual(slE.blocks[i].Position, sl.blocks[i].Position);
            }

            // Rotating
            sl.Rotate();

            // Third rotation
            slE.blocks[0] = new Block(Color.Orange, new Point(1, 0), board);
            slE.blocks[1] = new Block(Color.Orange, new Point(2, 0), board);
            slE.blocks[2] = new Block(Color.Orange, new Point(2, 1), board);
            slE.blocks[3] = new Block(Color.Orange, new Point(2, 2), board);

            for (int i = 0; i < sl.blocks.Length; i++)
            {
                Assert.AreEqual(slE.blocks[i].Position, sl.blocks[i].Position);
            }

            // Rotating
            sl.Rotate();

            // Fourth rotation
            slE.blocks[0] = new Block(Color.Orange, new Point(2, 0), board);
            slE.blocks[1] = new Block(Color.Orange, new Point(2, 1), board);
            slE.blocks[2] = new Block(Color.Orange, new Point(1, 1), board);
            slE.blocks[3] = new Block(Color.Orange, new Point(0, 1), board);

            for (int i = 0; i < sl.blocks.Length; i++)
            {
                Assert.AreEqual(slE.blocks[i].Position, sl.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeL sl = new ShapeL(board);
            ShapeL slE = new ShapeL(board);

            sl.Rotate();
            sl.Reset();

            for (int i = 0; i < sl.blocks.Length; i++)
            {
                Assert.AreEqual(slE.blocks[i].Position, sl.blocks[i].Position);
            }
        }
    }
}
