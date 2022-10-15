﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_1
{
    class GameAccount
    {
        private const int DFLT_RATING = 100;

        private static int GamesPlayedByAllPlayers { get; } = 0;

        private string UserName { get; }
        private int CurrentRating { get; }
        private int GamesCount { get; }

        public GameAccount(string UserName)
        {
            if (UserName.Length < 1) this.UserName = "guest";
            else this.UserName = UserName;
            CurrentRating = DFLT_RATING;
            GamesCount = 0;
        }

        public void WinGame(/*Match game*/)
        {
            return;
        }

        public void LoseGame(/*Match game*/)
        {
            return;
        }

        public void getStats()
        {
            return;
        }
    }
}
