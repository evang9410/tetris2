using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Tetris;
namespace TetrisTest
{
    [TestClass]
    public class ShapeITest
    {
        [TestMethod]
        public void Test_Rotate1()
        {
            ShapeI shapeI = new ShapeI();
            //First rotate
            shapeI.Rotate();

            ShapeI testShapeI = new ShapeI();
            testShapeI.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            testShapeI.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            testShapeI.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            testShapeI.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeI.blocks[i].Position, shapeI.blocks[i].Position);
            }

            //Second rotate
            shapeI.Rotate();

            testShapeI = new ShapeI();
            testShapeI.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            testShapeI.blocks[1] = new Block(Color.Aquamarine, new Point(0, 1));
            testShapeI.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2));
            testShapeI.blocks[3] = new Block(Color.Aquamarine, new Point(0, 3));

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeI.blocks[i].Position, shapeI.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            si.MoveLeft();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0));

            si.MoveLeft();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0));

            si.MoveRight();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(4, 0));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(5, 0));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0));

            si.MoveRight();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0));
            
            Assert.AreEqual(siE.blocks[3].Position, si.blocks[3].Position);
            
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0));

            si.MoveDown();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 1));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 1));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 20));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 20));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 20));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 20));

            si.MoveDown();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 20));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 20));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 20));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 20));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            si.Drop();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 20));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 20));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 20));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 20));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        //how do we test when the shapes arent linear?


        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeI si = new ShapeI();
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            si.Reset();

            ShapeI siE = new ShapeI();
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        
    }
}
