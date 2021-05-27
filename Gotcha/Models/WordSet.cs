using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class WordSet
    {
        public Guid Id { get; set; }
        public Guid Maker_Id { get; set; }
        public ICollection<Word> Words { get; set; }
        public ICollection<Game> Games { get; set; }
        public User User { get; set; }
    }
}
