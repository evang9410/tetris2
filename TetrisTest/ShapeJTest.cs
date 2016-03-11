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
            sjE.blocks[0] = new Block(Color.HotPink, new Point(2, 1), board);
            sjE.blocks[1] = new Block(Color.HotPink, new Point(1, 1), board);
            sjE.blocks[2] = new Block(Color.HotPink, new Point(0, 1), board);
            sjE.blocks[3] = new Block(Color.HotPink, new Point(0, 0), board);

            for (int i = 0; i < sj.blocks.Length; i++)
            {
                Assert.AreEqual(sjE.blocks[i].Position, sj.blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();

            // Second rotation
            sjE.blocks[0] = new Block(Color.HotPink, new Point(0, 2), board);
            sjE.blocks[1] = new Block(Color.HotPink, new Point(0, 1), board);
            sjE.blocks[2] = new Block(Color.HotPink, new Point(0, 0), board);
            sjE.blocks[3] = new Block(Color.HotPink, new Point(1, 0), board);

            for (int i = 0; i < sj.blocks.Length; i++)
            {
                Assert.AreEqual(sjE.blocks[i].Position, sj.blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();
            
            // Third rotation
            sjE.blocks[0] = new Block(Color.HotPink, new Point(0, 0), board);
            sjE.blocks[1] = new Block(Color.HotPink, new Point(1, 0), board);
            sjE.blocks[2] = new Block(Color.HotPink, new Point(2, 0), board);
            sjE.blocks[3] = new Block(Color.HotPink, new Point(2, 1), board);

            for (int i = 0; i < sj.blocks.Length; i++)
            {
                Assert.AreEqual(sjE.blocks[i].Position, sj.blocks[i].Position);
            }
            
            // Rotating
            sj.Rotate();

            // Fourth rotation (initial)
            sjE.blocks[0] = new Block(Color.HotPink, new Point(1, 0), board);
            sjE.blocks[1] = new Block(Color.HotPink, new Point(1, 1), board);
            sjE.blocks[2] = new Block(Color.HotPink, new Point(1, 2), board);
            sjE.blocks[3] = new Block(Color.HotPink, new Point(0, 2), board);

            for (int i = 0; i < sj.blocks.Length; i++)
            {
                Assert.AreEqual(sjE.blocks[i].Position, sj.blocks[i].Position);
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

            for (int i = 0; i < sj.blocks.Length; i++)
            {
                Assert.AreEqual(sjE.blocks[i].Position, sj.blocks[i].Position);
            }
        }
    }
}
