using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest
{
    [TestClass]
    public class Board_Test
    {
        [TestMethod]
        public void Test_GetLength ()
        {
            IBoard board = new Board();
            int l =  board.GetLength(0);
            Assert.AreEqual(l,10);
        }  
        [TestMethod]
        public void Test_GetLength_1()
        {
            IBoard board = new Board();
            int l = board.GetLength(1);
            Assert.AreEqual(l, 20);
        }
        
    }
}
