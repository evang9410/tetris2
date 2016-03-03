using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Tetris;
namespace TetrisTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_clearlines()
        {

            Color[,] origin_board = new Color[,]{
                {Color.Blue,Color.Red,Color.Green},
                {Color.Blue,Color.Red,Color.Green},
                {Color.Blue,Color.Red,Color.Green}};

            Color[,] new_board = new Color[,]{
                {Color.Black, Color.Black, Color.Black},
                {Color.Black, Color.Black, Color.Black},
                {Color.Black, Color.Black, Color.Black}};

            Board b = new Board(origin_board, null, null);
            Board b1 = new Board(new_board, null, null);

            b.linesToClear();

            Assert.AreEqual(b1, b);

        }
    }
}
