using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class Match
    {
        private const int DFLT_RATING_CHANGE = 20;

        private GameAccount player1 { get; }
        private GameAccount player2 { get; }
        private int RatingChange1 { get; }
        private int RatingChange2 { get; }
        private GameAccount winner { get; set; }

        public Match(GameAccount player1, GameAccount player2)
        {
            if (player1.CurrentRating >= player2.CurrentRating)
            {
                RatingChange1 = DFLT_RATING_CHANGE;
                RatingChange2 = DFLT_RATING_CHANGE + (player1.CurrentRating - player2.CurrentRating) / 2;
            }
            else
            {
                RatingChange2 = DFLT_RATING_CHANGE;
                RatingChange1 = DFLT_RATING_CHANGE + (player2.CurrentRating - player1.CurrentRating) / 2;
            }
        }
    }
}
