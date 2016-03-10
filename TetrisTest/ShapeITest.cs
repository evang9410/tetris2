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
        public void Test_Rotations()
        {
            ShapeI shapeI = new ShapeI(null);
            //First rotate
            shapeI.Rotate();

            ShapeI testShapeI = new ShapeI(null);
            testShapeI.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            testShapeI.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            testShapeI.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            testShapeI.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeI.blocks[i].Position, shapeI.blocks[i].Position);
            }

            //Second rotate (Initial)
            shapeI.Rotate();

            testShapeI = new ShapeI(null);
            testShapeI.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            testShapeI.blocks[1] = new Block(Color.Aquamarine, new Point(0, 1), null);
            testShapeI.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            testShapeI.blocks[3] = new Block(Color.Aquamarine, new Point(0, 3), null);

            for (int i = 0; i < shapeI.blocks.Length; i++)
            {
                Assert.AreEqual(testShapeI.blocks[i].Position, shapeI.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            si.MoveLeft();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), null);

            si.MoveLeft();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            Board b = new Board(new Color[10, 20], null, null);
            ShapeI si = new ShapeI(b);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), b);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), b);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), b);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), b);

            si.MoveRight();

            ShapeI siE = new ShapeI(b);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0), b);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0), b);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(4, 0), b);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(5, 0), b);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), null);

            si.MoveRight();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(7, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(8, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), null);
            
            Assert.AreEqual(siE.blocks[3].Position, si.blocks[3].Position);
            
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 0), null);

            si.MoveDown();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 1), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 1), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(1, 20), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(2, 20), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(3, 20), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(4, 20), null);

            si.MoveDown();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 20), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 20), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 20), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 20), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            si.Drop();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 20), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 20), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 20), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 20), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }

        //how do we test when the shapes arent linear?


        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeI si = new ShapeI(null);
            si.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            si.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            si.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            si.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            si.Reset();

            ShapeI siE = new ShapeI(null);
            siE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            siE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            siE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0), null);
            siE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0), null);

            for (int i = 0; i < si.blocks.Length; i++)
            {
                Assert.AreEqual(siE.blocks[i].Position, si.blocks[i].Position);
            }
        }
        
    }
}
