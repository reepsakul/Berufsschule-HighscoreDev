using HighscoreModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HighscoreDAL
{
    public class HsDal : IHsDal
    {
        public List<Game>? _games;
        public List<Player>? _players;
        public List<HighScore>? _highscores;

        public string FilePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Highscore";
        public FileType FileType { get; set; } = FileType.xml;
        private StringBuilder _stringBuilder = new StringBuilder();

        public List<Game> Games {
            get {
                return _games ??= LoadGames();
            }}
        public List<Player> Players {
            get {
                return _players ??= LoadPlayers();
            }}
        public List<HighScore> HighScores {
            get {
                return _highscores ??= LoadHighScores();
            }}

        public int Save() {
            switch (FileType)
            {
                case FileType.json:
                    saveJson();
                    break;
                case FileType.csv:
                    saveCSV();
                    break;
                case FileType.xml:
                    saveXML();
                    break;
            }
            return ( _games is null ? 0 : _games.Count) +
                (_players is null ? 0 : _players.Count) +
                (_highscores is null ? 0 : _highscores.Count);
        }

        private void saveJson()
        {
            if (_games is not null) { 
                File.WriteAllText(FilePath + @"\Games.json", JsonSerializer.Serialize<List<Game>>(Games));
            }
            if (_players is not null) {
                File.WriteAllText(FilePath + @"\Players.json", JsonSerializer.Serialize<List<Player>>(Players));
            }
            if (_highscores is not null) {
                File.WriteAllText(FilePath + @"\Highscores.json", JsonSerializer.Serialize<List<HighScore>>(HighScores));
            }
        }

        private void saveCSV()
        {
            if (_games is not null) {
                _stringBuilder.AppendLine("GameID,Title,PublishedDate,Publisher,Entry,Exit,IsActive,Notes");
                foreach (Game game in Games) {
                    _stringBuilder.AppendLine(game.ToString());
                }
                File.WriteAllText(FilePath + @"\Games.csv", _stringBuilder.ToString());
            }
            _stringBuilder.Clear();
            if (_players is not null) {
                _stringBuilder.AppendLine("PlayerID,NickName,Email,BirthDay,FName,LName,Entry,Exit,IsActive,Notes");
                foreach (Player player in Players) {
                    _stringBuilder.AppendLine(player.ToString());
                }
                File.WriteAllText(FilePath + @"\Players.csv", _stringBuilder.ToString());
            }
            _stringBuilder.Clear();
            if (_highscores is not null) {
                _stringBuilder.AppendLine("PlayerID,GameID,ScoreDate,Score");
                foreach (HighScore highScore in HighScores) {
                    _stringBuilder.AppendLine(highScore.ToString());
                }
                File.WriteAllText(FilePath + @"\Highscores.csv", _stringBuilder.ToString());
            }
            _stringBuilder.Clear();
        }

        private void saveXML()
        {
            if (_games is not null)
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<Game>));
                FileStream stream = new(FilePath + @"\Games.xml", FileMode.OpenOrCreate);
                writer.Serialize(stream, _games);
                stream.Close();
            }
            if (_players is not null)
            {

            }
            if (_highscores is not null)
            {

            }
        }

        private List<Game> LoadGames()
        {
            switch (FileType) { 
                case FileType.json:
                    _games = JsonSerializer.Deserialize<List<Game>>(File.ReadAllText(FilePath));
                    break;
                case FileType.csv:
                    break;
                case FileType.xml:
                    var xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(FilePath);
                    break;
            }
            throw new NotImplementedException();
        }

        private List<Player> LoadPlayers()
        {
            switch (FileType)
            {
                case FileType.json:
                    _players = JsonSerializer.Deserialize<List<Player>>(File.ReadAllText(FilePath));
                    break;
                case FileType.csv:
                    break;
                case FileType.xml:
                    var xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(FilePath);
                    break;
            }
            throw new NotImplementedException();
        }

        private List<HighScore> LoadHighScores()
        {
            switch (FileType)
            {
                case FileType.json:
                    _highscores = JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FilePath));
                    break;
                case FileType.csv:
                    break;
                case FileType.xml:
                    var xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(FilePath);
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
