using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeTTest
    {
        [TestMethod]
        public void Test_Rotations()
        {
            // Init
            IBoard board = new Board();
            ShapeT st = new ShapeT(board);
            ShapeT stE = new ShapeT(board);

            // First rotation
            stE.blocks[0] = new Block(Color.Purple, new Point(0, 0), board);
            stE.blocks[1] = new Block(Color.Purple, new Point(1, 0), board);
            stE.blocks[2] = new Block(Color.Purple, new Point(2, 0), board);
            stE.blocks[3] = new Block(Color.Purple, new Point(1, 1), board);

            for (int i = 0; i < st.blocks.Length; i++)
            {
                Assert.AreEqual(stE.blocks[i].Position, st.blocks[i].Position);
            }

            // Rotating
            st.Rotate();

            // Second rotation
            stE.blocks[0] = new Block(Color.Purple, new Point(0, 1), board);
            stE.blocks[1] = new Block(Color.Purple, new Point(1, 0), board);
            stE.blocks[2] = new Block(Color.Purple, new Point(1, 1), board);
            stE.blocks[3] = new Block(Color.Purple, new Point(1, 2), board);

            for (int i = 0; i < st.blocks.Length; i++)
            {
                Assert.AreEqual(stE.blocks[i].Position, st.blocks[i].Position);
            }

            // Rotating
            st.Rotate();

            // Third rotation
            stE.blocks[0] = new Block(Color.Purple, new Point(1, 0), board);
            stE.blocks[1] = new Block(Color.Purple, new Point(0, 1), board);
            stE.blocks[2] = new Block(Color.Purple, new Point(1, 1), board);
            stE.blocks[3] = new Block(Color.Purple, new Point(2, 1), board);

            for (int i = 0; i < st.blocks.Length; i++)
            {
                Assert.AreEqual(stE.blocks[i].Position, st.blocks[i].Position);
            }

            // Rotating
            st.Rotate();

            // Fourth rotation
            stE.blocks[0] = new Block(Color.Purple, new Point(0, 0), board);
            stE.blocks[1] = new Block(Color.Purple, new Point(0, 1), board);
            stE.blocks[2] = new Block(Color.Purple, new Point(1, 1), board);
            stE.blocks[3] = new Block(Color.Purple, new Point(0, 2), board);

            for (int i = 0; i < st.blocks.Length; i++)
            {
                Assert.AreEqual(stE.blocks[i].Position, st.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            // Init
            IBoard board = new Board();
            ShapeT st = new ShapeT(board);
            ShapeT stE = new ShapeT(board);

            st.Rotate();
            st.Reset();

            for (int i = 0; i < st.blocks.Length; i++)
            {
                Assert.AreEqual(stE.blocks[i].Position, st.blocks[i].Position);
            }
        }
    }
}
