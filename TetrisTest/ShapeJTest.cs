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
            ShapeJ shapeJ = new ShapeJ(null);
            ShapeJ shapeJTest = new ShapeJ(null);
            
            // First rotation
            shapeJTest.blocks[0] = new Block(Color.HotPink, new Point(1, 0), null);
            shapeJTest.blocks[1] = new Block(Color.HotPink, new Point(1, 1), null);
            shapeJTest.blocks[2] = new Block(Color.HotPink, new Point(1, 2), null);
            shapeJTest.blocks[3] = new Block(Color.HotPink, new Point(0, 2), null);

            for (int i = 0; i < shapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(shapeJTest.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            // Rotating
            shapeJ.Rotate();

            // Second rotation
            shapeJTest.blocks[0] = new Block(Color.HotPink, new Point(0, 1), null);
            shapeJTest.blocks[1] = new Block(Color.HotPink, new Point(0, 2), null);
            shapeJTest.blocks[2] = new Block(Color.HotPink, new Point(1, 2), null);
            shapeJTest.blocks[3] = new Block(Color.HotPink, new Point(2, 2), null);

            for (int i = 0; i < shapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(shapeJTest.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            // Rotating
            shapeJ.Rotate();

            // Third rotation
            shapeJTest.blocks[0] = new Block(Color.HotPink, new Point(0, 0), null);
            shapeJTest.blocks[1] = new Block(Color.HotPink, new Point(1, 0), null);
            shapeJTest.blocks[2] = new Block(Color.HotPink, new Point(0, 1), null);
            shapeJTest.blocks[3] = new Block(Color.HotPink, new Point(0, 2), null);

            for (int i = 0; i < shapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(shapeJTest.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            // Rotating
            shapeJ.Rotate();

            // Fourth rotation
            shapeJTest.blocks[0] = new Block(Color.HotPink, new Point(0, 0), null);
            shapeJTest.blocks[1] = new Block(Color.HotPink, new Point(1, 0), null);
            shapeJTest.blocks[2] = new Block(Color.HotPink, new Point(2, 0), null);
            shapeJTest.blocks[3] = new Block(Color.HotPink, new Point(2, 1), null);

            for (int i = 0; i < shapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(shapeJTest.blocks[i].Position, shapeJ.blocks[i].Position);
            }
        }
    }
}
