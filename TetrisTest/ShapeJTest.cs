using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeJTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeJ sj = new ShapeJ(board);
            ShapeJ sjE = new ShapeJ(board);

            // Rotating
            sj.Rotate();

            // First rotation
            sjE.Blocks[0] = new Block(Color.HotPink, new Point(2, 1), board);
            sjE.Blocks[1] = new Block(Color.HotPink, new Point(1, 1), board);
            sjE.Blocks[2] = new Block(Color.HotPink, new Point(0, 1), board);
            sjE.Blocks[3] = new Block(Color.HotPink, new Point(0, 0), board);

            for (int i = 0; i < sj.Blocks.Length; i++)
            {
                Assert.AreEqual(sjE.Blocks[i].Position, sj.Blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();

            // Second rotation
            sjE.Blocks[0] = new Block(Color.HotPink, new Point(0, 2), board);
            sjE.Blocks[1] = new Block(Color.HotPink, new Point(0, 1), board);
            sjE.Blocks[2] = new Block(Color.HotPink, new Point(0, 0), board);
            sjE.Blocks[3] = new Block(Color.HotPink, new Point(1, 0), board);

            for (int i = 0; i < sj.Blocks.Length; i++)
            {
                Assert.AreEqual(sjE.Blocks[i].Position, sj.Blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();
            
            // Third rotation
            sjE.Blocks[0] = new Block(Color.HotPink, new Point(0, 0), board);
            sjE.Blocks[1] = new Block(Color.HotPink, new Point(1, 0), board);
            sjE.Blocks[2] = new Block(Color.HotPink, new Point(2, 0), board);
            sjE.Blocks[3] = new Block(Color.HotPink, new Point(2, 1), board);

            for (int i = 0; i < sj.Blocks.Length; i++)
            {
                Assert.AreEqual(sjE.Blocks[i].Position, sj.Blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();

            // Fourth rotation (initial)
            sjE.Blocks[0] = new Block(Color.HotPink, new Point(1, 0), board);
            sjE.Blocks[1] = new Block(Color.HotPink, new Point(1, 1), board);
            sjE.Blocks[2] = new Block(Color.HotPink, new Point(1, 2), board);
            sjE.Blocks[3] = new Block(Color.HotPink, new Point(0, 2), board);

            for (int i = 0; i < sj.Blocks.Length; i++)
            {
                Assert.AreEqual(sjE.Blocks[i].Position, sj.Blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeJ sj = new ShapeJ(board);
            ShapeJ sjE = new ShapeJ(board);

            sj.Rotate();
            sj.Reset();

            for (int i = 0; i < sj.Blocks.Length; i++)
            {
                Assert.AreEqual(sjE.Blocks[i].Position, sj.Blocks[i].Position);
            }
        }
    }
}
