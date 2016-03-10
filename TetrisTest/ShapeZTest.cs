using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeZTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeZ sz = new ShapeZ(board);
            ShapeZ szE = new ShapeZ(board);

            // First rotation
            szE.blocks[0] = new Block(Color.DarkGreen, new Point(0, 0), board);
            szE.blocks[1] = new Block(Color.DarkGreen, new Point(1, 0), board);
            szE.blocks[2] = new Block(Color.DarkGreen, new Point(1, 1), board);
            szE.blocks[3] = new Block(Color.DarkGreen, new Point(2, 1), board);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }

            // Rotating
            sz.Rotate();

            // Second rotation
            szE.blocks[0] = new Block(Color.DarkGreen, new Point(0, 1), board);
            szE.blocks[1] = new Block(Color.DarkGreen, new Point(0, 2), board);
            szE.blocks[2] = new Block(Color.DarkGreen, new Point(1, 1), board);
            szE.blocks[3] = new Block(Color.DarkGreen, new Point(1, 0), board);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeZ sz = new ShapeZ(board);
            ShapeZ szE = new ShapeZ(board);

            sz.Rotate();
            sz.Reset();

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
    }
}
