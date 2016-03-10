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
        public void Test_Rotate()
        {
            // no need since its 2x2
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            so.MoveLeft();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2));

            so.MoveLeft();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }

        }

        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2));

            so.MoveRight();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 1));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 1));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1));

            so.MoveRight();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            so.MoveRight();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(9, 19));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(10, 19));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(9, 20));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(10, 20));

            so.MoveDown();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 19));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 19));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 20));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(20, 10));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            so.Drop();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

        //how do we test when the shapes arent linear?


        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeO so = new ShapeO();
            so.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            so.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            so.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            so.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            so.Reset();

            ShapeO soE = new ShapeO();
            soE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            soE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            soE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            soE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            for (int i = 0; i < so.blocks.Length; i++)
            {
                Assert.AreEqual(soE.blocks[i].Position, so.blocks[i].Position);
            }
        }

    }
}
