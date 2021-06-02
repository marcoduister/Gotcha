using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class Word
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid Maker_Id { get; set; }
        public User User { get; set; }
        public ICollection<WordLink> WordLinks { get; set; }

    }
}
