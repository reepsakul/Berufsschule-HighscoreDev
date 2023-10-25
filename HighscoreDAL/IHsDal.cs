using HighscoreModels;

namespace HighscoreDAL
{
    public interface IHsDal
    {
        public string FilePath { get; set; }
        public FileType FileType { get; set; }
        public List<Game> Games { get; }
        public List<Player> Players { get; }
        public List<HighScore> HighScores { get; }

        int Save();
    }

    public enum FileType
    {
        json,
        csv,
        xml
    }
}
