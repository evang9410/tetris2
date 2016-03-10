using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;
using Microsoft.Xna.Framework;

namespace TetrisTest
{
    [TestClass]
    public class ShapeJTest
    {
        [TestMethod]
        public void Test_Rotate_Rollover()
        {
            ShapeJ shapeJ = new ShapeJ();
            //First rotate
            shapeJ.Rotate();

            ShapeJ testShapeJ = new ShapeJ();
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 1));
            testShapeJ.blocks[1] = new Block(Color.HotPink, new Point(0, 2));
            testShapeJ.blocks[2] = new Block(Color.HotPink, new Point(1, 2));
            testShapeJ.blocks[3] = new Block(Color.HotPink, new Point(2, 2));

            for (int i = 0; i < testShapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeJ.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            
            //Second rotate
            shapeJ.Rotate();

            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(1, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 1));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 2));

            for (int i = 0; i < shapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeJ.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            /*
            //Third rotate
            shapeJ.Rotate();

            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(1, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(2, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(2, 1));

            for (int i = 0; i < testShapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeJ.blocks[i].Position, shapeJ.blocks[i].Position);
            }

            //Fourth rotate (Initial)
            shapeJ.Rotate();

            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(1, 0));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(1, 1));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(1, 2));
            testShapeJ.blocks[0] = new Block(Color.HotPink, new Point(0, 2));

            for (int i = 0; i < testShapeJ.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeJ.blocks[i].Position, shapeJ.blocks[i].Position);
            }*/
        }
    }
}
