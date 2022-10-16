﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class Match
    {
        private const int DFLT_RATING_CHANGE = 20;

        private GameAccount Player1 { get; }
        private GameAccount Player2 { get; }
        private int RatingChange1 { get; }
        private int RatingChange2 { get; }
        public GameAccount Winner { get; }

        public Match(GameAccount player1, GameAccount player2)
        {
            //I am not sure it's okay to compare objects like this. Should test it out
            if (player1 == player2) throw new ArgumentException("You can't play using the same player");
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
            
            this.Player1 = player1;
            this.Player2 = player2;

            int coinFlip = new Random().Next(1, 100);
            if (coinFlip <= 50)
            {
                Console.WriteLine(player1.UserName + " has won!");
                Winner = player1;
                player1.Play(this);
                player2.Play(this);
            }
            else
            {
                Console.WriteLine(player2.UserName + " has won!");
                Winner = player2;
                player1.Play(this);
                player2.Play(this);
            }
        }
    }
}
