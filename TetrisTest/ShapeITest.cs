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
        public void Test_shapeI_Rotate1()
        {
            ShapeI shapei = new ShapeI();
            //rotate I shape to vertical position
            //shapei.Rotate();
            
            Block[] correct = new Block[4];
            correct[0] = new Block(Color.Aquamarine, new Point(0, 0));
            correct[1] = new Block(Color.Aquamarine, new Point(0, 1));
            correct[2] = new Block(Color.Aquamarine, new Point(0, 2));
            correct[3] = new Block(Color.Aquamarine, new Point(0, 3));

            Assert.AreEqual(correct, shapei.blocks);
            
        }
    }
}
