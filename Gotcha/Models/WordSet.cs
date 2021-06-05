using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class WordSet
    {

        //Atributte/propertie
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Maker_Id { get; set; }

        //Relations
        public List<WordWordset> WordWordset { get; set; }
        public List<Game> Games { get; set; }
        public User User { get; set; }
    }
}
