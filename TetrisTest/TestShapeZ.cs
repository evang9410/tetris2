using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeZTest
    {
        [TestMethod]
        public void Test_Rotate()
        {
            // not done
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            sz.MoveLeft();

            ShapeO szE = new ShapeO();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2));

            sz.MoveLeft();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2));

            sz.MoveRight();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 1));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 1));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 2));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 2));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(8, 0));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(9, 0));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1));

            sz.MoveRight();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(8, 0));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(9, 0));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 0));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            sz.MoveRight();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 1));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 1));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 20));

            sz.MoveDown();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(0, 20));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            sz.Drop();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 20));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeZ sz = new ShapeZ();
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            sz.Reset();

            ShapeZ szE = new ShapeZ();
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0));
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0));
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }

    }
}
