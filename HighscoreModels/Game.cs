using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreModels
{
    public class Game : Details
    {
        public int GameID { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public string Publisher { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{GameID},{Title},{PublishedDate},{Publisher},{Entry},{Exit},{IsActive},{Notes}";
        }
    }
}
