using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;
using Microsoft.Xna.Framework;

namespace TetrisTest
{
    [TestClass]
    public class ShapeProxyTest
    {
        [TestMethod]
        public void Test_DeployNewShape()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);
            
            sp.DeployNewShape();

            IShape s = sp.CurrentShape;

            Assert.AreEqual(sp.CurrentShape, s);
            
        }

        [TestMethod]
        public void Test_MoveLeft()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);

            sp.DeployNewShape();
            IShape s = sp.CurrentShape;
            //since shape locations were hard coded at 0,0 and the addToPile method takes care of spawning them in the middle, Move it right so it can be moved left.
            s.MoveRight();
            int movedLeft = s[3].Position.X -1;
            s.MoveLeft();
            Assert.AreEqual(movedLeft, s[3].Position.X);
        }
        [TestMethod]
        public void Test_MoveRight()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);
            sp.DeployNewShape();
            IShape s = sp.CurrentShape;
            int movedRight = s[3].Position.X + 1;

            s.MoveRight();
            Assert.AreEqual(movedRight, s[3].Position.X);
        }
        [TestMethod]
        public void Test_MoveDown()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);
            sp.DeployNewShape();
            IShape s = sp.CurrentShape;
            int movedDown = s[3].Position.Y + 1;

            s.MoveDown();
            Assert.AreEqual(movedDown, s[3].Position.Y);
        }

        [TestMethod]
        public void Test_Drop()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);
            sp.DeployNewShape();
            IShape s = sp.CurrentShape;

            s.Drop();

            bool dropped = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Position.Y == board.GetLength(1) - 1)
                {
                    dropped = true;
                }
            }

            Assert.IsTrue(dropped);
        }
        [TestMethod]
        public void Test_Reset()
        {
            IBoard board = new Board();
            ShapeProxy sp = new ShapeProxy(board);
            sp.DeployNewShape();
            IShape s = sp.CurrentShape;
            int initial = s[3].Position.Y;
            s.MoveRight();
            s.Reset();
            Assert.AreEqual(initial, s[3].Position.Y);
        }

        
    }
}
