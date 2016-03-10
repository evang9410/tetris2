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
        public void Test_Rotate1()
        {
            ShapeS ss = new ShapeS();
            ShapeS ssE = new ShapeS();
            ss.Rotate();
           
            ssE.blocks[0] = new Block(Color.Tomato, new Point(0, 0));
            ssE.blocks[1] = new Block(Color.Tomato, new Point(0, 1));
            ssE.blocks[2] = new Block(Color.Tomato, new Point(1, 1));
            ssE.blocks[3] = new Block(Color.Tomato, new Point(1, 2));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Rotate_loopover()
        {
            ShapeS ss = new ShapeS();
            ShapeS ssE = new ShapeS();
            ss.Rotate();
            ss.Rotate();


            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }

        [TestMethod]
        public void Test_NoMove_MoveLeft()
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            ss.MoveLeft();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_MoveLeft()
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(2, 0));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(3, 0));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(1, 1));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(2, 1));

            ss.MoveLeft();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_NoMove_moveright()
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(8, 1));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(9, 1));

            ss.MoveRight();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(9, 0));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(10, 0));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(8, 1));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(9, 1));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Moveright()
        {
            ShapeS ss = new ShapeS();

            ss.MoveRight();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(2, 0));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(3, 0));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }

        }
        [TestMethod]
        public void Test_MoveDown()
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            ss.MoveDown();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 1));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 1));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 2));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 2));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_NoMove_MoveDown()
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20));

            ss.MoveDown();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_Drop() //needs access to the board 
        {
            ShapeS ss = new ShapeS();
            ss.blocks[0] = new Block(Color.Aquamarine, new Point(1, 0));
            ss.blocks[1] = new Block(Color.Aquamarine, new Point(2, 0));
            ss.blocks[2] = new Block(Color.Aquamarine, new Point(0, 1));
            ss.blocks[3] = new Block(Color.Aquamarine, new Point(1, 1));

            ss.Drop();

            ShapeS ssE = new ShapeS();
            ssE.blocks[0] = new Block(Color.Aquamarine, new Point(1, 19));
            ssE.blocks[1] = new Block(Color.Aquamarine, new Point(2, 19));
            ssE.blocks[2] = new Block(Color.Aquamarine, new Point(0, 20));
            ssE.blocks[3] = new Block(Color.Aquamarine, new Point(1, 20));

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }
        [TestMethod]
        public void Test_reset() //needs access to the board 
        {
            ShapeS ss = new ShapeS();
            ss.Rotate();

            ss.Reset();

            ShapeS ssE = new ShapeS();

            for (int i = 0; i < ss.blocks.Length; i++)
            {
                Assert.AreEqual(ssE.blocks[i].Position, ss.blocks[i].Position);
            }
        }

    }

}
    

