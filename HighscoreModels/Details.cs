using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreModels
{
    public class Details
    {
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
