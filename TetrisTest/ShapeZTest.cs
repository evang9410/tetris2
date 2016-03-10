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
        public void Test_Rotations()
        {
            // not done
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            sz.MoveLeft();

            ShapeO szE = new ShapeO(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2), null);

            sz.MoveLeft();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 1), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 1), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 2), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 2), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_MoveRight()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(2, 2), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(3, 2), null);

            sz.MoveRight();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 1), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 1), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(3, 2), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(4, 2), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(8, 0), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(9, 0), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1), null);

            sz.MoveRight();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(8, 0), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(9, 0), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(9, 1), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(10, 1), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            sz.MoveRight();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 1), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 1), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 20), null);

            sz.MoveDown();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(0, 20), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            sz.Drop();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 19), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 19), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 20), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 20), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeZ sz = new ShapeZ(null);
            sz.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            sz.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            sz.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            sz.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            sz.Reset();

            ShapeZ szE = new ShapeZ(null);
            szE.blocks[0] = new Block(Color.Aquamarine, new Point(0, 0), null);
            szE.blocks[1] = new Block(Color.Aquamarine, new Point(1, 0), null);
            szE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            szE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            for (int i = 0; i < sz.blocks.Length; i++)
            {
                Assert.AreEqual(szE.blocks[i].Position, sz.blocks[i].Position);
            }
        }

    }
}
