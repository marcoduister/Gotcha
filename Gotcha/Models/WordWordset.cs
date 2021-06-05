using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class WordWordset
    {

        //Atributte/property
        public Guid WordSet_Id { get; set; }
        public Guid Word_Id { get; set; }

        //Relations
        public Word Word { get; set; }
        public WordSet WordSet { get; set; }

    }
}
