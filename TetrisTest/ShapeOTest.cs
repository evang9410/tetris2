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
            // no need since its 2x2
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            so.MoveLeft();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2), null);

            so.MoveLeft();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2), null);

            so.MoveRight();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 1), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 1), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1), null);

            so.MoveRight();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            so.MoveRight();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(9, 19), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(10, 19), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(9, 20), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(10, 20), null);

            so.MoveDown();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 19), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 19), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 20), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(20, 10), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            so.Drop();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        //how do we test when the shapes arent linear?


        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeO so = new ShapeO(null);
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            so.Reset();

            ShapeO soE = new ShapeO(null);
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

    }
}
