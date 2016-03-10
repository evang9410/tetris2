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
            ShapeT shapeT = new ShapeT(null);
            ShapeT shapeTTest = new ShapeT(null);

            // First rotation
            shapeTTest.blocks[0] = new Block(Color.Purple, new Point(0, 0), null);
            shapeTTest.blocks[1]  = new Block(Color.Purple, new Point(1, 0), null);
            shapeTTest.blocks[2]  = new Block(Color.Purple, new Point(2, 0), null);
            shapeTTest.blocks[3]  = new Block(Color.Purple, new Point(1, 1), null);

            for (int i = 0; i < shapeT.blocks.Length; i++)
            {
                Assert.AreEqual(shapeTTest.blocks[i].Position, shapeT.blocks[i].Position);
            }

            // Rotating
            shapeT.Rotate();

            // Second rotation
            shapeTTest.blocks[0]  = new Block(Color.Purple, new Point(0, 1), null);
            shapeTTest.blocks[1] = new Block(Color.Purple, new Point(1, 0), null);
            shapeTTest.blocks[2] = new Block(Color.Purple, new Point(1, 1), null);
            shapeTTest.blocks[3] = new Block(Color.Purple, new Point(1, 2), null);

            for (int i = 0; i < shapeT.blocks.Length; i++)
            {
                Assert.AreEqual(shapeTTest.blocks[i].Position, shapeT.blocks[i].Position);
            }

            // Rotating
            shapeT.Rotate();

            // Third rotation
            shapeTTest.blocks[0]  = new Block(Color.Purple, new Point(1, 0), null);
            shapeTTest.blocks[1]  = new Block(Color.Purple, new Point(0, 1), null);
            shapeTTest.blocks[2]  = new Block(Color.Purple, new Point(1, 1), null);
            shapeTTest.blocks[3]  = new Block(Color.Purple, new Point(2, 1), null);

            for (int i = 0; i < shapeT.blocks.Length; i++)
            {
                Assert.AreEqual(shapeTTest.blocks[i].Position, shapeT.blocks[i].Position);
            }

            // Rotating
            shapeT.Rotate();

            // Fourth rotation
            shapeTTest.blocks[0] = new Block(Color.Purple, new Point(0, 0), null);
            shapeTTest.blocks[1] = new Block(Color.Purple, new Point(0, 1), null);
            shapeTTest.blocks[2] = new Block(Color.Purple, new Point(1, 1), null);
            shapeTTest.blocks[3]  = new Block(Color.Purple, new Point(0, 2), null);

            for (int i = 0; i < shapeT.blocks.Length; i++)
            {
                Assert.AreEqual(shapeTTest.blocks[i].Position, shapeT.blocks[i].Position);
            }
        }
    }
}
