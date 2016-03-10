using System;
using Microsoft.Xna.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class ShapeSTest
    { 
        [TestMethod]
        public void Test_Rotations()
        {

        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            ss.MoveLeft();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            ss.MoveLeft();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(8, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(9, 1), null);

            ss.MoveRight();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(8, 1), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(9, 1), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Moveright()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            ss.MoveRight();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            ss.MoveDown();

            ShapeS ssE = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20), null);

            ss.MoveDown();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            ss.Drop();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeS ss = new ShapeS(null);
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            ss.Reset();

            ShapeS ssE = new ShapeS(null);
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0), null);
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0), null);
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1), null);
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1), null);

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }

    }

}
    

