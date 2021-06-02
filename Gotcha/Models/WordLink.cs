using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class WordLink
    {
        public Guid Word_Id { get; set; }
        public Word Word { get; set; }

        public Guid WordSet_Id { get; set; }
        public WordSet WordSet { get; set; }

    }
}
