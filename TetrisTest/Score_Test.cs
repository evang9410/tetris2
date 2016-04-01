using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris;

namespace TetrisTest {
    [TestClass]
    public class Score_Test {
        [TestMethod]
        public void Test_Lines() {
            Board board = new Board();
            Score newScore = new Score(board);
            newScore.incrementLinesCleared(2);
            Assert.AreEqual(newScore.Lines, 2);
        }

        [TestMethod]
        public void Test_Level() {
            Board board = new Board();
            Score newScore = new Score(board);
            newScore.incrementLinesCleared(2);
            Assert.AreEqual(newScore.Level, 1);
        }

        [TestMethod]
        public void Test_Scores() {
            Board board = new Board();
            Score newScore = new Score(board);
            newScore.incrementLinesCleared(2);
            Assert.AreEqual(newScore.Points, 4);

        }

        [TestMethod]
        public void Test_Level_More_Then_10() {
            Board board = new Board();
            Score newScore = new Score(board);
            newScore.incrementLinesCleared(110);
            Assert.AreEqual(newScore.Level, 10);
        }
    }
}

