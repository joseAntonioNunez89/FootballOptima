using Football.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Football
{
    public class Football
    {
        public List<FootballGame> games = new List<FootballGame>()
        {
            new FootballGame() { homeTeam = "Mexico", awayTeam = "Canada", homeScore = 0, awayScore = 5, dateGame = new DateTime(1985,5,12)},
            new FootballGame() { homeTeam = "Spain", awayTeam = "Brazil", homeScore = 10, awayScore = 2, dateGame = new DateTime(1984,5,12)},
            new FootballGame() { homeTeam = "Germany", awayTeam = "France", homeScore = 2, awayScore = 2, dateGame = new DateTime(1982,5,12)},
            new FootballGame() { homeTeam = "Uruguay", awayTeam = "Italy", homeScore = 6, awayScore = 6, dateGame = new DateTime(1985,5,12)},
            new FootballGame() { homeTeam = "Argentina", awayTeam = "Australia", homeScore = 3, awayScore = 1, dateGame = new DateTime(1985,5,12)},
        };

        /// <summary>
        /// Start a new game.
        /// </summary>
        /// <param name="homeTeam">Home team</param>
        /// <param name="awayTeam">Away team</param>
        public List<FootballGame> StartGame (string homeTeam, string awayTeam)
        {
            games.Add(new FootballGame { homeTeam = homeTeam, awayTeam = awayTeam, homeScore = 0, awayScore = 0, dateGame = DateTime.Now.Date });

            return ReturnGamesSort();
        }
        /// <summary>
        /// Enda and delete a game.
        /// </summary>
        /// <param name="homeTeam">home team</param>
        /// <param name="awayTeam">away team</param>
        /// <param name="dateGame">date of the game</param>
        public List<FootballGame> FinishGame (string homeTeam, string awayTeam, DateTime dateGame)
        {
            games.RemoveAll(x => x.homeTeam.Contains(homeTeam) && x.awayTeam.Contains(awayTeam) && x.dateGame.Date == dateGame.Date);

            return ReturnGamesSort();
        }
        /// <summary>
        /// Update the score of a game in live.
        /// </summary>
        /// <param name="hombeTeam">home team</param>
        /// <param name="awayTeam">away team</param>
        /// <param name="homeScore">home score</param>
        /// <param name="awayScore">away score</param>
        public List<FootballGame> UpdateGameScoreLive (string hombeTeam, string awayTeam, int homeScore, int awayScore)
        {
            games.FirstOrDefault(x => x.homeTeam == hombeTeam && x.awayTeam == awayTeam && x.dateGame.Date == DateTime.Now.Date).homeScore = homeScore;
            games.FirstOrDefault(x => x.homeTeam == hombeTeam && x.awayTeam == awayTeam && x.dateGame.Date == DateTime.Now.Date).awayScore = awayScore;

            return ReturnGamesSort();
        }
        /// <summary>
        /// Update the score of a game with his date.
        /// </summary>
        /// <param name="hombeTeam"></param>
        /// <param name="awayTeam"></param>
        /// <param name="homeScore"></param>
        /// <param name="awayScore"></param>
        /// <param name="dateGame"></param>
        public List<FootballGame> UpdateGameWithDate (string hombeTeam, string awayTeam, int homeScore, int awayScore, DateTime dateGame)
        {
            games.FirstOrDefault(x => x.homeTeam == hombeTeam && x.awayTeam == awayTeam && x.dateGame.Date == dateGame.Date).homeScore = homeScore;
            games.FirstOrDefault(x => x.homeTeam == hombeTeam && x.awayTeam == awayTeam && x.dateGame.Date == dateGame.Date).awayScore = awayScore;

            return ReturnGamesSort();
        }
        public List<FootballGame> ReturnGamesSort()
        {
            List<FootballGame> gamesSorted = games.OrderByDescending(x => x.homeScore + x.awayScore).ThenByDescending(x => x.dateGame).ToList();

            return gamesSorted;
        }
    }
}
