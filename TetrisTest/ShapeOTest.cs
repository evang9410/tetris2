using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeOTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeO so = new ShapeO(board);
            ShapeO soE = new ShapeO(board);

            // First rotation (initial)
            soE.Blocks[0] = new Block(Color.Yellow, new Point(0, 0), board);
            soE.Blocks[1] = new Block(Color.Yellow, new Point(1, 0), board);
            soE.Blocks[2] = new Block(Color.Yellow, new Point(0, 1), board);
            soE.Blocks[3] = new Block(Color.Yellow, new Point(1, 1), board);

            for (int i = 0; i < so.Blocks.Length; i++)
            {
                Assert.AreEqual(soE.Blocks[i].Position, so.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeO so = new ShapeO(board);
            ShapeO soE = new ShapeO(board);

            so.Rotate();
            so.Reset();

            for (int i = 0; i < so.Blocks.Length; i++)
            {
                Assert.AreEqual(soE.Blocks[i].Position, so.Blocks[i].Position);
            }
        }
    }
}
