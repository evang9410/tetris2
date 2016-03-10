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
            ShapeL shapeL = new ShapeL(null);
            ShapeL shapeLTest = new ShapeL(null);

            // First rotation
            shapeLTest.blocks[0] = new Block(Color.Orange, new Point(0, 0), null);
            shapeLTest.blocks[1] = new Block(Color.Orange, new Point(0, 1), null);
            shapeLTest.blocks[2] = new Block(Color.Orange, new Point(0, 2), null);
            shapeLTest.blocks[3] = new Block(Color.Orange, new Point(1, 2), null);

            for (int i = 0; i < shapeL.blocks.Length; i++)
            {
                Assert.AreEqual(shapeLTest.blocks[i].Position, shapeL.blocks[i].Position);
            }

            // Rotating
            shapeL.Rotate();

            // Second rotation
            shapeLTest.blocks[0] = new Block(Color.Orange, new Point(0, 0), null);
            shapeLTest.blocks[1] = new Block(Color.Orange, new Point(0, 1), null);
            shapeLTest.blocks[2] = new Block(Color.Orange, new Point(1, 0), null);
            shapeLTest.blocks[3] = new Block(Color.Orange, new Point(2, 0), null);

            for (int i = 0; i < shapeL.blocks.Length; i++)
            {
                Assert.AreEqual(shapeLTest.blocks[i].Position, shapeL.blocks[i].Position);
            }

            // Rotating
            shapeL.Rotate();

            // Third rotation
            shapeLTest.blocks[0] = new Block(Color.Orange, new Point(1, 0), null);
            shapeLTest.blocks[1] = new Block(Color.Orange, new Point(2, 0), null);
            shapeLTest.blocks[2] = new Block(Color.Orange, new Point(2, 1), null);
            shapeLTest.blocks[3] = new Block(Color.Orange, new Point(2, 2), null);

            for (int i = 0; i < shapeL.blocks.Length; i++)
            {
                Assert.AreEqual(shapeLTest.blocks[i].Position, shapeL.blocks[i].Position);
            }

            // Rotating
            shapeL.Rotate();

            // Fourth rotation
            shapeLTest.blocks[0] = new Block(Color.Orange, new Point(2, 0), null);
            shapeLTest.blocks[1] = new Block(Color.Orange, new Point(2, 1), null);
            shapeLTest.blocks[2] = new Block(Color.Orange, new Point(1, 1), null);
            shapeLTest.blocks[3] = new Block(Color.Orange, new Point(0, 1), null);

            for (int i = 0; i < shapeL.blocks.Length; i++)
            {
                Assert.AreEqual(shapeLTest.blocks[i].Position, shapeL.blocks[i].Position);
            }
        }
    }
}
