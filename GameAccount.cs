using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class GameAccount
    {
        private const int DFLT_RATING = 100;

        public static int GamesPlayedByAllPlayers { get; } = 0;

        public string UserName { get; }
        public int CurrentRating { get; }
        public int GamesCount { get; }

        private List<Match> Matches;

        public GameAccount(string UserName)
        {
            if (UserName.Length < 1) this.UserName = "guest";
            else this.UserName = UserName;
            CurrentRating = DFLT_RATING;
            GamesCount = 0;
            Matches = new List<Match>();
        }

        /*
        public void WinGame(Match game)
        {   

            return;
        }

        public void LoseGame(Match game)
        {
            return;
        }
        */
        //I've decided not to implement these methods because in my opinion results should be stored in Matches itselves
        public void Play(Match match)
        {
            Matches.Add(match);
        }

        public void getStats()
        {
            return;
        }
    }
}
