using HighscoreDAL;
using HighscoreModels;
using System;

class Program
{
    static void Main()
    {
        var hsDal = new HsDal();
        hsDal._games = new List<Game> {
            new Game { GameID = 0, Title = "Fortnite", Entry = DateTime.Now, Exit = DateTime.Now, IsActive = true, Notes = "Servus", PublishedDate = DateTime.Now, Publisher = "Epic Games" },
            new Game { GameID = 1, Title = "Roblox", Entry = DateTime.Now, Exit= DateTime.Now, IsActive = true, Notes = "Halleluja", PublishedDate = DateTime.Now, Publisher = "Roblox Inc."}
        };
        hsDal._players = new List<Player> {
            new Player { PlayerID = 0, NickName = "UWULucaHD", Email = "luca.uwu.hd@gmail.com", BirthDay = DateTime.Now, FName = "Luca", LName = "Liebhart", Entry = DateTime.Now, Exit = DateTime.Now, IsActive = true, Notes = "Matschbanana" },
            new Player{ PlayerID = 1, NickName = "MinJung", Email = "samu.rainer@gmail.com", BirthDay = DateTime.Now, FName = "Samuel", LName = "Rainer", Entry = DateTime.Now, Exit = DateTime.Now, IsActive = true, Notes = "Rainer Wahnsinn!" },
            new Player{ PlayerID = 2, NickName = "M-3y3r", Email = "lukaspeer93@gmail.com", BirthDay = DateTime.Now, FName = "Lukas", LName = "Peer", Entry = DateTime.Now, Exit = DateTime.Now, IsActive = true, Notes = "Groß M, kleine eyer" }
        };
        hsDal._highscores = new List<HighScore> {
            new HighScore{ GameID = 0, PlayerID = 0, ScoreDate = DateTime.Now, Score = 7 },
            new HighScore{ GameID = 0, PlayerID = 1, ScoreDate = DateTime.Now, Score = 7 },
            new HighScore{ GameID = 0, PlayerID = 2, ScoreDate = DateTime.Now, Score = 7 },
            new HighScore{ GameID = 1, PlayerID = 0, ScoreDate = DateTime.Now, Score = 1 },
            new HighScore{ GameID = 1, PlayerID = 1, ScoreDate = DateTime.Now, Score = 7 },
            new HighScore{ GameID = 1, PlayerID = 2, ScoreDate = DateTime.Now, Score = 10 }
        };
        hsDal.Save();
    }
}
