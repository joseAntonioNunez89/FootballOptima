using System;

namespace Football.Entities
{
    public class FootballGame
    {
        /// <summary>
        /// The name of the home team.
        /// </summary>
        public string homeTeam { get; set; }
        /// <summary>
        /// The name of the away team.
        /// </summary>
        public string awayTeam { get; set; }
        /// <summary>
        /// The home team points.
        /// </summary>
        public int homeScore { get; set; }
        /// <summary>
        /// The away team points
        /// </summary>
        public int awayScore { get; set; }
        /// <summary>
        /// Date of the game.
        /// </summary>
        public DateTime dateGame { get; set; }

    }
}
