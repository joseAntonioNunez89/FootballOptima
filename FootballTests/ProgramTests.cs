using Football.Entities;
using FootballTests.Asserts;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System;

namespace Football.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void StartGameTest()
        {
            //Arrange
            Football football = new Football();

            //Act
            List<FootballGame> games = football.StartGame("Senegal", "Marroco");

            List<FootballGame> gamesExpected = FootballAserts.StartGameAssert();

            //Assert
            Assert.IsTrue(CompareGamesList(gamesExpected, games));

            //I have considered to do it with CollectionAssert.AreEqual, but it compares also the references and it does not work, 
            //I also considered to do it with linq instead of the for loop, but the two loops are nested and the result is not correct, 
            //at the end I have thought to do that method, I do not know if some other more effective way to do it.
        }

        [TestMethod()]
        public void FinishGameTest()
        {
            //Arrange
            Football football = new Football();

            //Act
            List<FootballGame> games = football.FinishGame("Mexico", "Canada", new DateTime(1985, 5, 12));

            List<FootballGame> gamesExpected = FootballAserts.FinishGameAssert();

            //Assert
            Assert.IsTrue(CompareGamesList(gamesExpected, games));
        }

        [TestMethod()]
        public void UpdateGameScoreLiveTest()
        {
            //Arrange
            Football football = new Football();
            football.StartGame("Senegal", "Marroco");

            //Act
            List<FootballGame> games = football.UpdateGameScoreLive("Senegal", "Marroco", 1, 2);

            List<FootballGame> gamesExpected = FootballAserts.UpdateGameScoreLiveAssert();

            //Assert
            Assert.IsTrue(CompareGamesList(gamesExpected, games));
        }

        [TestMethod()]
        public void UpdateGameWithDateTest()
        {
            //Arrange
            Football football = new Football();

            //Act
            List<FootballGame> games = football.UpdateGameWithDate("Spain", "Brazil", 15, 2, new DateTime(1984, 5, 12));

            List<FootballGame> gamesExpected = FootballAserts.UpdateGameWithDateAssert();

            //Assert
            Assert.IsTrue(CompareGamesList(gamesExpected, games));
        }

        public static bool CompareGamesList(List<FootballGame> expected, List<FootballGame> actual)
        {
            if (expected.Count != actual.Count)
            {
                return false;
            }

            for (var i = 0; i < actual.Count; i++)
            {
                if (expected[i].homeScore != actual[i].homeScore
                    || expected[i].homeTeam != actual[i].homeTeam
                    || expected[i].awayScore != actual[i].awayScore
                    || expected[i].awayTeam != actual[i].awayTeam
                    || expected[i].dateGame != actual[i].dateGame)
                {
                    return false;
                }
            }

            return true;
        }
    }
}