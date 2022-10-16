using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class Match
    {
        private const int DFLT_RATING_CHANGE = 20;

        private static int OverallGamesPlayed { get; set; } = 0;

        public GameAccount Player1 { get; }
        public GameAccount Player2 { get; }
        public int RatingChange1 { get; }
        public int RatingChange2 { get; }
        public GameAccount Winner { get; }
        public int MatchIndex { get; }

        public Match(GameAccount player1, GameAccount player2)
        {
            if (player1 == player2) throw new ArgumentException("You can't play using the same player.");

            OverallGamesPlayed++;
            this.MatchIndex = OverallGamesPlayed;

            RatingChange1 = DFLT_RATING_CHANGE;
            RatingChange2 = DFLT_RATING_CHANGE;
            
            this.Player1 = player1;
            this.Player2 = player2;

            int coinFlip = new Random().Next(1, 100);
            if (coinFlip <= 50)
            {
                Console.WriteLine(player1.UserName + " has won!");
                Winner = player1;

                if (player1.CurrentRating < player2.CurrentRating) RatingChange1 += (player2.CurrentRating - player1.CurrentRating) / 4;
                RatingChange2 = -RatingChange2;

                player1.SaveMatch(this, RatingChange1);
                player2.SaveMatch(this, RatingChange2);
            }
            else
            {
                Console.WriteLine(player2.UserName + " has won!");
                Winner = player2;

                if (player2.CurrentRating < player1.CurrentRating) RatingChange2 += (player1.CurrentRating - player2.CurrentRating) / 4;
                RatingChange1 = -RatingChange1;

                player1.SaveMatch(this, RatingChange1);
                player2.SaveMatch(this, RatingChange2);
            }
        }

        public static void Play(GameAccount player1, GameAccount player2)
        {
            new Match(player1, player2);
        }
    }
}
