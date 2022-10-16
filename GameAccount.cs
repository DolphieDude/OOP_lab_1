using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class GameAccount
    {
        private const int DFLT_RATING = 100;

        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        private int GamesCount { get; set; }

        private List<Match> Matches { get; set; }

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
        public void SaveMatch(Match match, int ratingChange)
        {
            Matches.Add(match);
            GamesCount++;
            CurrentRating += ratingChange;
            if (CurrentRating < 1) CurrentRating = 1;
        }

        public void GetStats()
        {
            Console.WriteLine(UserName + " played " + GamesCount + " games; Current rating: " + CurrentRating + "; Games list:\n{");

            string currLine;
            foreach (Match match in Matches)
            {
                currLine = "Match id" + match.MatchIndex + ": ";
                
                if (this == match.Winner) currLine += "Win; ";
                else currLine += "Lose; ";

                if (this == match.Player1) currLine += match.RatingChange1 + " rating points; Opponent " + match.Player2.UserName + ";";
                else currLine += match.RatingChange2 + " rating points; Opponent " + match.Player1.UserName + ";";

                Console.WriteLine(currLine);
            }

            Console.WriteLine("}");
            return;
        }
    }
}
