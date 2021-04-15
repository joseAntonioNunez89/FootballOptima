using Football.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTests.Asserts
{
    public class FootballAserts
    {
        public static List<FootballGame> StartGameAssert()
        {
            return new List<FootballGame>()
            {
                new FootballGame() { homeTeam = "Uruguay", awayTeam = "Italy", homeScore = 6, awayScore = 6, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Spain", awayTeam = "Brazil", homeScore = 10, awayScore = 2, dateGame = new DateTime(1984,5,12)},
                new FootballGame() { homeTeam = "Mexico", awayTeam = "Canada", homeScore = 0, awayScore = 5, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Argentina", awayTeam = "Australia", homeScore = 3, awayScore = 1, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Germany", awayTeam = "France", homeScore = 2, awayScore = 2, dateGame = new DateTime(1982,5,12)},
                new FootballGame() { homeTeam = "Senegal", awayTeam = "Marroco", homeScore = 0, awayScore = 0, dateGame = DateTime.Now.Date}
            };
        }

        public static List<FootballGame> FinishGameAssert()
        {
            return new List<FootballGame>()
            {
                new FootballGame() { homeTeam = "Uruguay", awayTeam = "Italy", homeScore = 6, awayScore = 6, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Spain", awayTeam = "Brazil", homeScore = 10, awayScore = 2, dateGame = new DateTime(1984,5,12)},
                new FootballGame() { homeTeam = "Argentina", awayTeam = "Australia", homeScore = 3, awayScore = 1, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Germany", awayTeam = "France", homeScore = 2, awayScore = 2, dateGame = new DateTime(1982,5,12)}
            };
        }

        public static List<FootballGame> UpdateGameScoreLiveAssert()
        {
            return new List<FootballGame>()
            {
                new FootballGame() { homeTeam = "Uruguay", awayTeam = "Italy", homeScore = 6, awayScore = 6, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Spain", awayTeam = "Brazil", homeScore = 10, awayScore = 2, dateGame = new DateTime(1984,5,12)},
                new FootballGame() { homeTeam = "Mexico", awayTeam = "Canada", homeScore = 0, awayScore = 5, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Argentina", awayTeam = "Australia", homeScore = 3, awayScore = 1, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Germany", awayTeam = "France", homeScore = 2, awayScore = 2, dateGame = new DateTime(1982,5,12)},
                new FootballGame() { homeTeam = "Senegal", awayTeam = "Marroco", homeScore = 1, awayScore = 2, dateGame = DateTime.Now.Date}
            };
        }

        public static List<FootballGame> UpdateGameWithDateAssert()
        {
            return new List<FootballGame>()
            {
                new FootballGame() { homeTeam = "Spain", awayTeam = "Brazil", homeScore = 15, awayScore = 2, dateGame = new DateTime(1984,5,12)},
                new FootballGame() { homeTeam = "Uruguay", awayTeam = "Italy", homeScore = 6, awayScore = 6, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Mexico", awayTeam = "Canada", homeScore = 0, awayScore = 5, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Argentina", awayTeam = "Australia", homeScore = 3, awayScore = 1, dateGame = new DateTime(1985,5,12)},
                new FootballGame() { homeTeam = "Germany", awayTeam = "France", homeScore = 2, awayScore = 2, dateGame = new DateTime(1982,5,12)}
            };
        }
    }
}
